public static partial class Program
{
    private static void AuthNuGetFeeds(ICakeContext ctx, BuildData data)
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
    }
}