// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Cake.Generator.Core.Tests.Unit;
/// <summary>
/// Tests for the main <see cref="CakeGenerator"/> functionality.
/// </summary>
public sealed class CakeGeneratorTests
{
    [Test]
    public async Task RunGenerators(CancellationToken cancellationToken)
    {
        // Given
        var source = CakeGeneratorTestsBase.CommonSources.Program;
        var compilation = CakeGeneratorTestsBase.CreateCakeCompilation(source);
        // When
        var driver = CSharpGeneratorDriver.Create(new CakeGenerator());
        var result = driver.RunGenerators(compilation, cancellationToken);
        // Then
        await Verify(result.GetRunResult());
    }

    [Test]
    public async Task RunGenerators_WithModules(CancellationToken cancellationToken)
    {
        // Given
        var source = CakeGeneratorTestsBase.CommonSources.Program;
        // Add the BuildSystems.Module assembly reference to test module detection
        var buildSystemsModuleLocation = typeof(GitHubActions.Module.GitHubActionsModule).Assembly.Location;
        var nuGetModuleLocation = typeof(NuGet.NuGetModule).Assembly.Location;
        var dotnetToolModuleLocation = typeof(DotNetTool.Module.DotNetToolModule).Assembly.Location;
        var moduleReferences = new[]
        {
            MetadataReference.CreateFromFile(buildSystemsModuleLocation),
            MetadataReference.CreateFromFile(nuGetModuleLocation),
            MetadataReference.CreateFromFile(dotnetToolModuleLocation)
        };
        var compilation = CakeGeneratorTestsBase.CreateCompilation(source, moduleReferences);
        // When
        var driver = CSharpGeneratorDriver.Create(new CakeGenerator());
        var result = driver.RunGenerators(compilation, cancellationToken);
        // Then
        await Verify(result.GetRunResult());
    }

    [Test]
    public async Task RunGenerators_WithMainMethods_GeneratesMainMethodCalls(CancellationToken cancellationToken)
    {
        // Given
        var source = """
        using System;
        using Cake.Core.Scripting;

        public static partial class Program
        {
            private static void Main_Initialize()
            {
                // Initialization logic
            }

            private static void Main_Setup()
            {
                // Setup logic
            }

            private static void NotMain()
            {
                // Should not be picked up
            }
        }
        """;
        var compilation = CakeGeneratorTestsBase.CreateCakeCompilation(source);
        // When
        var driver = CSharpGeneratorDriver.Create(new CakeGenerator());
        var result = driver.RunGenerators(compilation, cancellationToken);
        // Then
        var runResult = result.GetRunResult();
        var generatedCode = string.Join("\n", runResult.Results.SelectMany(r => r.GeneratedSources).Select(s => s.SourceText.ToString()));
        await Verify(runResult);
    }

    [Test]
    public async Task RunGenerators_WithDockerAddin(CancellationToken cancellationToken)
    {
        // Given
        var source = CakeGeneratorTestsBase.CommonSources.Program;
        var dockerLocation = typeof(DockerAliases).Assembly.Location;
        var dockerReference = MetadataReference.CreateFromFile(
            dockerLocation,
            documentation: XmlDocumentationProvider.CreateFromFile(Path.ChangeExtension(dockerLocation, ".xml")));
        var compilation = CakeGeneratorTestsBase.CreateCompilation(source, dockerReference);
        // When
        var driver = CSharpGeneratorDriver.Create(new CakeGenerator());
        var result = driver.RunGenerators(compilation, cancellationToken);
        // Then
        await Verify(result.GetRunResult());
    }
}