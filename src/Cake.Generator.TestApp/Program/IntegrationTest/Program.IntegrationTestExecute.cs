public static partial class Program
{
    private static void IntegrationTestExecute(ICakeContext ctx, BuildData data)
    {
        foreach (var file in data.IntegrationTest.TestFiles)
        {
            Information(
                "Testing: {0}\r\n{1}",
                file,
                System.IO.File.ReadAllText(file.FullPath));

            var mode = file.GetExtension() == ".csproj" ? "--project " : string.Empty;
            DotNet(
                data with {
                    WorkingDirectory = file.GetDirectory()
                },
                $"run {mode}{file} -- --integration-test-version={data.Version}");
        }
    }
}