namespace Cake.Generator.TestApp.Models;

#pragma warning disable SA1011 // Closing square brackets should be spaced correctly
#pragma warning disable SA1313 // Parameter names should begin with lower-case letter
public record IntegrationTestData(
    string Version,
    DirectoryPath BaseDirectory)
{
    public FilePath GlobalJson { get; } = BaseDirectory.CombineWithFilePath("global.json");
    public FilePath NuGetConfig { get; } = BaseDirectory.CombineWithFilePath("nuget.config");
    public FilePath CakeCs { get; } = BaseDirectory.CombineWithFilePath("cake.cs");
    public FilePath CakeSdkCs { get; } = BaseDirectory.CombineWithFilePath("cake.sdk.cs");

    public DirectoryPath CakeSdkProject { get; } = BaseDirectory.Combine("cake.sdk");
    public FilePath CakeSdkProjectCsproj { get; } = BaseDirectory.Combine("cake.sdk").CombineWithFilePath("cake.csproj");
    public FilePath CakeSdkProjectProgramCs { get; } = BaseDirectory.Combine("cake.sdk").CombineWithFilePath("Program.cs");

    public DirectoryPath CakeSdkCpmProject { get; } = BaseDirectory.Combine("cake.cpm");
    public FilePath CakeSdkCpmPackagesProps { get; } = BaseDirectory.Combine("cake.cpm").CombineWithFilePath("Directory.Packages.props");
    public FilePath CakeSdkCpmProjectCsproj { get; } = BaseDirectory.Combine("cake.cpm").CombineWithFilePath("cake.csproj");
    public FilePath CakeSdkCpmProjectProgramCs { get; } = BaseDirectory.Combine("cake.cpm").CombineWithFilePath("Program.cs");

    public DirectoryPath CakeTemplate { get; } = BaseDirectory.Combine("cake.template");
    public FilePath CakeTemplateBuildCs { get; } = BaseDirectory.Combine("cake.template").CombineWithFilePath("cake.cs");
    public DirectoryPath CakeTemplateBuild { get; } = BaseDirectory.Combine("cake.template").Combine("cake");
    public FilePath CakeTemplateBuildCsproj { get; } = BaseDirectory.Combine("cake.template").Combine("cake").CombineWithFilePath("cake.csproj");
    public DirectoryPath CakeTemplateSrc { get; } = BaseDirectory.Combine("cake.template").Combine("src");
    public FilePath CakeTemplateBuildMultiCs { get; } = BaseDirectory.Combine("cake.template").CombineWithFilePath("cakemultifile.cs");

    // New multi-file test properties
    public FilePath CakeSdkFilesCs { get; } = BaseDirectory.CombineWithFilePath("cake.sdk.files.cs");
    public DirectoryPath CakeSdkFilesFolder { get; } = BaseDirectory.Combine("cake.sdk.files");
    public FilePath CakeSdkFilesModelsCs { get; } = BaseDirectory.Combine("cake.sdk.files").CombineWithFilePath("Models.cs");
    public FilePath CakeSdkFilesUtilitiesCs { get; } = BaseDirectory.Combine("cake.sdk.files").CombineWithFilePath("Utilities.cs");
    public FilePath CakeSdkFilesExcludedCs { get; } = BaseDirectory.Combine("cake.sdk.files").CombineWithFilePath("Excluded.cs");

    public FilePath[] TestFiles =>
        [
            CakeCs,
            CakeSdkCs,
            CakeSdkProjectCsproj,
            CakeSdkCpmProjectCsproj,
            CakeTemplateBuildCs,
            CakeTemplateBuildCsproj,
            CakeTemplateBuildMultiCs,
            CakeSdkFilesCs
        ];

    public string BaseCode =>
            $$"""
            using Xunit;

            Setup(static context => new BuildData(
                ExpectedVersion: "{{Version}}",
                Version: context.Argument("integration-test-version", "Missing")
            ));

            Task("Install-Tool")
                .Does(() =>
                    {
                        InstallTools(
                           "dotnet:https://api.nuget.org/v3/index.json?package=DPI&version=2025.6.11.198",
                           "dotnet:https://api.nuget.org/v3/index.json?package=DPI&version=2025.6.11.205");

                        Command(
                            [
                                "dpi",
                                "dpi.exe"
                            ],
                            out var standardOutput,
                            "--version");

                        Assert.Equal("2025.6.11.205+f9d70966eb517e4cc0e0177aecfa1416e6374998", standardOutput);
                    });

            Task("Assert-Version")
                .IsDependentOn("Install-Tool")
                .Does<BuildData>((ctx, data) =>
                    {
                        Information("Expected: {0}", data.ExpectedVersion);
                        Information("Version: {0}", data.Version);
                        Information("CakeGeneratorNuGetVersion: {0}", CakeGeneratorNuGetVersion);
                        Assert.Equal(data.ExpectedVersion, data.Version);
                        Assert.Equal(data.ExpectedVersion, CakeGeneratorNuGetVersion);
                    });

            await RunTargetAsync("Assert-Version");

            public record BuildData(string ExpectedVersion, string Version);
            """;

    public string XunitAssertPackage => "xunit.v3.assert@2";

    public string CakeCsCode =>
        $$"""
        #:package Cake.Generator@{{Version}}
        #:package {{XunitAssertPackage}}
        {{BaseCode}}
        """;

    public string CakeSdkCsCode =>
        $$"""
        #:sdk Cake.Sdk
        #:package {{XunitAssertPackage}}
        {{BaseCode}}
        """;

    public string CakeSdkProjectCsprojCode =>
        $$"""
        <Project Sdk="Cake.Sdk">
            <PropertyGroup>
                <TargetFramework>net10.0</TargetFramework>
            </PropertyGroup>
        </Project>
        """;

    public string CakeSdkCpmPackagesPropsCode =>
        $$"""
        <Project>
            <PropertyGroup>
                <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
                <CentralPackageTransitivePinningEnabled>true</CentralPackageTransitivePinningEnabled>
            </PropertyGroup>
            <ItemGroup>
            </ItemGroup>
        </Project>
        """;

    public string CakeSdkFilesCsCode =>
        $$"""
        #:sdk Cake.Sdk
        #:property IncludeAdditionalFiles=cake.sdk.files/**/*.cs
        #:property ExcludeAdditionalFiles=cake.sdk.files/**/Excluded.cs
        #:package {{XunitAssertPackage}}

        using Xunit;
        using System.Linq;
        using System.Reflection;

        Setup(static context => new MultiFileBuildData(
            ExpectedVersion: "{{Version}}",
            Version: context.Argument("integration-test-version", "Missing")
        ));

        Task("Test-MultiFile")
            .Does<MultiFileBuildData>((ctx, data) =>
                {
                    Information("Expected: {0}", data.ExpectedVersion);
                    Information("Version: {0}", data.Version);
                    Information("CakeGeneratorNuGetVersion: {0}", CakeGeneratorNuGetVersion);
                    
                    // Test that the BuildConfiguration class is available (from Models.cs)
                    var config = new BuildConfiguration 
                    { 
                        ProjectName = "MultiFileTest",
                        Version = data.Version 
                    };
                    
                    // Test that the utility method is available (from Utilities.cs)
                    LogInfo($"Testing {config.ProjectName} v{config.Version}");
                    
                    // Verify version assertions
                    Assert.Equal(data.ExpectedVersion, data.Version);
                    Assert.Equal(data.ExpectedVersion, CakeGeneratorNuGetVersion);
                    
                    // Verify that the excluded class is not available using reflection
                    var assembly = typeof(BuildConfiguration).Assembly;
                    var typeExists = assembly.GetTypes().Any(t => t.Name == "ExcludedClass");

                    Assert.False(typeExists, "The type 'ExcludedClass' should not exist in the assembly.");
                });

        await RunTargetAsync("Test-MultiFile");

        public record MultiFileBuildData(string ExpectedVersion, string Version);
        """;

    public string CakeSdkFilesModelsCsCode =>
        """
        public class BuildConfiguration
        {
            public string ProjectName { get; set; } = "";
            public string Version { get; set; } = "";
        }
        """;

    public string CakeSdkFilesUtilitiesCsCode =>
        """
        public static partial class Program
        {
            public static void LogInfo(string message)
            {
                Information($"INFO: {message}");
            }
        }
        """;

    public string CakeSdkFilesExcludedCsCode =>
        """
        // This class should not be compiled due to ExcludeAdditionalFiles pattern
        public class ExcludedClass
        {
            public string Message { get; set; } = "This should not be available";
        }
        """;
}