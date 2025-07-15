using System.Diagnostics.CodeAnalysis;

namespace Cake.Generator;

public partial class CakeGenerator
{
    private const string ServiceCollectionAdapter =
        """
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
            """;
}