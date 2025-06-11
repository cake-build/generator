// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Generator;

public partial class CakeGenerator
{
    private const string ServiceProvider =
        """
        #nullable enable

        /// <summary>
        /// Main program class that provides access to the service provider and Cake context.
        /// </summary>
        public static partial class Program
        {
            /// <summary>
            /// Gets the configured service provider instance.
            /// </summary>
            public static IServiceProvider ServiceProvider => Helper.ServiceProvider.Value;

            private static partial class Helper
            {
                /// <summary>
                /// Gets the configured service provider instance.
                /// </summary>
                public static Lazy<ServiceProvider> ServiceProvider => new(GetServiceProvider);

                private static ServiceProvider GetServiceProvider()
                {
                    var services = new ServiceCollection();

                    AddCakeCore(services);
                    AddCakeCli(services);
                    AddCakeGenerator(services);
                    RegisterModules(services);
                    RegisterServices(services);

                    var provider = services.BuildServiceProvider();

                    PostBuildServiceProvider(provider);

                    return provider;
                }

                /// <summary>
                /// Partial method to register Cake modules.
                /// </summary>
                /// <param name="services">The service collection to add modules to.</param>
                static partial void RegisterModules(IServiceCollection services);
            }

            /// <summary>
            /// Partial method to register additional services.
            /// </summary>
            /// <param name="services">The service collection to add services to.</param>
            static partial void RegisterServices(IServiceCollection services);
        }
        """;
}