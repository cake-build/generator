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

            var working = data with
            {
                WorkingDirectory = file.GetDirectory()
            };

            if (file.GetExtension() == ".csproj")
            {
                var settings = working.IsolatedDotNetSettings(new DotNetRunSettings());
                settings.ArgumentCustomization = args => args.Append("-p:TreatWarningsAsErrors=true");

                DotNetRun(
                    file.FullPath,
                    $"--integration-test-version={data.Version}",
                    settings);
                continue;
            }

            working.DotNet($"{file} -p:TreatWarningsAsErrors=true -- --integration-test-version={data.Version}");
        }
    }
}
