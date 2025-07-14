public static partial class Program
{
    private static void UploadArtifact(ICakeContext ctx, BuildData data)
    {
        GitHubActions.Commands.UploadArtifact(
            data.OutputDirectory,
            $"Cake.Generator-{Context.Environment.Platform.Family}");
    }
}