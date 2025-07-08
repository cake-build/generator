public static partial class Program
{
    private static void PublishNuGetPackages(ICakeContext ctx, BuildData data)
    {
        var packages = GetFiles($"{data.OutputDirectory}/Cake.*.{data.Version}.nupkg").ToArray();
        var failedPushes = new ConcurrentBag<(FilePath Package, DotNetNuGetPushSettings Settings, Exception Exception)>();

        Parallel.ForEach(packages, package =>
        {
            if (!data.ShouldPushNuGet)
            {
                Information("Skipping package push for {0} as ShouldPushNuGet is false.", package);
                return;
            }

            Parallel.ForEach(data.NuGetPublishSettings.Settings, dotNetNuGetPushSettings =>
            {
                try
                {
                    Information("Pushing package: {0}", package);
                    DotNetNuGetPush(package, dotNetNuGetPushSettings);
                }
                catch (Exception ex)
                {
                    failedPushes.Add((Package: package.FullPath, Settings: dotNetNuGetPushSettings, Exception: ex));
                    Information("Failed to push package {0} to {1}: {2}", package, dotNetNuGetPushSettings.Source, ex.Message);
                }
            });
        });

        if (failedPushes.Any())
        {
            var errorMessage = string.Join(Environment.NewLine,
                failedPushes.Select(f => $"Failed to push {f.Package} to {f.Settings.Source}: {f.Exception.Message}"));
            throw new CakeException($"Failed to push {failedPushes.Count} package(s):{Environment.NewLine}{errorMessage}");
        }
    }
}