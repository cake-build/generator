// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator.Core.Tests.Unit;

/// <summary>
/// Builds fake addin assemblies in memory and compiles generator output against them,
/// so addin compatibility can be tested without referencing real addin packages.
/// </summary>
public static class AddinCompilation
{
    private const string MethodAliasesHintName = "CakeMethodAliases.g.cs";
    private const string GlobalUsingsHintName = "CakeAliasGlobalUsings.g.cs";
    private const string PropertyAliasesHintName = "CakePropertyAliases.g.cs";
    private const string ScriptFileName = "Script.cs";

    private static readonly Lazy<ImmutableArray<MetadataReference>> BaseReferences = new(CreateBaseReferences);

    /// <summary>
    /// Compiles <paramref name="source"/> into an in-memory assembly named <paramref name="assemblyName"/>.
    /// </summary>
    /// <param name="assemblyName">The assembly name, which may contain characters that are invalid in identifiers.</param>
    /// <param name="source">The addin source code.</param>
    /// <param name="additionalReferences">Additional references the addin is compiled against.</param>
    /// <returns>A metadata reference to the compiled addin.</returns>
    public static MetadataReference CreateReference(string assemblyName, string source, params MetadataReference[] additionalReferences)
    {
        var compilation = CSharpCompilation.Create(
            assemblyName,
            [CSharpSyntaxTree.ParseText(source)],
            [.. BaseReferences.Value, .. additionalReferences],
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Enable));

        using var stream = new MemoryStream();
        var emitResult = compilation.Emit(stream);
        if (!emitResult.Success)
        {
            throw new InvalidOperationException(
                $"Failed to compile fake addin {assemblyName}:{Environment.NewLine}{string.Join(Environment.NewLine, emitResult.Diagnostics)}");
        }

        return MetadataReference.CreateFromImage(stream.ToArray());
    }

    /// <summary>
    /// Creates a script-like compilation referencing the given addins, runs the generator and
    /// returns the outcome.
    /// </summary>
    /// <param name="addinReferences">The addin references.</param>
    /// <returns>The generator outcome.</returns>
    public static GeneratorOutcome Run(params MetadataReference[] addinReferences)
        => RunScript(string.Empty, addinReferences);

    /// <summary>
    /// Creates a script-like compilation with <paramref name="scriptSource"/> referencing the given addins,
    /// runs the generator and returns the outcome, including compile errors in the script source.
    /// </summary>
    /// <param name="scriptSource">The script source using the generated aliases.</param>
    /// <param name="addinReferences">The addin references.</param>
    /// <returns>The generator outcome.</returns>
    public static GeneratorOutcome RunScript(string scriptSource, params MetadataReference[] addinReferences)
    {
        SyntaxTree[] syntaxTrees = string.IsNullOrEmpty(scriptSource)
            ? [CSharpSyntaxTree.ParseText("public static partial class Program { }")]
            : [CSharpSyntaxTree.ParseText("public static partial class Program { }"), CSharpSyntaxTree.ParseText(scriptSource, path: ScriptFileName)];

        var compilation = CSharpCompilation.Create(
            "Script",
            syntaxTrees,
            [.. BaseReferences.Value, .. addinReferences],
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Enable));

        CSharpGeneratorDriver.Create(new CakeGenerator())
            .RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generatorDiagnostics);

        var trees = outputCompilation.SyntaxTrees.ToDictionary(tree => Path.GetFileName(tree.FilePath), tree => tree);
        var errors = outputCompilation.GetDiagnostics()
            .Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error
                && diagnostic.Location.SourceTree is { } tree
                && Path.GetFileName(tree.FilePath) is MethodAliasesHintName or GlobalUsingsHintName or PropertyAliasesHintName or ScriptFileName)
            .Select(diagnostic => diagnostic.ToString())
            .ToImmutableArray();

        return new GeneratorOutcome(
            errors,
            generatorDiagnostics,
            GetSource(trees, MethodAliasesHintName),
            GetSource(trees, GlobalUsingsHintName),
            GetSource(trees, PropertyAliasesHintName));
    }

    private static string GetSource(Dictionary<string, SyntaxTree> trees, string hintName)
        => trees.TryGetValue(hintName, out var tree) ? tree.ToString() : string.Empty;

    private static ImmutableArray<MetadataReference> CreateBaseReferences()
    {
        Type[] cakeTypes =
        [
            typeof(Cake.Core.ICakeContext),
            typeof(Cake.Common.Diagnostics.LoggingAliases),
            typeof(Cake.Cli.IVersionResolver),
            typeof(Spectre.Console.AnsiConsole),
            typeof(Spectre.Console.Cli.CommandSettings),
            typeof(Microsoft.Extensions.DependencyInjection.IServiceCollection),
            typeof(Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions)
        ];

        return
        [
            .. CakeGeneratorTestsBase.FrameworkReferences.Value,
            .. cakeTypes
                .Select(type => type.Assembly.Location)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .Select(path => MetadataReference.CreateFromFile(path))
        ];
    }

    /// <summary>
    /// The result of running the generator against a script compilation.
    /// </summary>
    /// <param name="Errors">Compile errors located in the generated alias and global using sources.</param>
    /// <param name="GeneratorDiagnostics">Diagnostics reported by the generator itself.</param>
    /// <param name="MethodAliases">The generated method alias source.</param>
    /// <param name="GlobalUsings">The generated global usings source.</param>
    /// <param name="PropertyAliases">The generated property alias source.</param>
    public sealed record GeneratorOutcome(
        ImmutableArray<string> Errors,
        ImmutableArray<Diagnostic> GeneratorDiagnostics,
        string MethodAliases,
        string GlobalUsings,
        string PropertyAliases)
    {
        /// <summary>
        /// Gets the generated nested class for an addin assembly from the method alias source.
        /// </summary>
        /// <param name="className">The generated class name.</param>
        /// <returns>The class source, or an empty string when not generated.</returns>
        public string GetAliasClass(string className) => GetClass(MethodAliases, className);

        /// <summary>
        /// Gets the generated nested class for an addin assembly from the property alias source.
        /// </summary>
        /// <param name="className">The generated class name.</param>
        /// <returns>The class source, or an empty string when not generated.</returns>
        public string GetPropertyAliasClass(string className) => GetClass(PropertyAliases, className);

        private static string GetClass(string source, string className)
        {
            var start = source.IndexOf($"    public static partial class {className}", StringComparison.Ordinal);
            if (start < 0)
            {
                return string.Empty;
            }

            var end = source.IndexOf("\n    }", start, StringComparison.Ordinal);
            return source.Substring(start, end - start + "\n    }".Length).ReplaceLineEndings("\n");
        }
    }
}
