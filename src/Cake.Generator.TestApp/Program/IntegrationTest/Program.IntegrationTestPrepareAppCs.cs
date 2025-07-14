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
    }
}