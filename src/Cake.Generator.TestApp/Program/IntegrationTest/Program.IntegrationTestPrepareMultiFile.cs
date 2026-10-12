public static partial class Program
{
    private static void IntegrationTestPrepareMultiFile(ICakeContext ctx, BuildData data)
    {
        CreateDirectory(data.IntegrationTest.CakeSdkFilesFolder);

        WriteText(data.IntegrationTest.CakeSdkFilesCs, data.IntegrationTest.CakeSdkFilesCsCode);
        WriteText(data.IntegrationTest.CakeSdkFilesModelsCs, data.IntegrationTest.CakeSdkFilesModelsCsCode);
        WriteText(data.IntegrationTest.CakeSdkFilesUtilitiesCs, data.IntegrationTest.CakeSdkFilesUtilitiesCsCode);
        WriteText(data.IntegrationTest.CakeSdkFilesExcludedCs, data.IntegrationTest.CakeSdkFilesExcludedCsCode);
        WriteText(data.IntegrationTest.CakeSdkFilesMainCs, data.IntegrationTest.CakeSdkFilesMainCsCode);
    }
}
