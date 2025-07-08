public static partial class Program
{
    private static void Restore(ICakeContext ctx, BuildData data)
    {
        DotNetRestore(
            data.SolutionPath.FullPath,
            new DotNetRestoreSettings
            {
                MSBuildSettings = data.MSBuildSettings,
                NoCache = true
            });
    }
}