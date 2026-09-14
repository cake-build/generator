public static partial class Program
{
    private static void IntegrationTestPrepareAppCs(ICakeContext ctx, BuildData data)
    {
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeCs.FullPath,
            data.IntegrationTest.CakeCsCode);

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkCs.FullPath,
            data.IntegrationTest.CakeSdkCsCode);

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeVerbosityCs.FullPath,
            data.IntegrationTest.CakeVerbosityCsCode);

        EnsureDirectoryExists(data.IntegrationTest.CakeVerbosityConfigDirectory);

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeVerbosityConfigFile.FullPath,
            data.IntegrationTest.CakeVerbosityConfigCode);
    }
}