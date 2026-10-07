//HintName: CakeHelper.AddCakeCore.g.cs

using Cake.Cli;
using Microsoft.Extensions.DependencyInjection;

public static partial class Program
{
    private static partial class Helper
    {
        private static IServiceCollection AddCakeCore(
            IServiceCollection services
            )
        {
            // Shared Cake.Cli composition (filtered — not UseCakeDefaultModules)
            services.AddCakeDiagnostics();
            services.UseModule<global::Cake.Core.Modules.CoreModule>();

            // Sdk-specific extras CoreModule / diagnostics do not provide
            services.AddSingleton<CakeConfigurationProvider>();
            services.AddSingleton<ICakeConfiguration>(
                provider => {
                    var configProvider = provider.GetRequiredService<CakeConfigurationProvider>();
                    var environment = provider.GetRequiredService<ICakeEnvironment>();
                    var arguments = provider.GetRequiredService<ICakeArguments>();
                    var args = arguments.GetArguments().ToDictionary(x => x.Key, x => x.Value?.FirstOrDefault() ?? string.Empty);

                    return configProvider.CreateConfiguration(environment.WorkingDirectory, args);
                }
            );
            services.AddSingleton<ICakeReportPrinter, global::Cake.Cli.CakeSpectreReportPrinter>();

            return services;
        }
    }
}