public static partial class Program
{
    private static void IntegrationTestPrepareTemplate(ICakeContext ctx, BuildData data)
    {
        data.DotNet($"new install {data.OutputDirectory.CombineWithFilePath($"Cake.Template.{data.Version}.nupkg")} --force");
        data.DotNet($"new cakefile --name cake --output {data.IntegrationTest.CakeTemplate}");
        data.DotNet($"new cakeproj --name cake --output {data.IntegrationTest.CakeTemplate}");
        data.DotNet($"new uninstall Cake.Template");

        data.DotNet($"new sln --name Example --output {data.IntegrationTest.CakeTemplateSrc}");
        data.DotNet($"new classlib --name Example --output {data.IntegrationTest.CakeTemplateSrc.Combine("Example")}");
        data.DotNet($"sln {data.IntegrationTest.CakeTemplateSrc} add {data.IntegrationTest.CakeTemplateSrc.Combine("Example")}");
        data.DotNet($"new xunit --name Example.Tests --output {data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests")}");
        data.DotNet($"sln {data.IntegrationTest.CakeTemplateSrc} add {data.IntegrationTest.CakeTemplateSrc.Combine("Example.Tests")}");
    }
}