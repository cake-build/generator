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
    public FilePath CakeTemplateBuildCs { get; } = BaseDirectory.Combine("cake.template").CombineWithFilePath("build.cs");
    public DirectoryPath CakeTemplateBuild { get; } = BaseDirectory.Combine("cake.template").Combine("build");
    public FilePath CakeTemplateBuildCsproj { get; } = BaseDirectory.Combine("cake.template").Combine("build").CombineWithFilePath("build.csproj");
    public DirectoryPath CakeTemplateSrc { get; } = BaseDirectory.Combine("cake.template").Combine("src");

    public FilePath[] TestFiles =>
        [
            CakeCs,
            CakeSdkCs,
            CakeSdkProjectCsproj,
            CakeSdkCpmProjectCsproj,
            CakeTemplateBuildCs,
            CakeTemplateBuildCsproj
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
}