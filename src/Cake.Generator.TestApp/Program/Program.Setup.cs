public static partial class Program
{
    private static BuildData SetupTask(ICakeContext context)
    {
        InstallTools(
            "dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=5.12.0",
            "dotnet:https://api.nuget.org/v3/index.json?package=GitReleaseManager.Tool&version=0.20.0",
            "dotnet:https://api.nuget.org/v3/index.json?package=sign&version=0.9.1-beta.25330.2&prerelease");

        var buildDate = DateTime.UtcNow;
        var baseVersion = typeof(ICakeContext).Assembly.GetName().Version?.ToString(2) ?? "1.0";

        var branchName = GitVersion(new GitVersionSettings { }).BranchName;
        var isMain = StringComparer.OrdinalIgnoreCase.Equals("main", branchName);
        var isDevelopment = StringComparer.OrdinalIgnoreCase.Equals("develop", branchName);
        var isPullRequest = GitHubActions.IsRunningOnGitHubActions && GitHubActions.Environment.PullRequest.IsPullRequest;
        var isFork = GitHubActions.IsRunningOnGitHubActions && !StringComparer.OrdinalIgnoreCase.Equals("cake-build", GitHubActions.Environment.Workflow.RepositoryOwner);
        var isTagged = GitHubActions.IsRunningOnGitHubActions && GitHubActions.Environment.Workflow.RefType == GitHubActionsRefType.Tag;

        var runNumber = GitHubActions.IsRunningOnGitHubActions
                    ? GitHubActions.Environment.Workflow.RunNumber
                    : (short)((buildDate - buildDate.Date).TotalSeconds / 3);

        var suffix = GitHubActions.IsRunningOnGitHubActions
                    ? (isMain ? string.Empty : "alpha")
                    : "local";

        var version = isTagged
                        ? (SemVersion.TryParse(GitHubActions.Environment.Workflow.RefName.TrimStart('v'), out var semVersion)
                            ? semVersion.VersionString
                            : throw new CakeException($"Failed to parse tagged ref name: {GitHubActions.Environment.Workflow.RefName}"))
                        : FormattableString
                                    .Invariant($"{baseVersion}.{buildDate:yy}{buildDate.DayOfYear:000}.{runNumber}-{suffix}")
                                    .TrimEnd('-');

        var sdkVersion = ReadSdkVersionFromGlobalJson();

        Information(
            "Branch: {0} (Main: {1}, Development: {2}, Pull Request: {3}, Fork: {4}), Version: {5} (SDK: {6})",
            branchName,
            isMain,
            isDevelopment,
            isPullRequest,
            isFork,
            version,
            sdkVersion);

        var msBuildSettings = new DotNetMSBuildSettings()
                .SetConfiguration("IntegrationTest")
                .SetVersion(version)
                .WithProperty("WarningAsError", "true")
                .WithProperty("NoWarn", "NU5104;NU5128;NETSDK1057")
                .WithProperty("SdkVersion", sdkVersion);

        if (GitHubActions.IsRunningOnGitHubActions)
        {
            msBuildSettings.WithProperty("TemplateVersion", version);
        }

        var buildData = new BuildData(
            Version: version,
            BranchName: branchName,
            IsPullRequest: isPullRequest,
            IsMainBranch: isMain,
            IsDevelopmentBranch: isDevelopment,
            IsFork: isFork,
            IsTagged: isTagged,
            IsRunningOnGitHubActions: GitHubActions.IsRunningOnGitHubActions,
            IsRunningOnWindows: IsRunningOnWindows(),
            ArtifactsDirectory: MakeAbsolute(Directory("artifacts")),
            SolutionPath: GetFiles("./src/Cake.Generator.slnx").FirstOrDefault() ?? throw new CakeException("Failed to find solution"),
            MSBuildSettings: msBuildSettings,
            NuGetPublishSettings: new NuGetPublishSettings(
                                    isMain,
                                    isTagged,
                                    Context.Environment),
            CodeSigningCredentials: CodeSigningCredentials.GetCodeSigningCredentials(context));

        if (buildData.ShouldSignPackages)
        {
            Information("Code signing is enabled for this build.");
            if (!buildData.CodeSigningCredentials.HasCredentials)
            {
                throw new CakeException("Code signing credentials are not set. Please set the environment variables for code signing.");
            }
        }
        else
        {
            Information("Code signing is disabled for this build.");
        }

        return buildData;
    }

    private static string ReadSdkVersionFromGlobalJson()
    {
        FilePath globalJsonPath = "./global.json";
        if (!FileExists(globalJsonPath))
        {
            throw new CakeException($"global.json file not found at {globalJsonPath}");
        }

        using var globalJsonContentStream = Context.FileSystem.GetFile(globalJsonPath).OpenRead();

        try
        {
            using var document = JsonDocument.Parse(globalJsonContentStream);
            var root = document.RootElement;

            if (root.TryGetProperty("sdk", out var sdkElement) &&
                sdkElement.TryGetProperty("version", out var versionElement))
            {
                return versionElement.GetString() ?? throw new CakeException("SDK version is null in global.json");
            }

            throw new CakeException("Failed to find SDK version in global.json");
        }
        catch (JsonException ex)
        {
            throw new CakeException($"Failed to parse global.json: {ex.Message}");
        }
    }
}
