public static partial class Program
{
    private static void Clean(ICakeContext ctx, BuildData data)
    {
       CleanDirectories(data.PathsToClean);
    }
}