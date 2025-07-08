public static partial class Program
{
    private static async Task IntegrationTestSetup(ICakeContext ctx, BuildData data)
    {
        data.DotNet("new globaljson");

        Information("Adding Cake.Sdk to global.json msbuild-sdks");
        using (var globalJsonStream = Context.FileSystem.GetFile(data.IntegrationTest.GlobalJson).Open(FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
        {
            var currentConfig = await JsonSerializer.DeserializeAsync<ConcurrentDictionary<string, Dictionary<string, string>>>(globalJsonStream);
            ArgumentNullException.ThrowIfNull(currentConfig);

            currentConfig.AddOrUpdate(
                "msbuild-sdks",
                add => new()
                    {
                        { "Cake.Sdk", data.Version }
                    },
                (key, update) =>
                    {
                        update["Cake.Sdk"] = data.Version;
                        return update;
                    });

            globalJsonStream.Position = 0;

            await JsonSerializer.SerializeAsync(
                globalJsonStream,
                currentConfig,
                options: new()
                {
                    WriteIndented = true,
                });
        }

        data.DotNet("new nugetconfig");

        data.DotNet($"nuget add source --name local \"{data.OutputDirectory.FullPath.Replace('/', System.IO.Path.DirectorySeparatorChar)}\"");
    }
}