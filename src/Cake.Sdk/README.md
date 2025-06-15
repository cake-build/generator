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

#### Single file based example

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

## Requirements

- .NET 8.0 or later
- Compatible with .NET 8.0, 9.0, and 10.0 target frameworks

## Default Package References

The following packages are automatically included when using Cake.Sdk:

- [Cake.Generator](https://www.nuget.org/packages/Cake.Generator) - Source generator for Cake aliases
- [Cake.Core](https://www.nuget.org/packages/Cake.Core) - Core Cake functionality 
- [Cake.Common](https://www.nuget.org/packages/Cake.Common) - Core Common functionality
- [Cake.Cli](https://www.nuget.org/packages/Cake.Cli) - Command-line interface for Cake