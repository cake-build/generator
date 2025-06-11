# Cake Method / Property Alias Generator

A .NET source generator that creates proxy methods for Cake build system extensions, eliminating the need to pass `ICakeContext` explicitly.

## Overview

This source generator scans referenced assemblies for static extension methods that have:
- `System.Runtime.CompilerServices.ExtensionAttribute`
- `Cake.Core.Annotations.CakeMethodAliasAttribute` or `Cake.Core.Annotations.CakePropertyAliasAttribute`
- First parameter of type `Cake.Core.ICakeContext`

It then generates proxy methods in a partial static class named `Program` that:
- Remove the `ICakeContext` parameter
- Use a static `Context` property instead
- Preserve all other parameters, documentation, and method signatures

## Example

### Original Method
```csharp
/// <summary>
/// Writes an error message to the log using the specified format information.
/// </summary>
/// <param name="context">The context.</param>
/// <param name="format">The format.</param>
/// <param name="args">The arguments.</param>
/// <example>
/// <code>
/// Error("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now);
/// </code>
/// </example>
[CakeMethodAlias]
public static void Error(this ICakeContext context, string format, params object[] args)
```

### Generated Proxy Method
```csharp
/// <summary>
/// Writes an error message to the log using the specified format information.
/// </summary>
/// <param name="format">The format.</param>
/// <param name="args">The arguments.</param>
/// <example>
/// <code>
/// Error("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now);
/// </code>
/// </example>
public static void Error(string format, params object[] args)
    => Context.Error(format, args);
```

## Project Structure

```
Cake.Generator/
├── src/
│   ├── Cake.Generator.Core/           # Source generator implementation
│   │   ├── CakeGenerator.cs
│   │   ├── CakeGenerator.*.cs         # Partial generator classes
│   │   └── Cake.Generator.Core.csproj
│   ├── Cake.Generator/                # Meta project with default dependencies
│   │   └── Cake.Generator.csproj
│   ├── Cake.Generator.TestApp/        # Test application (used to build project)
│   │   ├── Program.cs
│   │   └── Cake.Generator.TestApp.csproj
│   ├── Cake.Generator.Core.Tests/     # Unit tests
│   │   └── Cake.Generator.Core.Tests.csproj
│   ├── Cake.Sdk/                      # .NET SDK for Cake
│   │   └── Cake.Sdk.csproj
│   ├── Cake.Template/                 # Project template for Cake
│   │   └── Cake.Template.csproj
│   └── Cake.Generator.slnx            # Solution file (slnx format)
└── README.md
```

## Usage

1. Add the Cake.Generator package to your project:
```xml
<ItemGroup>
  <PackageReference Include="Cake.Generator" Version="1.0.0" />
</ItemGroup>
```

This will automatically include:
- The source generator (Cake.Generator.Core)
- Default Cake dependencies:
  - Cake.Core
  - Cake.Cli  
  - Cake.Common
  - Microsoft.Extensions.DependencyInjection

2. Build your project - the generator will automatically create proxy methods for all discovered Cake method aliases.

The generator creates a partial static `Program` class with generated methods that use an internal `Context` property, eliminating the need to pass `ICakeContext` explicitly.

### Example `Program.cs` (Top-Level Statements)

With the generator, your `Program.cs` can be simplified significantly, leveraging top-level statements and the automatically generated alias methods:
```csharp
Task("Build")
    .Does(() => Information("Build"));

Task("Default")
    .IsDependentOn("Build");

await RunTargetAsync(target);
```

### Adding Cake Addins

Any Cake addin can be added as a `PackageReference` and its alias proxies will be generated automatically, example:

```xml
<ItemGroup>
  <PackageReference Include="Cake.Twitter" Version="5.0.0.0" />
</ItemGroup>
```

The generator will scan the addin assembly and create proxy methods for all discovered Cake method and property aliases, making them available as static methods without requiring explicit `ICakeContext` parameters.

### Module Support

The generator now supports Cake modules with automatic registration. Modules referenced in your project will have their method and property aliases automatically discovered and proxy methods generated, just like regular addins. This includes both NuGet package modules and local module assemblies, example:

```xml
<ItemGroup>
  <PackageReference Include="Cake.BuildSystems.Module" Version="7.1.0" />
</ItemGroup>
```

### Registring services to IoC

The generator creates a partial `Program` class that allows you to register your own services to the IoC container. Simply implement the `RegisterServices` partial method:

```csharp
public static partial class Program
{
    static partial void RegisterServices(IServiceCollection services)
    {
        // Register your services here
        services.AddSingleton<IMyService, MyService>();
        services.AddTransient<IAnotherService, AnotherService>();
        services.AddScoped<IScopedService, ScopedService>();
    }
}
```

### Resolving services from IoC

Services can be resolved from the IoC container using the static `ServiceProvider` property. Here's how to use it in your tasks:

```csharp
Task("MyTask")
    .Does(() => {
        // Resolve a service
        var myService = ServiceProvider.GetRequiredService<IMyService>();
        
        // Use the service
        myService.DoSomething();
        
        // You can also resolve multiple services
        var anotherService = ServiceProvider.GetRequiredService<IAnotherService>();
        anotherService.Process();
    });
```

The `ServiceProvider` is available throughout your build script, making it easy to access your registered services wherever needed.

### Available constants

The following constants are automatically generated and available in your Cake script:

| Constant                               | Description                                                                            |
|----------------------------------------|----------------------------------------------------------------------------------------|
| `CakeGeneratorDate`                    | The UTC date and time when the aliases were generated (format: `yyyy-MM-dd HH:mm:ssZ`) |
| `CakeGeneratorVersion`                 | The version of Cake.Generator.Core used to generate the aliases                        |
| `CakeGeneratorInformationalVersion`    | The full informational version of Cake.Generator.Core, including build metadata        |
| `CakeGeneratorNuGetVersion`            | The NuGet package version of Cake.Generator.Core                                       |

These constants are useful for version tracking and debugging purposes in your Cake scripts.

Here's an example of how to use these constants in your Cake script:

```csharp
Task("Version-Info")
    .Does(() =>
    {
        Information("Generated with Cake.Generator.Core version: {0}", CakeGeneratorVersion);
        Information("Generation date: {0}", CakeGeneratorDate);
    });
```

This will output the version information when you run the `Version-Info` task.

## Features

- [x] Scans all referenced assemblies for Cake method aliases
- [x] Preserves method signatures, including generics and constraints  
- [x] Handles parameter modifiers (`ref`, `out`, `in`, `params`)
- [x] Preserves default parameter values
- [x] Copies XML documentation (excluding context parameter)
- [x] Supports both `CakeMethodAlias` and `CakePropertyAlias` attributes
- [x] Supports `CakeNamespaceImport` attribute for importing global static namespaces
- [x] Supports Cake modules with automatic registration
- [x] Generates code in a partial static `Program` class with no namespace

## Building

```bash
# Build the source generator
dotnet build src/Cake.Generator.Core/Cake.Generator.Core.csproj

# Build the meta package
dotnet build src/Cake.Generator/Cake.Generator.csproj

# Build and test the complete solution
dotnet test src/Cake.Generator.slnx

# Run the test application
dotnet run --project src/Cake.Generator.TestApp/Cake.Generator.TestApp.csproj
```

## Requirements

- .NET 10 SDK
- .NET Standard 2.0+ (for the source generator)
- .NET 8.0+ (for the test application)
- Cake.Core package for ICakeContext and annotations

## License

MIT License - see LICENSE file for details. 