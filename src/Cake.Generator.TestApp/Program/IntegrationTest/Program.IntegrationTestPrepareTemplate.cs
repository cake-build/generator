public static partial class Program
{
    private static void IntegrationTestPrepareTemplate(ICakeContext ctx, BuildData data)
    {
        data.DotNet($"new install {data.OutputDirectory.CombineWithFilePath($"Cake.Template.{data.Version}.nupkg")} --force");

        data.DotNet("new cakeglobaljson");

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
        data.DotNet($"sln {data.IntegrationTest.CakeTemplateSrc} add {data.IntegrationTest.CakeTemplateSrc.Combine("Example")}");
        data.DotNet($"new xunit --name Example.Tests --output {data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests")}");
        data.DotNet($"sln {data.IntegrationTest.CakeTemplateSrc} add {data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests")}");
    }
}