public static partial class Program
{
    static partial void RegisterServices(IServiceCollection services)
    {
        services.AddSingleton<IMyTestService, MyTestService>();
    }
}