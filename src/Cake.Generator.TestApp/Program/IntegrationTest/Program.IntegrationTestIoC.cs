public static partial class Program
{
    private static void IntegrationTestIoC(ICakeContext ctx, BuildData data)
    {
        var myTestService = ServiceProvider.GetRequiredService<IMyTestService>();
        myTestService.DoSomething();
    }
}