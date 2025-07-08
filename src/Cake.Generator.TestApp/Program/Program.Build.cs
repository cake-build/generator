public static partial class Program
{
    private static void Build(ICakeContext ctx, BuildData data)
    {
        DotNetBuild(
            data.SolutionPath.FullPath,
            new DotNetBuildSettings
            {
                MSBuildSettings = data.MSBuildSettings,
                NoRestore = true,
            });
    }
}