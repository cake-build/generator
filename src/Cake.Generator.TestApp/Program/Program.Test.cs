public static partial class Program
{
    private static void Test(ICakeContext ctx, BuildData data)
    {
        DotNetTest(
            data.SolutionPath.FullPath,
            new DotNetTestSettings
            {
                MSBuildSettings = data.MSBuildSettings,
                NoBuild = true,
                NoRestore = true,
            });
    }
}