var targets = Arguments(
                "target",
                [
                    "Default"
                ]);

Setup(
    Verbosity.Diagnostic,
    context =>
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

        Information(
            "Branch: {0} (Main: {1}, Development: {2}, Pull Request: {3}, Fork: {4}), Version: {5}",
            branchName,
            isMain,
            isDevelopment,
            isPullRequest,
            isFork,
            version);

        var msBuildSettings = new DotNetMSBuildSettings()
                .SetConfiguration("IntegrationTest")
                .SetVersion(version)
                .WithProperty("WarningAsError", "true")
                .WithProperty("NoWarn", "NU5104;NU5128;NETSDK1057");

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
    });

Task("Clean")
    .Does<BuildData>((ctx, data) =>
    {
       CleanDirectories(data.PathsToClean);
    });

Task("Restore")
    .IsDependentOn("Clean")
    .Does<BuildData>((ctx, data) => DotNetRestore(
        data.SolutionPath.FullPath,
        new DotNetRestoreSettings
        {
            MSBuildSettings = data.MSBuildSettings,
            NoCache = true
        }));

Task("Build")
    .IsDependentOn("Restore")
    .Does<BuildData>((ctx, data) => DotNetBuild(
        data.SolutionPath.FullPath,
        new DotNetBuildSettings
        {
            MSBuildSettings = data.MSBuildSettings,
            NoRestore = true,
        }));

Task("Test")
    .Does<BuildData>((ctx, data) => DotNetTest(
        data.SolutionPath.FullPath,
        new DotNetTestSettings
        {
            MSBuildSettings = data.MSBuildSettings,
            NoBuild = true,
            NoRestore = true,
        }))
    .IsDependentOn("Build");

Task("Pack")
    .IsDependentOn("Test")
    .Does<BuildData>((ctx, data) => DotNetPack(
        data.SolutionPath.FullPath,
        new DotNetPackSettings
        {
            MSBuildSettings = data.MSBuildSettings,
            NoBuild = true,
            NoRestore = true,
            OutputDirectory = data.OutputDirectory
        }));

Task("UploadArtifact")
    .IsDependentOn("Pack")
    .IsDependentOn("Sign-Binaries")
    .WithCriteria(GitHubActions.IsRunningOnGitHubActions, nameof(GitHubActions.IsRunningOnGitHubActions))
    .Does<BuildData>((ctx, data) => GitHubActions.Commands.UploadArtifact(
        data.OutputDirectory,
        $"Cake.Generator-{Context.Environment.Platform.Family}"));

Task("IntegrationTest-Setup")
    .IsDependentOn("Pack")
    .Does<BuildData>(
        Verbosity.Diagnostic,
        async (ctx, data) =>
        {
            data.DotNet("new globaljson");

            Information("Adding Cake.Sdk to global.json msbuild-sdks");
            using (var globalJsonStream = Context.FileSystem.GetFile(data.IntegrationTest.GlobalJson).Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                var currentConfig = await JsonSerializer.DeserializeAsync<ConcurrentDictionary<string, Dictionary<string, string>>>(globalJsonStream);
                ArgumentNullException.ThrowIfNull(currentConfig);

                currentConfig.AddOrUpdate(
                    "msbuild-sdks",
                    add => new()
                        {
                            { "Cake.Sdk", data.Version }
                        },
                    (key, update) =>
                        {
                            update["Cake.Sdk"] = data.Version;
                            return update;
                        });

                globalJsonStream.Position = 0;

                await JsonSerializer.SerializeAsync(
                    globalJsonStream,
                    currentConfig,
                    options: new()
                    {
                        WriteIndented = true,
                    });
            }

            data.DotNet("new nugetconfig");

            data.DotNet($"nuget add source --name local \"{data.OutputDirectory.FullPath.Replace('/', System.IO.Path.DirectorySeparatorChar)}\"");
        });

Task("IntegrationTest-PrepareAppCs")
    .IsDependentOn("IntegrationTest-Setup")
    .Does<BuildData>((ctx, data) =>
    {
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeCs.FullPath,
            data.IntegrationTest.CakeCsCode);

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkCs.FullPath,
            data.IntegrationTest.CakeSdkCsCode);
    });

