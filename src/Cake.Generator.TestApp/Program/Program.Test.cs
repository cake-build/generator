public static partial class Program
{
    private static void Test(ICakeContext ctx, BuildData data)
    {
        DotNetTest(
            null!,
            new DotNetTestSettings
            {
                MSBuildSettings = data.MSBuildSettings,
                NoBuild = true,
                NoRestore = true,
                ArgumentCustomization = args => args.AppendSwitch("--solution", data.SolutionPath.FullPath.Quote())
            });
    }
}