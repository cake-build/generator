namespace Cake.Generator.TestApp.Models;

public class NuGetPublishSettings(
    bool isMainBranch,
    bool isTagged,
    ICakeEnvironment environment)
{
    public NuGetSource[] Sources { get; } =
            [
                ..
                new NuGetSource[]
                {
                        new(
                            Name: "nuget",
                            OnlyTagged: true,
                            ApiKey: environment.GetEnvironmentVariable("NUGET_API_KEY"),
                            Source: environment.GetEnvironmentVariable("NUGET_API_URL")),
                        new(
                            Name: "AzureDevOps",
                            OnlyTagged: false,
                            ApiKey: "AzureDevOps",
                            UserName: "AzureDevOps",
                            Password: environment.GetEnvironmentVariable("AZURE_DEVOPS_NUGET_API_KEY"),
                            Source: environment.GetEnvironmentVariable("AZURE_DEVOPS_NUGET_API_URL"),
                            OnlyPush: true)
                }
                .Where(x => x.OnlyTagged == isTagged
                            || !x.OnlyTagged)
            ];

    private DotNetNuGetPushSettings[]? settings;
    public DotNetNuGetPushSettings[] Settings => settings ??=
        [
            ..
            Sources
            .Select(x =>
                {
                    if (isMainBranch || isTagged)
                    {
                        if (!x.HasApiKey && !x.HasPassword)
                        {
                            throw new InvalidOperationException($"API / Password key for {x.Name} is not set. Please set the environment variable for {x.Name}.");
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

public record struct NuGetSource(
    string Name,
    bool OnlyTagged,
    string? Source,
    string? ApiKey = null,
    string? UserName = null,
    string? Password = null,
    bool OnlyPush = false)
{
    public bool HasApiKey { get; } = !string.IsNullOrWhiteSpace(ApiKey);
    public bool HasPassword { get; } = !string.IsNullOrWhiteSpace(Password);
}