Task("IntegrationTest-PrepareMultiFile")
    .IsDependentOn("IntegrationTest-PrepareAppCs")
    .Does<BuildData>((ctx, data) =>
    {
        // Create the cake.sdk.files directory
        CreateDirectory(data.IntegrationTest.CakeSdkFilesFolder);

        // Write the main cake.sdk.files.cs file
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesCs.FullPath,
            data.IntegrationTest.CakeSdkFilesCsCode);

        // Write the Models.cs file
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesModelsCs.FullPath,
            data.IntegrationTest.CakeSdkFilesModelsCsCode);

        // Write the Utilities.cs file
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesUtilitiesCs.FullPath,
            data.IntegrationTest.CakeSdkFilesUtilitiesCsCode);

        // Write the Excluded.cs file (this should not be compiled)
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesExcludedCs.FullPath,
            data.IntegrationTest.CakeSdkFilesExcludedCsCode);
    });

Task("IntegrationTest-PrepareProjects")
    .IsDependentOn("IntegrationTest-PrepareMultiFile")
    .Does<BuildData>(
        Verbosity.Diagnostic,
        (ctx, data) =>
        {
            CleanDirectory(data.IntegrationTest.CakeSdkProject);

            System.IO.File.WriteAllText(
                data.IntegrationTest.CakeSdkProjectCsproj.FullPath,
                data.IntegrationTest.CakeSdkProjectCsprojCode);

            System.IO.File.WriteAllText(
                data.IntegrationTest.CakeSdkProjectProgramCs.FullPath,
                data.IntegrationTest.BaseCode);

            if (DirectoryExists(data.IntegrationTest.CakeSdkCpmProject))
            {
                DeleteDirectory(
                    data.IntegrationTest.CakeSdkCpmProject,
                    new DeleteDirectorySettings { Recursive = true });
            }

            CopyDirectory(
                data.IntegrationTest.CakeSdkProject,
                data.IntegrationTest.CakeSdkCpmProject);

            System.IO.File.WriteAllText(
                data.IntegrationTest.CakeSdkCpmPackagesProps.FullPath,
                data.IntegrationTest.CakeSdkCpmPackagesPropsCode);

            data.DotNet($"restore --verbosity minimal {data.IntegrationTest.CakeSdkProjectCsproj}");

            data.DotNet($"restore --verbosity minimal {data.IntegrationTest.CakeSdkCpmProjectCsproj}");

            data.DotNet($"add package {data.IntegrationTest.XunitAssertPackage} --project {data.IntegrationTest.CakeSdkProjectCsproj}");

            data.DotNet($"add package {data.IntegrationTest.XunitAssertPackage} --project {data.IntegrationTest.CakeSdkCpmProjectCsproj}");
        });

Task("IntegrationTest-PrepareTemplate")
    .IsDependentOn("IntegrationTest-PrepareProjects")
    .Does<BuildData>((ctx, data) =>
    {
        data.DotNet($"new install {data.OutputDirectory.CombineWithFilePath($"Cake.Template.{data.Version}.nupkg")} --force");
        data.DotNet($"new cakefile --name build --output {data.IntegrationTest.CakeTemplate}");
        data.DotNet($"new cakeproj --name build --output {data.IntegrationTest.CakeTemplate}");
        data.DotNet($"new uninstall Cake.Template");

        data.DotNet($"new sln --name Example --output {data.IntegrationTest.CakeTemplateSrc}");
        data.DotNet($"new classlib --name Example --output {data.IntegrationTest.CakeTemplateSrc.Combine("Example")}");
        data.DotNet($"sln {data.IntegrationTest.CakeTemplateSrc} add {data.IntegrationTest.CakeTemplateSrc.Combine("Example")}");
        data.DotNet($"new xunit --name Example.Tests --output {data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests")}");
        data.DotNet($"sln {data.IntegrationTest.CakeTemplateSrc} add {data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests")}");
    });

Task("IntegrationTest-UploadTestCases-Artifacts")
    .IsDependentOn("IntegrationTest-PrepareTemplate")
    .WithCriteria(GitHubActions.IsRunningOnGitHubActions, nameof(GitHubActions.IsRunningOnGitHubActions))
    .Does<BuildData>((ctx, data) => GitHubActions.Commands.UploadArtifact(
        data.IntegrationTestDirectory,
        $"IntegrationTest-{Context.Environment.Platform.Family}"));

Task("IntegrationTest-Execute")
    .IsDependentOn("IntegrationTest-UploadTestCases-Artifacts")
    .Does<BuildData>(
        Verbosity.Diagnostic,
        (ctx, data) =>
        {
            foreach (var file in data.IntegrationTest.TestFiles)
            {
                Information(
                    "Testing: {0}\r\n{1}",
                    file,
                    System.IO.File.ReadAllText(file.FullPath));

                var mode = file.GetExtension() == ".csproj" ? "--project " : string.Empty;
                DotNet(
                    data with {
                        WorkingDirectory = file.GetDirectory()
                    },
                    $"run {mode}{file} -- --integration-test-version={data.Version}");
            }
        });

