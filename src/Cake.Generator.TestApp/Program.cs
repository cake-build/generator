﻿var targets = Arguments(
                "target",
                [
                    "Default"
                ]);

Setup(
    Verbosity.Diagnostic,
    SetupTask);

Task("Clean")
    .Does<BuildData>(Clean);

Task("Restore")
    .IsDependentOn("Clean")
    .Does<BuildData>(Restore);

Task("Build")
    .IsDependentOn("Restore")
    .Does<BuildData>(Build);

Task("Test")
    .Does<BuildData>(Test)
    .IsDependentOn("Build");

Task("Pack")
    .IsDependentOn("Test")
    .Does<BuildData>(Pack);

Task("UploadArtifact")
    .IsDependentOn("Pack")
    .IsDependentOn("Sign-Binaries")
    .WithCriteria(GitHubActions.IsRunningOnGitHubActions, nameof(GitHubActions.IsRunningOnGitHubActions))
    .Does<BuildData>(UploadArtifact);

Task("IntegrationTest-Setup")
    .IsDependentOn("Pack")
    .Does<BuildData>(
        Verbosity.Diagnostic,
        IntegrationTestSetup);

Task("IntegrationTest-PrepareTemplate")
    .IsDependentOn("IntegrationTest-Setup")
    .Does<BuildData>(IntegrationTestPrepareTemplate);

Task("IntegrationTest-PrepareAppCs")
    .IsDependentOn("IntegrationTest-PrepareTemplate")
    .Does<BuildData>(IntegrationTestPrepareAppCs);

Task("IntegrationTest-PrepareMultiFile")
    .IsDependentOn("IntegrationTest-PrepareAppCs")
    .Does<BuildData>(IntegrationTestPrepareMultiFile);

Task("IntegrationTest-PrepareProjects")
    .IsDependentOn("IntegrationTest-PrepareMultiFile")
    .Does<BuildData>(
        Verbosity.Diagnostic,
        IntegrationTestPrepareProjects);

Task("IntegrationTest-UploadTestCases-Artifacts")
    .IsDependentOn("IntegrationTest-PrepareProjects")
    .WithCriteria(GitHubActions.IsRunningOnGitHubActions, nameof(GitHubActions.IsRunningOnGitHubActions))
    .Does<BuildData>(IntegrationTestUploadTestCasesArtifacts);

Task("IntegrationTest-Execute")
    .IsDependentOn("IntegrationTest-UploadTestCases-Artifacts")
    .Does<BuildData>(
        Verbosity.Diagnostic,
        IntegrationTestExecute);

Task("IntegrationTest-IoC")
    .Does<BuildData>(IntegrationTestIoC);

Task("IntegrationTest")
    .IsDependentOn("IntegrationTest-IoC")
    .IsDependentOn("IntegrationTest-Execute");

TaskOf<BuildData>("Auth-NuGet-Feeds")
    .WithCriteria(static (context, data) => data.ShouldPushNuGet, nameof(BuildData.ShouldPushNuGet))
    .Does(AuthNuGetFeeds);

Task("Publish-NuGet-Packages")
    .IsDependentOn("Sign-Binaries")
    .IsDependentOn("IntegrationTest")
    .IsDependentOn("Auth-NuGet-Feeds")
    .Does<BuildData>(PublishNuGetPackages);

TaskOf<BuildData>("Sign-Binaries")
    .IsDependentOn("Pack")
    .WithCriteria(static (context, parameters) => parameters.ShouldSignPackages)
    .Does(SignBinaries);

Task("Default")
    .IsDependentOn("Build");

Task("GitHubActions")
    .IsDependentOn("UploadArtifact")
    .IsDependentOn("IntegrationTest")
    .IsDependentOn("Publish-NuGet-Packages");

await RunTargetsAsync(targets);