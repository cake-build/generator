public static partial class Program
{
    private static void IntegrationTestPrepareProjects(ICakeContext ctx, BuildData data)
    {
        CleanDirectory(data.IntegrationTest.CakeSdkProject);

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkProjectCsproj.FullPath,
            data.IntegrationTest.CakeSdkProjectCsprojCode);

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkProjectProgramCs.FullPath,
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

        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkCpmPackagesProps.FullPath,
            data.IntegrationTest.CakeSdkCpmPackagesPropsCode);

        data.DotNet($"restore --verbosity minimal {data.IntegrationTest.CakeSdkProjectCsproj}");

        data.DotNet($"restore --verbosity minimal {data.IntegrationTest.CakeSdkCpmProjectCsproj}");

        data.DotNet($"add package {data.IntegrationTest.XunitAssertPackage} --project {data.IntegrationTest.CakeSdkProjectCsproj}");

        data.DotNet($"add package {data.IntegrationTest.XunitAssertPackage} --project {data.IntegrationTest.CakeSdkCpmProjectCsproj}");
    }
}