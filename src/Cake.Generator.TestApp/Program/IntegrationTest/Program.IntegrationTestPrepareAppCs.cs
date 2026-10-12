public static partial class Program
{
    private static void IntegrationTestPrepareAppCs(ICakeContext ctx, BuildData data)
    {
        WriteText(data.IntegrationTest.CakeCs, data.IntegrationTest.CakeCsCode);
        WriteText(data.IntegrationTest.CakeSdkCs, data.IntegrationTest.CakeSdkCsCode);
        WriteText(data.IntegrationTest.CakeVerbosityCs, data.IntegrationTest.CakeVerbosityCsCode);

        EnsureDirectoryExists(data.IntegrationTest.CakeVerbosityConfigDirectory);
        WriteText(data.IntegrationTest.CakeVerbosityConfigFile, data.IntegrationTest.CakeVerbosityConfigCode);
    }
}