Task("IntegrationTest-IoC")
    .Does<BuildData>((ctx, data) =>
    {
        var myTestService = ServiceProvider.GetRequiredService<IMyTestService>();
        myTestService.DoSomething();
    });

Task("IntegrationTest")
    .IsDependentOn("IntegrationTest-IoC")
    .IsDependentOn("IntegrationTest-Execute");

Task("Auth-NuGet-Feeds")
    .WithCriteria<BuildData>(data => data.ShouldPushNuGet, nameof(BuildData.ShouldPushNuGet))
    .Does((Action<ICakeContext, BuildData>)((ctx, data) =>
    {
        foreach (var source in data.NuGetPublishSettings.Sources)
        {
            if (!source.HasPassword && source.HasApiKey)
            {
                Information("Skipping feed Auth for NuGet feed: {0} (using API key).", source.Name);
                continue;
            }
            Information("Authenticating to NuGet feed: {0}", source.Name);

            if (source.OnlyPush)
            {
                DotNetNuGetAddSource(
                    source.Name,
                    new DotNetNuGetAddSourceSettings
                    {
                        UserName = source.UserName,
                        Password = source.Password,
                        Source = source.Source
                    });
            }
            else
            {
                DotNetNuGetUpdateSource(
                    source.Name,
                    new DotNetNuGetUpdateSourceSettings
                    {
                        UserName = source.UserName,
                        Password = source.Password,
                        Source = source.Source
                    });
            }
        }
    }));

Task("Publish-NuGet-Packages")
    .IsDependentOn("Sign-Binaries")
    .IsDependentOn("IntegrationTest")
    .IsDependentOn("Auth-NuGet-Feeds")
    .Does<BuildData>((ctx, data) =>
    {
        var packages = GetFiles($"{data.OutputDirectory}/Cake.*.{data.Version}.nupkg").ToArray();
        foreach (var package in packages)
        {
            if (!data.ShouldPushNuGet)
            {
                Information("Skipping package push for {0} as ShouldPushNuGet is false.", package);
                continue;
            }

            foreach (var dotNetNuGetPushSettings in data.NuGetPublishSettings.Settings)
            {
                Information("Pushing package: {0}", package);
                DotNetNuGetPush(package, dotNetNuGetPushSettings);
            }
        }
    });

Task("Sign-Binaries")
    .IsDependentOn("Pack")
    .WithCriteria<BuildData>(static (context, parameters) => parameters.ShouldSignPackages)
    .Does<BuildData>(static (context, data) =>
    {
        // Get the files to sign.
        var files = GetFiles($"{data.OutputDirectory}/Cake.*.{data.Version}.nupkg").ToArray();
        var commandSettings = new CommandSettings
        {
            ToolExecutableNames =
            [
                "sign", "sign.exe"
            ],
            ToolName = "sign",
            ToolPath = data.CodeSigningCredentials.SignClientPath
        };

        Parallel.ForEach(
            files,
            file =>
            {
                context.Information("Signing {0}...", file.FullPath);

                // Build the argument list.
                var arguments = new ProcessArgumentBuilder()
                .Append("code")
                .Append("azure-key-vault")
                .AppendQuoted(file.FullPath)
                .AppendSwitchQuoted("--file-list", data.CodeSigningCredentials.SignFilterPath.FullPath)
                .AppendSwitchQuoted("--publisher-name", "Cake")
                .AppendSwitchQuoted("--description", "Cake (C# Make) is a cross platform build automation system.")
                .AppendSwitchQuoted("--description-url", "https://cakebuild.net")
                .AppendSwitchQuoted("--azure-credential-type", "azure-cli")
                .AppendSwitchQuotedSecret("--azure-key-vault-certificate", data.CodeSigningCredentials.SignKeyVaultCertificate)
                .AppendSwitchQuotedSecret("--azure-key-vault-url", data.CodeSigningCredentials.SignKeyVaultUrl);

                context.Command(
                commandSettings,
                arguments);

                context.Information("Done signing {0}.", file.FullPath);
            });
    });

Task("Default")
    .IsDependentOn("Build");

Task("GitHubActions")
    .IsDependentOn("UploadArtifact")
    .IsDependentOn("IntegrationTest")
    .IsDependentOn("Publish-NuGet-Packages");

await RunTargetsAsync(targets);

public static partial class Program
{
    static partial void RegisterServices(IServiceCollection services)
    {
        services.AddSingleton<IMyTestService, MyTestService>();
    }
}
