//HintName: CakeHelper.AddCakeCore.g.cs

using Microsoft.Extensions.DependencyInjection;

public static partial class Program
{
    private static partial class Helper
    {
        private static IServiceCollection AddCakeCore(
            IServiceCollection services
            )
        {
            // Execution
            services.AddSingleton<ICakeContext, CakeContext>();

            var cakeDataService = new CakeDataService();

            services.AddSingleton<ICakeDataResolver>(cakeDataService);
            services.AddSingleton<ICakeDataService>(cakeDataService);

            // Utilities
            services.AddSingleton<CakeConfigurationProvider>();
            services.AddSingleton<ICakeConfiguration>(
                provider => {
                    var configProvider = provider.GetRequiredService<CakeConfigurationProvider>();
                    var arguments = provider.GetRequiredService<ICakeArguments>();
                    var args = arguments.GetArguments().ToDictionary(x => x.Key, x => x.Value?.FirstOrDefault() ?? string.Empty);

                    return configProvider.CreateConfiguration(Environment.CurrentDirectory, args);
                }
            );

            // Environment
            services.AddSingleton<ICakeEnvironment, CakeEnvironment>();
            services.AddSingleton<ICakeRuntime, CakeRuntime>();
            services.AddSingleton<ICakePlatform, CakePlatform>();

            // IO
            services.AddSingleton<IFileSystem, FileSystem>();
            services.AddSingleton<IGlobber, Globber>();
            services.AddSingleton<IProcessRunner, ProcessRunner>();
            services.AddSingleton<INuGetToolResolver, NuGetToolResolver>();
            services.AddSingleton<IRegistry, WindowsRegistry>();

            // Reflection
            services.AddSingleton<IAssemblyLoader, AssemblyLoader>();
            services.AddSingleton<IAssemblyVerifier, AssemblyVerifier>();

            // Tooling
            services.AddSingleton<IToolRepository, ToolRepository>();
            services.AddSingleton<IToolResolutionStrategy, ToolResolutionStrategy>();
            services.AddSingleton<IToolLocator, ToolLocator>();

            // Logging
            services.AddSingleton<IConsole, CakeConsole>();
            services.AddSingleton<ICakeLog, CakeBuildLog>();
            services.AddSingleton(AnsiConsole.Console);

            // Scripting
            services.AddSingleton<ICakeReportPrinter, global::Cake.Cli.CakeSpectreReportPrinter>();
            services.AddSingleton<IExecutionStrategy, DefaultExecutionStrategy>();
            services.AddSingleton<ICakeEngine, CakeEngine>();

            return services;
        }
    }
}