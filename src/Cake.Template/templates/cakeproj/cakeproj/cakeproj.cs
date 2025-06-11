var target = Argument("target", "Test");
var configuration = Argument("configuration", "Release");

Setup(context =>
{
    if (GitHubActions.IsRunningOnGitHubActions)
    {
        var templateVersion = context.Argument("template-version", "");
        if (!string.IsNullOrEmpty(templateVersion))
        {
            context.Information($"Running on GitHub Actions with TemplateVersion: {templateVersion}");
            
            // Apply template version to MSBuild settings if needed
            var msBuildSettings = new DotNetMSBuildSettings()
                .WithProperty("TemplateVersion", templateVersion);
        }
    }
});

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does(() =>
{
    CleanDirectory($"./src/Example/bin/{configuration}");
});

Task("Build")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetBuild("./src/Example.sln", new DotNetBuildSettings
    {
        Configuration = configuration,
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetTest("./src/Example.sln", new DotNetTestSettings
    {
        Configuration = configuration,
        NoBuild = true,
    });
});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target); 