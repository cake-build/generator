//HintName: CakeModules.g.cs

using Cake.Cli;
using Microsoft.Extensions.DependencyInjection;

public static partial class Program
{
    private static partial class Helper
    {
        /// <summary>
        /// Registers all discovered Cake modules with the service collection.
        /// This method is called from GetServiceProvider after AddCakeCore.
        /// </summary>
        /// <param name="services">The service collection to register modules with.</param>
        static partial void RegisterModules(IServiceCollection services)
        {
            // Register GitHubActionsModule
            services.UseModule<global::Cake.GitHubActions.Module.GitHubActionsModule>();

            // Register NuGetModule
            services.UseModule<global::Cake.NuGet.NuGetModule>();

            // Register DotNetToolModule
            services.UseModule<global::Cake.DotNetTool.Module.DotNetToolModule>();

        }
    }
}
