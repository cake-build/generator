//HintName: CakeHelper.AddCakeGenerator.g.cs

using Microsoft.Extensions.DependencyInjection;

public static partial class Program
{
    private static partial class Helper
    {
        private static IServiceCollection AddCakeGenerator(
            IServiceCollection services
            )
        {
            services.AddSingleton<GeneratorScriptHost>();
            services.AddSingleton<IScriptHost>(provider => {
                var settings = provider.GetRequiredService<CakeAppSettings>();
                IScriptHost scriptHost = settings switch
                {
                    { DryRun: true } => provider.GetRequiredService<global::Cake.Cli.DryRunScriptHost>(),
                    { Description: true } => provider.GetRequiredService<global::Cake.Cli.DescriptionScriptHost>(),
                    { Tree: true } => provider.GetRequiredService<global::Cake.Cli.TreeScriptHost>(),
                    _ => provider.GetRequiredService<GeneratorScriptHost>()
                };

                if (settings.Exclusive)
                {
                    scriptHost.Settings.UseExclusiveTarget();
                }

                return scriptHost;
            });
            return services;
        }
    }
}