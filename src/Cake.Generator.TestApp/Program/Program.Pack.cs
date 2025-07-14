public static partial class Program
{
    private static void Pack(ICakeContext ctx, BuildData data)
    {
        DotNetPack(
            data.SolutionPath.FullPath,
            new DotNetPackSettings
            {
                MSBuildSettings = data.MSBuildSettings,
                NoBuild = true,
                NoRestore = true,
                OutputDirectory = data.OutputDirectory
            });
    }
}