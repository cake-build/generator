public static partial class Program
{
    private static void IntegrationTestTool(ICakeContext ctx, BuildData data)
    {
        Information("Installing Cake.Tool...");
        InstallTool("dotnet:?package=Cake.Tool&version=6.1.0");
        var cakeTool = Context.Tools.Resolve("dotnet-cake") ?? Context.Tools.Resolve("dotnet-cake.exe");
        Information($"Installed Cake.Tool to {cakeTool}");

        var osArch = (ctx.Environment.Platform.Family, System.Runtime.InteropServices.RuntimeInformation.OSArchitecture);
        Information($"Installing bicep tool for {osArch}");
        FilePath[] bicepToolPaths;
        switch (osArch)
        {
            case (PlatformFamily.Windows, System.Runtime.InteropServices.Architecture.X64):
                bicepToolPaths = InstallTool("nuget:?package=Azure.Bicep.CommandLine.win-x64&version=0.41.2&include=/**/bicep.exe");
                break;

            case (PlatformFamily.Windows, System.Runtime.InteropServices.Architecture.Arm64):
                bicepToolPaths = InstallTool("nuget:?package=Azure.Bicep.CommandLine.win-arm64&version=0.41.2&include=/**/bicep.exe");
                break;

            case (PlatformFamily.Linux, System.Runtime.InteropServices.Architecture.X64):
                bicepToolPaths = InstallTool("nuget:?package=Azure.Bicep.CommandLine.linux-x64&version=0.41.2&include=/**/bicep");
                break;

            case (PlatformFamily.Linux, System.Runtime.InteropServices.Architecture.Arm64):
                bicepToolPaths = InstallTool("nuget:?package=Azure.Bicep.CommandLine.linux-arm64&version=0.41.2&include=/**/bicep");
                break;

            case (PlatformFamily.OSX, System.Runtime.InteropServices.Architecture.X64):
                bicepToolPaths = InstallTool("nuget:?package=Azure.Bicep.CommandLine.osx-x64&version=0.41.2&include=/**/bicep");
                break;

            case (PlatformFamily.OSX, System.Runtime.InteropServices.Architecture.Arm64):
                bicepToolPaths = InstallTool("nuget:?package=Azure.Bicep.CommandLine.osx-arm64&version=0.41.2&include=/**/bicep");
                break;

            default:
                Warning($"Platform {osArch.Family} with architecture {osArch.OSArchitecture} is not supported.");
                return;
        }

        var bicepTool = bicepToolPaths.FirstOrDefault() ?? throw new FileNotFoundException("Failed to resole tool");
        Information($"Installed bicep to {bicepTool}");

        Command(
            new CommandSettings
            {
                ToolExecutableNames = ["bicep", "bicep.exe"],
                ToolName = "bicep",
                ToolPath = bicepTool
            },
            "--version");
    }
}