public static partial class Program
{
    private static void IntegrationTestRunCode(ICakeContext ctx, BuildData data)
    {
        Information("Testing DotNetRunCode (stdin Cake.Sdk script)");

        var code = data.IntegrationTest.CakeSdkCsCode.Replace(
            "#:sdk Cake.Sdk",
            $"#:sdk Cake.Sdk@{data.Version}",
            StringComparison.Ordinal);

        DotNetRunCode(
            code,
            $"--integration-test-version={data.Version}",
            data.IsolatedDotNetSettings(new DotNetRunSettings()));
    }
}
