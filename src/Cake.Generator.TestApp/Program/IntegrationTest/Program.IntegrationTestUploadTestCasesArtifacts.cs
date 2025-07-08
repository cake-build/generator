public static partial class Program
{
    private static void IntegrationTestUploadTestCasesArtifacts(ICakeContext ctx, BuildData data)
    {
        GitHubActions.Commands.UploadArtifact(
            data.IntegrationTestDirectory,
            $"IntegrationTest-{Context.Environment.Platform.Family}");
    }
}