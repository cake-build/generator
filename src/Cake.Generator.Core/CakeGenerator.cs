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
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Create a provider that collects all compilation data we need
        var compilationProvider = context.CompilationProvider
            .Select<Compilation, (Compilation compilation, ImmutableArray<MethodInfo>? methods, ImmutableArray<ModuleInfo>? modules)>((compilation, cancellationToken) =>
            {
                var extensionAttributeSymbol = compilation.GetTypeByMetadataName(ExtensionAttributeFullName);
                var cakeMethodAliasAttributeSymbol = compilation.GetTypeByMetadataName(CakeMethodAliasAttributeFullName);
                var cakePropertyAliasAttributeSymbol = compilation.GetTypeByMetadataName(CakePropertyAliasAttributeFullName);
                var cakeNamespaceImportAttributeSymbol = compilation.GetTypeByMetadataName(CakeNamespaceImportAttributeFullName);
                var iCakeContextSymbol = compilation.GetTypeByMetadataName(ICakeContextFullName);
                var cakeModuleAttributeSymbol = compilation.GetTypeByMetadataName(CakeModuleAttributeFullName);
                var iCakeModuleSymbol = compilation.GetTypeByMetadataName(ICakeModuleFullName);
                var obsoleteAttributeSymbol = compilation.GetTypeByMetadataName("System.ObsoleteAttribute");

                if (extensionAttributeSymbol == null ||
                    (cakeMethodAliasAttributeSymbol == null && cakePropertyAliasAttributeSymbol == null) ||
                    iCakeContextSymbol == null)
                {
                    return (compilation, null, null);
                }

                // Scan all referenced assemblies for Cake aliases and modules
                var allMethods = new List<MethodInfo>();
                var allModules = new List<ModuleInfo>();
                foreach (var assembly in compilation.References)
                {
                    if (compilation.GetAssemblyOrModuleSymbol(assembly) is IAssemblySymbol assemblySymbol)
                    {
                        var foundMethods = ScanTypeMembers(assemblySymbol.GlobalNamespace, extensionAttributeSymbol, cakeMethodAliasAttributeSymbol, cakePropertyAliasAttributeSymbol, cakeNamespaceImportAttributeSymbol, iCakeContextSymbol);
                        allMethods.AddRange(foundMethods);

                        // Scan for modules if we have the required symbols
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

        // Generate source files based on the collected methods
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

            // Separate methods and properties
            var (
                methodList,
                methodAliases,
                propertyAliases) = methods.Value.Aggregate(
                (
                    AllMethods: new List<MethodInfo>(),
                    MethodAliases: new List<MethodInfo>(),
                    PropertyAliases: new List<MethodInfo>()),
                (acc, method) =>
                {
                    acc.AllMethods.Add(method);

                    if (method.IsPropertyAlias)
                    {
                        acc.PropertyAliases.Add(method);
                    }
                    else
                    {
                        acc.MethodAliases.Add(method);
                    }
                    return acc;
                });

            // Generate global usings
            var globalUsings = GenerateGlobalUsings(methodList);
            sourceProductionContext.AddSource("CakeAliasGlobalUsings.g.cs", SourceText.From(globalUsings, Encoding.UTF8));

            // Generate script host with compilation for dynamic generation
            var scriptHost = GenerateScriptHost(compilation);
            sourceProductionContext.AddSource("CakeScriptHost.g.cs", SourceText.From(scriptHost, Encoding.UTF8));

            // Generate service provider;
            sourceProductionContext.AddSource("CakeServiceProvider.g.cs", SourceText.From(ServiceProvider, Encoding.UTF8));

            // Generate service provider;
            sourceProductionContext.AddSource("CakeHelper.AddCakeCore.g.cs", SourceText.From(Helper.AddCakeCore, Encoding.UTF8));

            // Generate helper services methods
            sourceProductionContext.AddSource("CakeHelper.AddCakeCli.g.cs", SourceText.From(Helper.AddCakeCli, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.AddCakeGenerator.g.cs", SourceText.From(Helper.AddCakeGenerator, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.AddCakeToolInstaller.g.cs", SourceText.From(Helper.AddCakeToolInstaller, Encoding.UTF8));
            sourceProductionContext.AddSource("CakeHelper.PostBuildServiceProvider.g.cs", SourceText.From(Helper.PostBuildServiceProvider, Encoding.UTF8));

            // Generate cake app settings
            sourceProductionContext.AddSource("CakeCakeAppSettings.g.cs", SourceText.From(CakeAppSettings, Encoding.UTF8));

            // Generate method aliases if any exist
            if (methodAliases.Count > 0)
            {
                var methodAliasesSource = GenerateMethodAliases(methodAliases);
                sourceProductionContext.AddSource("CakeMethodAliases.g.cs", SourceText.From(methodAliasesSource, Encoding.UTF8));
            }

            // Generate property aliases if any exist
            if (propertyAliases.Count > 0)
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