namespace Cake.Generator.TestApp.Models;

public class NuGetPublishSettings(
    bool isMainBranch,
    ICakeEnvironment environment)
{
    public DotNetNuGetPushSettings[] Settings { get; } =
        [
            ..
            new (string Name, bool OnlyMain, string? ApiKey, string? Source)[]
            {
                (
                    Name: "NuGet.org",
                    OnlyMain: true,
                    ApiKey: environment.GetEnvironmentVariable("NUGET_API_KEY"),
                    Source: environment.GetEnvironmentVariable("NUGET_API_URL")),
                (
                    Name: "Azure DevOps",
                    OnlyMain: false,
                    ApiKey: environment.GetEnvironmentVariable("AZURE_DEVOPS_NUGET_API_KEY"),
                    Source: environment.GetEnvironmentVariable("AZURE_DEVOPS_NUGET_API_URL"))
            }
            .Where(x => x.OnlyMain == isMainBranch || !x.OnlyMain)
            .Select(x =>
                {
                    if (isMainBranch)
                    {
                        if (string.IsNullOrWhiteSpace(x.ApiKey))
                        {
                            throw new InvalidOperationException($"API key for {x.Name} is not set. Please set the environment variable for {x.Name}.");
                        }
                        if (string.IsNullOrWhiteSpace(x.Source))
                        {
                            throw new InvalidOperationException($"Source URL for {x.Name} is not set. Please set the environment variable for {x.Name}.");
                        }
                    }

                    return new DotNetNuGetPushSettings
                    {
                        ApiKey = x.ApiKey,
                        Source = x.Source,
                        SkipDuplicate = true
                    };
                })
        ];
}