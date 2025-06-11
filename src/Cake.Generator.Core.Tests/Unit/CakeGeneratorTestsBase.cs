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
        var references = new List<MetadataReference>
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(System.Runtime.AssemblyTargetedPatchBandAttribute).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Component).Assembly.Location),
            MetadataReference.CreateFromFile(cakeCoreLocation, documentation: XmlDocumentationProvider.CreateFromFile(Path.ChangeExtension(cakeCoreLocation, ".xml"))),
            MetadataReference.CreateFromFile(cakeCommonLocation, documentation: XmlDocumentationProvider.CreateFromFile(Path.ChangeExtension(cakeCommonLocation, ".xml")))
        };

        references.AddRange(additionalReferences);

#pragma warning disable SA1010 // Opening square brackets should be spaced correctly
        return CSharpCompilation.Create(
            assemblyName: "TestAssembly",
            syntaxTrees: [syntaxTree],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
#pragma warning restore SA1010 // Opening square brackets should be spaced correctly
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
