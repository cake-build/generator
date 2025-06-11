namespace Cake.Generator.TestApp.Models;

#pragma warning disable SA1011 // Closing square brackets should be spaced correctly
#pragma warning disable SA1313 // Parameter names should begin with lower-case letter
public record BuildData(
    string Version,
    DirectoryPath ArtifactsDirectory,
    FilePath SolutionPath,
    DotNetMSBuildSettings MSBuildSettings)
    : IToolSettings
{
    public DirectoryPath OutputDirectory { get; } = ArtifactsDirectory.Combine(Version);
    public DirectoryPath IntegrationTestDirectory { get; } = ArtifactsDirectory.Combine(Version).Combine("IntegrationTest");

    private DirectoryPath[]? _pathsToClean;
    public DirectoryPath[] PathsToClean => _pathsToClean ??=
        [
            ArtifactsDirectory,
            OutputDirectory,
            IntegrationTestDirectory,
            IntegrationTest.CakeTemplate,
            IntegrationTest.CakeTemplateSrc
        ];

    private IntegrationTestData? _integrationTest;
    public IntegrationTestData IntegrationTest => _integrationTest
                                                    ??=
                                                    new IntegrationTestData(
                                                        Version,
                                                        IntegrationTestDirectory);

    // IToolSettings interface implementation
    public DirectoryPath WorkingDirectory { get; init; } = ArtifactsDirectory.Combine(Version).Combine("IntegrationTest");
    DirectoryPath IToolSettings.ArtifactDirectory => OutputDirectory;
}
