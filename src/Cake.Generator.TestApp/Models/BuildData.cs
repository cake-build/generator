namespace Cake.Generator.TestApp.Models;

public record BuildData(
    string Version,
    string BranchName,
    bool IsPullRequest,
    bool IsMainBranch,
    bool IsDevelopmentBranch,
    bool IsFork,
    bool IsRunningOnGitHubActions,
    bool IsRunningOnWindows,
    bool IsTagged,
    DirectoryPath ArtifactsDirectory,
    FilePath SolutionPath,
    DotNetMSBuildSettings MSBuildSettings,
    NuGetPublishSettings NuGetPublishSettings,
    CodeSigningCredentials CodeSigningCredentials)
    : IToolSettings
{
    public bool ShouldPushNuGet { get; } = IsRunningOnGitHubActions
                                            && IsRunningOnWindows
                                            && !IsPullRequest
                                            && !IsFork
                                            && (IsMainBranch || IsDevelopmentBranch || IsTagged);
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

    private bool? shouldSignPackages;
    public bool ShouldSignPackages => shouldSignPackages ??=
                                        ShouldPushNuGet
                                        &&
                                        IsTagged;
}