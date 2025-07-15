# Cake.Sdk

A custom SDK that provides a convenient way to create Cake projects with minimal configuration. This SDK automatically sets up common properties and provides a streamlined development experience for Cake-based build automation projects.

## Features

- **Minimal Project Configuration**: Create Cake projects with just a few lines in your `.csproj` file
- **Optimized Build Settings**: Pre-configured with optimal settings for Cake projects
- **Built-in Source Generation**: Includes Cake.Generator by default for automatic source generation capabilities

## Usage

### Basic Project Setup

Create a new project file with minimal configuration:

#### csproj

```xml
<Project Sdk="Cake.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
  </PropertyGroup>
</Project>
```

#### Program

Here's a minimal example of a Cake SDK program

```csharp
var target = Argument("target", "Default");

Task("Default")
    .Does(() =>
{
    Information("Hello from Cake!");
});

RunTarget(target);
```

#### Execute example

```bash
dotnet run --project [path to csproj] -- [arguments]
```
i.e.
```bash
dotnet run --project build/build.csproj -- --target=Build
```

#### Single file-based Cake app example

Here's a minimal example using the single file approach:

```csharp
#:sdk Cake.Sdk

var target = Argument("target", "Default");

Task("Default")
    .Does(() =>
{
    Information("Hello from Cake!");
});

RunTarget(target);
```

To execute a single file-based app:
```bash
dotnet run [path to cs file] -- [arguments]
```
i.e.
```bash
dotnet run build.cs -- --target=Build
```

> **Note**: File-based Cake apps require .NET 10 or later.

#### Multi-file structure for file-based Cake apps

For larger file-based Cake apps, you can organize your code into multiple files. Use the `IncludeAdditionalFiles` and `ExcludeAdditionalFiles` properties to control which files are included during compilation. This allows you to place models, utility functions, and other code in separate files.

**build.cs**
```csharp
#:sdk Cake.Sdk
#:property IncludeAdditionalFiles=build/**/*.cs
#:property ExcludeAdditionalFiles=build/**/Except*.cs

var target = Argument("target", "Default");
var config = new BuildConfiguration 
{ 
    ProjectName = "MyProject",
    Version = "1.0.0" 
};

Task("Default")
    .Does(() =>
{
    BuildUtilities.LogInfo($"Building {config.ProjectName} v{config.Version}");
});

RunTarget(target);
```

This will include all `.cs` files in the `build` directory...

**build/Models.cs**
```csharp
public class BuildConfiguration
{
    public string ProjectName { get; set; } = "";
    public string Version { get; set; } = "";
}
```

**build/Utilities.cs**
```csharp
public static partial class Program
{
    public static void LogInfo(string message)
    {
        Information($"INFO: {message}");
    }
}
```

...except for files that match the `ExcludeAdditionalFiles` pattern.

**build/ExceptThisFile.cs**
```csharp
// This class will not be compiled.
public class UnusedLogic
{
}
```

### Source Generation

The Cake.Generator package is included by default with Cake.Sdk, providing automatic source generation capabilities without any additional configuration needed.

### Tool Installation

Install tools using the provided methods:

```csharp
// Install a single tool
InstallTool("dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=5.12.0");

// Install multiple tools
InstallTools(
    "dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=5.12.0",
    "dotnet:https://api.nuget.org/v3/index.json?package=GitReleaseManager.Tool&version=0.20.0"
);
```

### IoC Container

Register and resolve services using the IoC container:

```csharp
// Register services
static partial void RegisterServices(IServiceCollection services)
{
    services.AddSingleton<IMyService, MyService>();
}

// Resolve services in tasks
Task("MyTask")
    .Does(() => {
        var service = ServiceProvider.GetRequiredService<IMyService>();
        service.DoSomething();
    });
```

## What's Included

The Cake.Sdk automatically configures the following properties:

- `OutputType`: Exe
- `Nullable`: enable
- `ImplicitUsings`: enable
- `Optimize`: true
- `DebugType`: portable
- `DebugSymbols`: true
- `LangVersion`: latest
- `PublishAot`: false 
- `JsonSerializerIsReflectionEnabledByDefault`: true

## Requirements

- .NET 8.0 or later
- Compatible with .NET 8.0, 9.0, and 10.0 target frameworks

## Default Package References

The following packages are automatically included when using Cake.Sdk:

- [Cake.Generator](https://www.nuget.org/packages/Cake.Generator) - Source generator for Cake aliases
- [Cake.Core](https://www.nuget.org/packages/Cake.Core) - Core Cake functionality 
- [Cake.Common](https://www.nuget.org/packages/Cake.Common) - Core Common functionality
- [Cake.Cli](https://www.nuget.org/packages/Cake.Cli) - Command-line interface for Cake