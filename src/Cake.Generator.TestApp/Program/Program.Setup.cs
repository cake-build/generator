public static partial class Program
{
    private static BuildData SetupTask(ICakeContext context)
    {
        InstallTools(
            "dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=6.6.0",
            "dotnet:https://api.nuget.org/v3/index.json?package=GitReleaseManager.Tool&version=0.20.0");

        if (IsRunningOnWindows())
        {
            // Sign tool is only available on Windows.
            InstallTools(
                "dotnet:https://api.nuget.org/v3/index.json?package=sign&version=0.9.1-beta.26102.1&prerelease");
        }

        var buildDate = DateTime.UtcNow;
        var baseVersion = typeof(ICakeContext).Assembly.GetName().Version?.ToString(3) ?? "1.0.0";

        var assertedVersions = GitVersion(new GitVersionSettings
        {
            OutputType = GitVersionOutput.Json
        });
        var branchName = assertedVersions.BranchName;
        var isMain = StringComparer.OrdinalIgnoreCase.Equals("main", branchName);
        var isDevelopment = StringComparer.OrdinalIgnoreCase.Equals("develop", branchName);
        var isPullRequest = GitHubActions.IsRunningOnGitHubActions && GitHubActions.Environment.PullRequest.IsPullRequest;
        var isFork = GitHubActions.IsRunningOnGitHubActions && !StringComparer.OrdinalIgnoreCase.Equals("cake-build", GitHubActions.Environment.Workflow.RepositoryOwner);
        var isTagged = GitHubActions.IsRunningOnGitHubActions && GitHubActions.Environment.Workflow.RefType == GitHubActionsRefType.Tag;

        var suffix = GitHubActions.IsRunningOnGitHubActions
                    ? (isMain ? string.Empty : "alpha")
                    : "local";

        var version = isTagged
                        ? (SemVersion.TryParse(GitHubActions.Environment.Workflow.RefName.TrimStart('v'), out var semVersion)
                            ? semVersion.VersionString
                            : throw new CakeException($"Failed to parse tagged ref name: {GitHubActions.Environment.Workflow.RefName}"))
                        : FormattableString
                                    .Invariant($"{baseVersion}-{suffix}{assertedVersions.PreReleaseNumber:D4}")
                                    .TrimEnd('-');

        var sdkVersion = ReadSdkVersionFromGlobalJson();

        var msBuildSettings = new DotNetMSBuildSettings()
                .SetConfiguration("IntegrationTest")
                .SetVersion(version)
                .WithProperty("TreatWarningsAsErrors", "true")
                .WithProperty("NoWarn", "NU5104;NU5128;NETSDK1057")
                .WithProperty("SdkVersion", sdkVersion);

        if (GitHubActions.IsRunningOnGitHubActions)
        {
            msBuildSettings.WithProperty("TemplateVersion", version);
        }
        bool? shouldSignPackages = null;
        try
        {
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

            shouldSignPackages = buildData.ShouldSignPackages;

            if (buildData.ShouldSignPackages)
            {
                Information("Code signing is enabled for this build.");
                if (!buildData.CodeSigningCredentials.HasCredentials)
                {
                    throw new CakeException("Code signing credentials are not set. Please set the environment variables for code signing.");
                }
            }

            return buildData;
        }
        finally
        {
            // Returns Spectre.Console markup for a boolean (green ✓ or red ✗).
            static string ToCheckmark(bool? value) => value.HasValue ? (value.Value ? "[green]✓[/]" : "[red]✗[/]") : "[yellow]?[/]";

            AnsiConsole.Write(
                new Table()
                    .RoundedBorder()
                    .HideHeaders()
                    .ShowRowSeparators()
                    .AddColumn("Property")
                    .AddColumn("Value")
                    .AddRow("Build Date", buildDate.ToString("yyyy-MM-dd HH:mm:ss UTC"))
                    .AddRow("Build System", BuildSystem.Provider.ToString("F"))
                    .AddRow("Branch", branchName)
                    .AddRow("Main", ToCheckmark(isMain))
                    .AddRow("Development", ToCheckmark(isDevelopment))
                    .AddRow("Pull Request", ToCheckmark(isPullRequest))
                    .AddRow("Fork", ToCheckmark(isFork))
                    .AddRow("Tagged", ToCheckmark(isTagged))
                    .AddRow("Version", version)
                    .AddRow("SDK", sdkVersion)
                    .AddRow("Should Sign Packages", ToCheckmark(shouldSignPackages)));
        }
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
