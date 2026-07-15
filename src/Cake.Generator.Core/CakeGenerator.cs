// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

/// <summary>
/// A source generator that creates Cake aliases for your project.
/// </summary>
[Generator]
public partial class CakeGenerator : IIncrementalGenerator
{
    /// <summary>
    /// Initializes the generator.
    /// </summary>
    /// <param name="context">The incremental generator initialization context.</param>
    /// <remarks>
    /// This uses the incremental generator pattern for performance, but still scans referenced assemblies
    /// for Cake method/property aliases and modules, as required for full Cake addin support.
    ///
    /// OCE: Object Creation Expressions for Roslyn symbols and code generation are used throughout.
    ///
    /// Key steps:
    /// 1. Gather all relevant Roslyn symbols from the compilation (attributes, interfaces, etc).
    /// 2. For each referenced assembly, scan for Cake method/property aliases and modules.
    /// 3. Aggregate and generate all proxy code, global usings, script host, and helper files.
    /// 4. Output generated sources using context.RegisterSourceOutput.
    /// </remarks>
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Use the incremental generator pattern, but scan referenced assemblies as before
        var compilationProvider = context.CompilationProvider
            .Select((compilation, cancellationToken) =>
            {
                // OCE: Gather all required symbols for Cake alias/module discovery
                var extensionAttributeSymbol = compilation.GetTypeByMetadataName(ExtensionAttributeFullName);
                var cakeMethodAliasAttributeSymbol = compilation.GetTypeByMetadataName(CakeMethodAliasAttributeFullName);
                var cakePropertyAliasAttributeSymbol = compilation.GetTypeByMetadataName(CakePropertyAliasAttributeFullName);
                var cakeNamespaceImportAttributeSymbol = compilation.GetTypeByMetadataName(CakeNamespaceImportAttributeFullName);
                var iCakeContextSymbol = compilation.GetTypeByMetadataName(ICakeContextFullName);
                var cakeModuleAttributeSymbol = compilation.GetTypeByMetadataName(CakeModuleAttributeFullName);
                var iCakeModuleSymbol = compilation.GetTypeByMetadataName(ICakeModuleFullName);
                var obsoleteAttributeSymbol = compilation.GetTypeByMetadataName("System.ObsoleteAttribute");

                // Defensive: If any required symbol is missing, skip generation
                if (extensionAttributeSymbol == null ||
                    (cakeMethodAliasAttributeSymbol == null && cakePropertyAliasAttributeSymbol == null) ||
                    iCakeContextSymbol == null)
                {
                    return (compilation, null as ImmutableArray<MethodInfo>?, null as ImmutableArray<ModuleInfo>?);
                }

                // Defensive: If no references, skip generation
                if (!compilation.References.Any())
                {
                    return (compilation, null as ImmutableArray<MethodInfo>?, null as ImmutableArray<ModuleInfo>?);
                }

                // OCE: Scan all referenced assemblies for Cake aliases and modules
                var allMethods = new List<MethodInfo>();
                var allModules = new List<ModuleInfo>();
                foreach (var assembly in compilation.References)
                {
                    if (compilation.GetAssemblyOrModuleSymbol(assembly) is IAssemblySymbol assemblySymbol)
                    {
                        var foundMethods = ScanTypeMembers(assemblySymbol.GlobalNamespace, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol);
                        allMethods.AddRange(foundMethods);

                        if (cakeModuleAttributeSymbol != null && iCakeModuleSymbol != null)
                        {
                            var foundModules = ScanForModules(assemblySymbol, cakeModuleAttributeSymbol, iCakeModuleSymbol, obsoleteAttributeSymbol);
                            allModules.AddRange(foundModules);
                        }
                    }
                }

                return (compilation,
                    allMethods.Count > 0 ? allMethods.ToImmutableArray() : null,
                    allModules.Count > 0 ? allModules.ToImmutableArray() : null);
            });

        // OCE: Output all generated sources for Cake proxying and helpers
        context.RegisterSourceOutput(compilationProvider, (sourceProductionContext, data) =>
        {
            var (compilation, methods, modules) = data;

            // Generate constants always (independent of methods)
            var constants = GenerateConstants();
            sourceProductionContext.AddSource("CakeConstants.g.cs", SourceText.From(constants, Encoding.UTF8));

            if (methods == null || !methods.HasValue)
            {
                return;
            }

            // Single-pass classification to minimize allocations
            List<MethodInfo>? methodAliases = null;
            List<MethodInfo>? propertyAliases = null;
            List<MethodInfo>? methodList = null;

            foreach (var method in methods.Value)
            {
                (methodList ??= []).Add(method);
                if (method.IsPropertyAlias)
                {
                    (propertyAliases ??= []).Add(method);
                }
                else
                {
                    (methodAliases ??= []).Add(method);
                }
            }

            // Generate global usings
            if (methodList != null)
            {
                var globalUsings = GenerateGlobalUsings(methodList);
                sourceProductionContext.AddSource("CakeAliasGlobalUsings.g.cs", SourceText.From(globalUsings, Encoding.UTF8));
            }

            // Generate script host with compilation for dynamic generation
            var scriptHost = GenerateScriptHost(compilation);
            sourceProductionContext.AddSource("CakeScriptHost.g.cs", SourceText.From(scriptHost, Encoding.UTF8));

            // Generate service provider
            sourceProductionContext.AddSource("CakeServiceProvider.g.cs", SourceText.From(ServiceProvider, Encoding.UTF8));

            // Generate helper services methods
            sourceProductionContext.AddSource("CakeHelper.AddCakeCore.g.cs", SourceText.From(Helper.AddCakeCore, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.AddCakeCli.g.cs", SourceText.From(Helper.AddCakeCli, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.AddCakeGenerator.g.cs", SourceText.From(Helper.AddCakeGenerator, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.AddCakeToolInstaller.g.cs", SourceText.From(Helper.AddCakeToolInstaller, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.PostBuildServiceProvider.g.cs", SourceText.From(Helper.PostBuildServiceProvider, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.RegisterExceptionHandlers.g.cs", SourceText.From(Helper.RegisterExceptionHandlers, Encoding.UTF8));

            // Generate cake app settings
            sourceProductionContext.AddSource("CakeCakeAppSettings.g.cs", SourceText.From(CakeAppSettings, Encoding.UTF8));

            // Generate method aliases if any exist
            if (methodAliases != null && methodAliases.Count > 0)
            {
                var methodAliasesSource = GenerateMethodAliases(methodAliases);
                sourceProductionContext.AddSource("CakeMethodAliases.g.cs", SourceText.From(methodAliasesSource, Encoding.UTF8));
            }

            // Generate property aliases if any exist
            if (propertyAliases != null && propertyAliases.Count > 0)
            {
                var propertyAliasesSource = GeneratePropertyAliases(propertyAliases);
                sourceProductionContext.AddSource("CakePropertyAliases.g.cs", SourceText.From(propertyAliasesSource, Encoding.UTF8));
            }

            // Generate modules if any exist
            if (modules is { Length: > 0 } hasModules)
            {
                var modulesSource = GenerateModules(hasModules);
                sourceProductionContext.AddSource("CakeModules.g.cs", SourceText.From(modulesSource, Encoding.UTF8));
            }
        });
    }
}