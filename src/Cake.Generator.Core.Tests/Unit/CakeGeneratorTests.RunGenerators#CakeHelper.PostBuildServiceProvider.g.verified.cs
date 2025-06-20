//HintName: CakeHelper.PostBuildServiceProvider.g.cs

using Microsoft.Extensions.DependencyInjection;

public static partial class Program
{
    private static partial class Helper
    {
        private static void PostBuildServiceProvider(
            IServiceProvider provider
            )
        {
            if (provider.GetService<CakeAppSettings>() is CakeAppSettings settings)
            {
                if (settings.Version)
                {
                    // Show version
                    var console = provider.GetRequiredService<IConsole>();
                    provider.GetRequiredService<VersionFeature>().Run(console);
                    Environment.Exit(0);
                }
                else if (settings.Info)
                {
                    // Show information
                    var console = provider.GetRequiredService<IConsole>();
                    provider.GetRequiredService<InfoFeature>().Run(console);
                    Environment.Exit(0);
                }

                var log = provider.GetRequiredService<ICakeLog>();
                log.Verbosity = settings.Verbosity;

                if (settings.WorkingDirectory is DirectoryPath workingDirectory)
                {
                    var environment = provider.GetRequiredService<ICakeEnvironment>();
                    var fileSystem = provider.GetRequiredService<IFileSystem>();
                    var directory = workingDirectory.MakeAbsolute(environment);

                    if (!fileSystem.Exist(directory))
                    {
                        throw new CakeException($"The working directory '{directory.FullPath}' does not exist.");
                    }

                    environment.WorkingDirectory = directory;
                }
            }
        }
    }
}