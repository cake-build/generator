public static partial class Program
{
    private static void IntegrationTestPrepareMultiFile(ICakeContext ctx, BuildData data)
    {
        // Create the cake.sdk.files directory
        CreateDirectory(data.IntegrationTest.CakeSdkFilesFolder);

        // Write the main cake.sdk.files.cs file
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesCs.FullPath,
            data.IntegrationTest.CakeSdkFilesCsCode);

        // Write the Models.cs file
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesModelsCs.FullPath,
            data.IntegrationTest.CakeSdkFilesModelsCsCode);

        // Write the Utilities.cs file
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesUtilitiesCs.FullPath,
            data.IntegrationTest.CakeSdkFilesUtilitiesCsCode);

        // Write the Excluded.cs file (this should not be compiled)
        System.IO.File.WriteAllText(
            data.IntegrationTest.CakeSdkFilesExcludedCs.FullPath,
            data.IntegrationTest.CakeSdkFilesExcludedCsCode);
    }
}