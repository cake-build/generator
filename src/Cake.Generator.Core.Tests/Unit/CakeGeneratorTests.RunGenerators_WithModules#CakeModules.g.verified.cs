//HintName: CakeModules.g.cs

using Cake.Core.Composition;
using Microsoft.Extensions.DependencyInjection;

public static partial class Program
{
    private static partial class Helper
    {
        /// <summary>
        /// Registers all discovered Cake modules with the service collection.
        /// This method is called between AddCakeCore calls in GetServiceProvider.
        /// </summary>
        /// <param name="services">The service collection to register modules with.</param>
        static partial void RegisterModules(IServiceCollection services)
        {
            var adapter = new ServiceCollectionAdapter();

            // Register GitHubActionsModule
            new global::Cake.GitHubActions.Module.GitHubActionsModule().Register(adapter);

            // Transfer all registered services to the IoC container
            adapter.Transfer(services);
        }

        private sealed class ServiceRegistration : ICakeRegistrationBuilder
        {
            [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)]
            public Type ImplementationType { get; }
            public object? Instance { get; set; }
            public Type? ServiceType { get; set; }
            public ServiceLifetime Lifetime { get; set; }

            public ServiceRegistration(Type implementationType)
            {
                ImplementationType = implementationType;
            }

            public ICakeRegistrationBuilder As(Type type)
            {
                ServiceType = type;
                return this;
            }

            public ICakeRegistrationBuilder AsSelf()
            {
                ServiceType = ImplementationType;
                return this;
            }

            public ICakeRegistrationBuilder Singleton()
            {
                Lifetime = ServiceLifetime.Singleton;
                return this;
            }

            public ICakeRegistrationBuilder Transient()
            {
                Lifetime = ServiceLifetime.Transient;
                return this;
            }
        }

        private sealed class ServiceCollectionAdapter : ICakeContainerRegistrar
        {
            private readonly List<ServiceRegistration> _registrations;

            public ServiceCollectionAdapter()
            {
                _registrations = new List<ServiceRegistration>();
            }

            public ICakeRegistrationBuilder RegisterInstance<TImplementation>(TImplementation instance)
                where TImplementation : class
            {
                var registration = new ServiceRegistration(typeof(TImplementation))
                {
                    Instance = instance,
                    Lifetime = ServiceLifetime.Singleton,
                    ServiceType = typeof(TImplementation),
                };

                _registrations.Add(registration);
                return registration;
            }

            public ICakeRegistrationBuilder RegisterType(Type type)
            {
                var registration = new ServiceRegistration(type)
                {
                    Lifetime = ServiceLifetime.Transient,
                    ServiceType = type,
                };

                _registrations.Add(registration);
                return registration;
            }

            public void Transfer(IServiceCollection services)
            {
                foreach (var registration in _registrations)
                {
                    if (registration.Instance != null)
                    {
                        var descriptor = ServiceDescriptor.Describe(registration.ServiceType!, f => registration.Instance, registration.Lifetime);
                        services.Add(descriptor);
                    }
                    else
                    {
                        var descriptor = ServiceDescriptor.Describe(registration.ServiceType!, registration.ImplementationType, registration.Lifetime);
                        services.Add(descriptor);
                    }
                }
            }
        }
    }
}
