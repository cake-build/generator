public static partial class Program
{
    private static void IntegrationTestPrepareProjects(ICakeContext ctx, BuildData data)
    {
        CleanDirectory(data.IntegrationTest.CakeSdkProject);

        WriteText(
            data.IntegrationTest.CakeSdkProjectCsproj,
            data.IntegrationTest.CakeSdkProjectCsprojCode);

        WriteText(
            data.IntegrationTest.CakeSdkProjectProgramCs,
            data.IntegrationTest.BaseCode);

        if (DirectoryExists(data.IntegrationTest.CakeSdkCpmProject))
        {
            DeleteDirectory(
                data.IntegrationTest.CakeSdkCpmProject,
                new DeleteDirectorySettings { Recursive = true });
        }

        CopyDirectory(
            data.IntegrationTest.CakeSdkProject,
            data.IntegrationTest.CakeSdkCpmProject);

        WriteText(
            data.IntegrationTest.CakeSdkCpmPackagesProps,
            data.IntegrationTest.CakeSdkCpmPackagesPropsCode);

        DotNetRestore(
            data.IntegrationTest.CakeSdkProjectCsproj.FullPath,
            data.IsolatedDotNetSettings(new DotNetRestoreSettings
            {
                Verbosity = DotNetVerbosity.Minimal
            }));

        DotNetRestore(
            data.IntegrationTest.CakeSdkCpmProjectCsproj.FullPath,
            data.IsolatedDotNetSettings(new DotNetRestoreSettings
            {
                Verbosity = DotNetVerbosity.Minimal
            }));

        var addPackageSettings = data.IsolatedDotNetSettings(new DotNetPackageAddSettings
        {
            Version = "2"
        });

        DotNetAddPackage(
            "xunit.v3.assert",
            data.IntegrationTest.CakeSdkProjectCsproj.FullPath,
            addPackageSettings);

        DotNetAddPackage(
            "xunit.v3.assert",
            data.IntegrationTest.CakeSdkCpmProjectCsproj.FullPath,
            addPackageSettings);

        if (DirectoryExists(data.IntegrationTest.CakeSdkConverted))
        {
            DeleteDirectory(
                data.IntegrationTest.CakeSdkConverted,
                new DeleteDirectorySettings { Recursive = true });
        }

        Information("Converting project {0} to {1}", data.IntegrationTest.CakeSdkCs, data.IntegrationTest.CakeSdkConverted);
        DotNetProjectConvert(
            data.IntegrationTest.CakeSdkCs,
            data.IsolatedDotNetSettings(new DotNetProjectConvertSettings
            {
                Output = data.IntegrationTest.CakeSdkConverted,
                DeleteSource = false,
                Interactive = false
            }));
    }
}
