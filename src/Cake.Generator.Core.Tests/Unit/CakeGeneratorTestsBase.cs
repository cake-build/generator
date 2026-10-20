// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator.Core.Tests.Unit;

/// <summary>
/// Base class for Cake Generator tests providing common test infrastructure.
/// </summary>
public static class CakeGeneratorTestsBase
{
    /// <summary>
    /// Gets references to all assemblies in the shared framework the tests run on, so that
    /// types used in alias signatures resolve as they would in a script project.
    /// </summary>
    public static readonly Lazy<ImmutableArray<MetadataReference>> FrameworkReferences = new(() =>
    {
        var frameworkDirectory = Path.GetDirectoryName(typeof(object).Assembly.Location);
        return
        [
            .. ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
                .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries)
                .Where(path => string.Equals(Path.GetDirectoryName(path), frameworkDirectory, StringComparison.OrdinalIgnoreCase))
                .Select(path => MetadataReference.CreateFromFile(path))
        ];
    });

    /// <summary>
    /// Creates a basic compilation with common references needed for Cake source generation.
    /// </summary>
    /// <param name="source">The source code to compile.</param>
    /// <param name="additionalReferences">Additional references to include in the compilation.</param>
    /// <returns>A compilation that can be used for source generator testing.</returns>
    public static Compilation CreateCompilation(string source, params MetadataReference[] additionalReferences)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(source);
        var cakeCoreLocation = typeof(Cake.Core.Annotations.CakeMethodAliasAttribute).Assembly.Location;
        var cakeCommonLocation = typeof(Cake.Common.Diagnostics.LoggingAliases).Assembly.Location;
        var references = new List<MetadataReference>(FrameworkReferences.Value)
        {
            MetadataReference.CreateFromFile(cakeCoreLocation, documentation: XmlDocumentationProvider.CreateFromFile(Path.ChangeExtension(cakeCoreLocation, ".xml"))),
            MetadataReference.CreateFromFile(cakeCommonLocation, documentation: XmlDocumentationProvider.CreateFromFile(Path.ChangeExtension(cakeCommonLocation, ".xml"))),
            MetadataReference.CreateFromFile(typeof(Microsoft.Extensions.DependencyInjection.IServiceCollection).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions).Assembly.Location)
        };

        references.AddRange(additionalReferences);

        return CSharpCompilation.Create(
            assemblyName: "TestAssembly",
            syntaxTrees: [syntaxTree],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
    }

    /// <summary>
    /// Creates a compilation with Cake-specific references.
    /// </summary>
    /// <param name="source">The source code to compile.</param>
    /// <returns>A compilation configured for Cake testing.</returns>
    public static Compilation CreateCakeCompilation(string source)
    {
        return CreateCompilation(source);
    }

    /// <summary>
    /// Returns a metadata reference to the test assembly that contains
    /// <see cref="Fixtures.EscapingAliases"/>. The generator only scans referenced assemblies.
    /// </summary>
    public static MetadataReference CreateEscapingAliasesReference()
        => MetadataReference.CreateFromFile(typeof(Fixtures.EscapingAliases).Assembly.Location);

    /// <summary>
    /// Gets common Cake-related source code for testing.
    /// </summary>
    public static class CommonSources
    {
        /// <summary>
        /// Source code for a simple Cake method alias.
        /// </summary>
        public const string Program = """
                                      public static class Program
                                      {
                                        public static int Main(string[] args)
                                        {
                                        }
                                      }
                                      """;
    }
}
