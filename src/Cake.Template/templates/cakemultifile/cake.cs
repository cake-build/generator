#:sdk Cake.Sdk
#:property IncludeAdditionalFiles=build/**/*.cs
#:property ExcludeAdditionalFiles=build/**/Except*.cs

var target = Argument("target", "Default");

Setup(context => new BuildConfiguration(
    ProjectName: "MyProject",
    Version: "1.0.0",
    Configuration: Argument("configuration", "Release")
));

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does<BuildConfiguration>(static (context, config) =>
{
    BuildUtilities.LogInfo("Cleaning build artifacts...");
    CleanDirectory($"./src/Example/bin/{config.Configuration}");
});

Task("Build")
    .IsDependentOn("Clean")
    .Does<BuildConfiguration>(static (context, config) =>
{
    BuildUtilities.LogInfo($"Building {config.ProjectName} v{config.Version}");
    DotNetBuild("./src/Example.sln", new DotNetBuildSettings
    {
        Configuration = config.Configuration,
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does<BuildConfiguration>(static (context, config) =>
{
    BuildUtilities.LogInfo("Running tests...");
    DotNetTest("./src/Example.sln", new DotNetTestSettings
    {
        Configuration = config.Configuration,
        NoBuild = true,
    });
});

Task("Default")
    .IsDependentOn("Test")
    .Does(() =>
{
    BuildUtilities.LogInfo("Default task completed successfully!");
});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target); 