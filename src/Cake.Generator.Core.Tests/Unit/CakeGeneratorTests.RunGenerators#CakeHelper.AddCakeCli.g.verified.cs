//HintName: CakeHelper.AddCakeCli.g.cs

using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;

public static partial class Program
{
    private static partial class Helper
    {
        private static IServiceCollection AddCakeCli(
            IServiceCollection services
            )
        {
            // Converters
            services.AddSingleton<global::Cake.Cli.DirectoryPathConverter>();
            services.AddSingleton<global::Cake.Cli.FilePathConverter>();
            services.AddSingleton<global::Cake.Cli.VerbosityConverter>();
            services.AddSingleton<global::Cake.Cli.VersionFeature>();
            services.AddSingleton<global::Cake.Cli.InfoFeature>();
            services.AddSingleton<global::Cake.Cli.IVersionResolver, VersionResolver>();

            services.AddSingleton<global::Cake.Cli.DescriptionScriptHost>();
            services.AddSingleton<global::Cake.Cli.DryRunScriptHost>();
            services.AddSingleton<global::Cake.Cli.TreeScriptHost>();

            var interceptor = new CakeArgumentsCommandInterceptor();
            var commandApp = new CommandApp<CakeArgumentsCommand>();
            
            var appName = new FilePath(Environment.GetCommandLineArgs().FirstOrDefault() ?? "cake").GetFilenameWithoutExtension();

            commandApp.Configure(config => {
                    config.SetInterceptor(interceptor);
                    config.SetApplicationName($"dotnet run {appName}.cs / dotnet run --project {appName}.csproj");
                }
            );
            
            var result = commandApp.Run(Environment.GetCommandLineArgs().Skip(1));

            // If the command is not a cake command, exit with the result
            if (interceptor.Context is null || interceptor.CakeAppSettings is null)
            {
                Environment.Exit(result);
            }

            services.AddSingleton(interceptor.CakeAppSettings);
            services.AddSingleton<Spectre.Console.Cli.CommandSettings>(provider => provider.GetRequiredService<CakeAppSettings>());
            
            var arguments = global::Cake.Cli.Infrastructure.IRemainingArgumentsExtensions.ToCakeArguments(interceptor.Context.Remaining, interceptor.CakeAppSettings.Targets);
            services.AddSingleton(arguments);
            services.AddSingleton<ICakeArguments>(arguments);

            return services;
        }

        private class CakeArgumentsCommandInterceptor : ICommandInterceptor
        {
            public CommandContext? Context { get; private set; }
            public Spectre.Console.Cli.CommandSettings? CommandSettings { get; private set; }
            public CakeAppSettings? CakeAppSettings { get; private set; }
            public void Intercept(CommandContext context, Spectre.Console.Cli.CommandSettings settings)
            {
                Context = context;
                CommandSettings = settings;
                if (settings is CakeAppSettings cakeAppSettings)
                {
                    CakeAppSettings = cakeAppSettings;
                }
            }
        }

        private class CakeArgumentsCommand : Command<CakeAppSettings>
        {
            public override int Execute(Spectre.Console.Cli.CommandContext context, CakeAppSettings settings)
            {
                return 0;
            }
        }

        private class VersionResolver : global::Cake.Cli.IVersionResolver
        {
            public string GetVersion() => CakeGeneratorVersion;
            public string GetProductVersion() => CakeGeneratorInformationalVersion;
        }
    }
}