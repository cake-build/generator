namespace Cake.Generator.TestApp.Services;

public class MyTestService(
    ICakeLog log)
    : IMyTestService
{
    public void DoSomething()
    {
        log.Information("Doing something");
    }
}
