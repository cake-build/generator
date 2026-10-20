public static partial class Program
{
    private static void IntegrationTestPrepareTemplate(ICakeContext ctx, BuildData data)
    {
        data.DotNet($"new install {data.OutputDirectory.CombineWithFilePath($"Cake.Template.{data.Version}.nupkg")} --force");

        data.DotNet("new cakeglobaljson");

        // Test cakeminimalfile template
        data.DotNet($"new cakeminimalfile --name cakeminimal --output {data.IntegrationTest.CakeTemplate}");

        // Test cakefile template without example project (default behavior)
        data.DotNet($"new cakefile --name cake --output {data.IntegrationTest.CakeTemplate}");

        // Test cakefile template with example project
        data.DotNet($"new cakefile --name cake-with-example --output {data.IntegrationTest.CakeTemplate.Combine("with-example")} --IncludeExampleProject true");

        data.DotNet($"new cakemultifile --name cakemultifile --output {data.IntegrationTest.CakeTemplate}");
        data.DotNet($"new cakeproj --name cake --output {data.IntegrationTest.CakeTemplate.Combine("cake")}");
        data.DotNet($"new uninstall Cake.Template");

        // Create manual example project structure for comparison (existing behavior)
        data.DotNet($"new sln --name Example --output {data.IntegrationTest.CakeTemplateSrc}");
        data.DotNet($"new classlib --name Example --output {data.IntegrationTest.CakeTemplateSrc.Combine("Example")}");
        CopyDirectory(
            data.IntegrationTest.CakeTemplateWithExampleSrc.Combine("Example.Tests"),
            data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests"));

        var slnAddSettings = data.IsolatedDotNetSettings(new DotNetSlnAddSettings());
        var solution = GetFiles(data.IntegrationTest.CakeTemplateSrc.CombineWithFilePath("Example.sln*").FullPath).FirstOrDefault()
                       ?? throw new CakeException($"Failed to find Example solution in {data.IntegrationTest.CakeTemplateSrc}");

        DotNetSlnAdd(
            solution,
            [
                data.IntegrationTest.CakeTemplateSrc.Combine("Example").CombineWithFilePath("Example.csproj")
            ],
            slnAddSettings);

        DotNetSlnAdd(
            solution,
            [
                data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests").CombineWithFilePath("Example.Tests.csproj")
            ],
            slnAddSettings);
    }
}
