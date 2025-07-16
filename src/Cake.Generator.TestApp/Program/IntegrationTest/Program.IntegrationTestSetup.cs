public static partial class Program
{
    private static void IntegrationTestSetup(ICakeContext ctx, BuildData data)
    {
        data.DotNet("new nugetconfig");

        data.DotNet($"nuget add source --name local \"{data.OutputDirectory.FullPath.Replace('/', System.IO.Path.DirectorySeparatorChar)}\"");
    }
}