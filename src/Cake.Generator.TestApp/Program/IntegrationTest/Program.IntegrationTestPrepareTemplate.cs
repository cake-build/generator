using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;

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

        // Test cakeci template for each provider
        IntegrationTestPrepareCakeCiTemplate(data);

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

    private static void IntegrationTestPrepareCakeCiTemplate(BuildData data)
    {
        const string sdk10Image = "mcr.microsoft.com/dotnet/sdk:10.0-resolute-aot";
        const string sdk11Image = "mcr.microsoft.com/dotnet/sdk:11.0-resolute-aot";

        (string Name, string Arguments, string File, string[] Expected)[] cases =
            [
                ("github", "--Provider github", ".github/workflows/cake.yml", ["global-json-file: global.json", "runs-on: ubuntu-latest", "file-path: cake.cs"]),
                ("github-matrix", "--Provider github --OS matrix", ".github/workflows/cake.yml", ["os: [ubuntu-latest, macos-latest, windows-latest]", "runs-on: ${{ matrix.os }}"]),
                ("github-windows-11-arm", "--Provider github --OS windows-11-arm", ".github/workflows/cake.yml", ["runs-on: windows-11-arm"]),
                ("azuredevops", "--Provider azuredevops", "azure-pipelines.yml", ["useGlobalJson: true", "vmImage: ubuntu-latest", "dotnet cake.cs"]),
                ("azuredevops-matrix", "--Provider azuredevops --OS matrix", "azure-pipelines.yml", ["imageName: macOS-latest", "imageName: windows-latest", "vmImage: $(imageName)"]),
                ("azuredevops-macos-15", "--Provider azuredevops --OS macos-15", "azure-pipelines.yml", ["vmImage: macOS-15"]),
                ("azuredevops-ubuntu-24.04-arm", "--Provider azuredevops --OS ubuntu-24.04-arm", "azure-pipelines.yml", ["vmImage: ubuntu-latest"]),
                ("azuredevops-windows-2025-vs2026", "--Provider azuredevops --OS windows-2025-vs2026", "azure-pipelines.yml", ["vmImage: windows-latest"]),
                ("appveyor", "--Provider appveyor", "appveyor.yml", ["image: Ubuntu2404", "--jsonfile global.json", "-JsonFile global.json", "pwsh: dotnet cake.cs"]),
                ("appveyor-windows-latest", "--Provider appveyor --OS windows-latest", "appveyor.yml", ["image: Visual Studio 2026"]),
                ("appveyor-matrix", "--Provider appveyor --OS matrix", "appveyor.yml", ["  - Visual Studio 2026", "  - Ubuntu2404"]),
                ("rwx", "--Provider rwx", ".rwx/cake.yml", ["global-json-file: global.json", "run: dotnet cake.cs"]),
                ("bitbucket", "--Provider bitbucket", "bitbucket-pipelines.yml", [sdk11Image, "dotnet cake.cs"]),
                ("gitlab", "--Provider gitlab", ".gitlab-ci.yml", [sdk11Image, "dotnet cake.cs"]),
                ("gitlab-net10.0", "--Provider gitlab --Framework net10.0", ".gitlab-ci.yml", [sdk10Image]),
                ("gitlab-cakefile", "--Provider gitlab --CakeFile build/build.cs", ".gitlab-ci.yml", ["dotnet build/build.cs"]),
                ("woodpecker", "--Provider woodpecker", ".woodpecker/cake.yml", [sdk11Image, "dotnet cake.cs"]),
                ("bitrise", "--Provider bitrise", "bitrise.yml", [sdk11Image, "workflow: build-linux", "execution_container: dotnet"]),
                ("bitrise-macos-latest", "--Provider bitrise --OS macos-latest", "bitrise.yml", ["workflow: build-macos", "stack: osx-xcode-27.1.x", "--jsonfile global.json"]),
                ("bitrise-matrix", "--Provider bitrise --OS matrix", "bitrise.yml", [sdk11Image, "pipeline: build", "build-linux: {}", "build-macos: {}"]),
            ];

        foreach (var (name, arguments, file, expected) in cases)
        {
            var output = data.IntegrationTest.CakeTemplate.Combine("ci").Combine(name);
            data.DotNet(string.Concat("new cakeci ", arguments, " --output ", output.FullPath.Quote()));

            var pipelineFile = output.CombineWithFilePath(file);
            if (!FileExists(pipelineFile))
            {
                throw new CakeException($"cakeci template {name} did not create {pipelineFile}");
            }

            var generatedFiles = GetFiles($"{output.FullPath}/**/*");
            if (generatedFiles.Count != 1)
            {
                throw new CakeException($"cakeci template {name} created {generatedFiles.Count} files, expected 1");
            }

            var content = Context.FileSystem.GetFile(pipelineFile).ReadAllText();

            try
            {
                new YamlStream().Load(new System.IO.StringReader(content));
            }
            catch (YamlException ex)
            {
                throw new CakeException($"cakeci template {name} created invalid YAML in {pipelineFile} ({ex.Start.Line}:{ex.Start.Column}): {ex.Message}", ex);
            }

            var leakedConditional = content
                .Split('\n')
                .Select(line => line.TrimStart())
                .FirstOrDefault(line => line.StartsWith("#if", StringComparison.Ordinal)
                                     || line.StartsWith("#elif", StringComparison.Ordinal)
                                     || line.StartsWith("#else", StringComparison.Ordinal)
                                     || line.StartsWith("#endif", StringComparison.Ordinal));
            if (leakedConditional is not null)
            {
                throw new CakeException($"cakeci template {name} leaked template conditional '{leakedConditional.TrimEnd()}' in {pipelineFile}");
            }

            foreach (var value in expected)
            {
                if (!content.Contains(value, StringComparison.Ordinal))
                {
                    throw new CakeException($"cakeci template {name} is missing '{value}' in {pipelineFile}");
                }
            }
        }

        // Provider is mandatory
        var exitCode = 0;
        Command(
            new CommandSettings
            {
                ToolName = ".NET",
                ToolExecutableNames = ["dotnet", "dotnet.exe"],
                WorkingDirectory = data.WorkingDirectory,
                EnvironmentVariables = data.IsolatedNuGetEnvironment(),
                HandleExitCode = code =>
                {
                    exitCode = code;
                    return true;
                }
            },
            new ProcessArgumentBuilder()
                .Append("new cakeci --output")
                .AppendQuoted(data.IntegrationTest.CakeTemplate.Combine("ci").Combine("no-provider").FullPath));

        if (exitCode == 0)
        {
            throw new CakeException("cakeci template succeeded without the mandatory --Provider parameter");
        }
    }
}
