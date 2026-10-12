public static partial class Program
{
    private static void IntegrationTestSetup(ICakeContext ctx, BuildData data)
    {
        EnsureDirectoryExists(data.WorkingDirectory);

        TransformTextFile("./src/Cake.Generator.TestApp/IntegrationTest/nuget.config.template")
            .WithToken("LOCAL_SOURCE_PATH", data.OutputDirectory.FullPath)
            .Save(data.IntegrationTest.NuGetConfig);
    }
}
