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
            "dotnet:https://api.nuget.org/v3/index.json?package=sign&version=0.9.1-beta.25264.1&prerelease");

        var buildDate = DateTime.UtcNow;
        var baseVersion = typeof(ICakeContext).Assembly.GetName().Version?.ToString(2) ?? "1.0";

        var branchName = GitVersion(new GitVersionSettings { }).BranchName;
        var isMain = StringComparer.OrdinalIgnoreCase.Equals("main", branchName);

        var runNumber = GitHubActions.IsRunningOnGitHubActions
                    ? GitHubActions.Environment.Workflow.RunNumber
                    : (short)((buildDate - buildDate.Date).TotalSeconds / 3);

        var suffix = GitHubActions.IsRunningOnGitHubActions
                    ? (isMain ? string.Empty : "alpha")
                    : "local";

        var version = FormattableString
                    .Invariant($"{baseVersion}.{buildDate:yy}{buildDate.DayOfYear:000}.{runNumber}-{suffix}")
                    .TrimEnd('-');

        Information(
            "Branch: {0} (IsMain: {1}), Version: {2}",
            branchName,
            isMain,
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

        return new BuildData(
            version,
            branchName,
            isMain,
            MakeAbsolute(Directory("artifacts")),
            GetFiles("./src/Cake.Generator.slnx").FirstOrDefault() ?? throw new CakeException("Failed to find solution"),
            msBuildSettings);
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
                    add => new ()
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
                    options: new ()
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

Task("IntegrationTest-PrepareProjects")
    .IsDependentOn("IntegrationTest-PrepareAppCs")
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

Task("IntegrationTest-Execute")
    .IsDependentOn("IntegrationTest-PrepareTemplate")
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

Task("UploadArtifact")
    .IsDependentOn("Pack")
    .Does<BuildData>((ctx, data) => GitHubActions.Commands.UploadArtifact(
        data.OutputDirectory,
        "Cake.Generator"));

Task("Default")
    .IsDependentOn("Build");

Task("GitHubActions")
    .IsDependentOn("UploadArtifact")
    .IsDependentOn("IntegrationTest");

await RunTargetsAsync(targets);

public static partial class Program
{
    static partial void RegisterServices(IServiceCollection services)
    {
        services.AddSingleton<IMyTestService, MyTestService>();
    }
}
