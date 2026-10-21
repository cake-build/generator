# Cake.Template

This package contains templates for creating Cake build scripts and projects using Cake.Sdk.

## Templates

### Minimal Cake SDK File-based (Requires .NET 10)
- **Short name**: `cakeminimalfile`
- **Description**: Creates a trivial Cake build script using the file-based approach with `#:sdk Cake.Sdk` directive
- **Usage**: `dotnet new cakeminimalfile`

### Cake SDK File-based (Requires .NET 10)
- **Short name**: `cakefile`
- **Description**: Creates a Cake build script using the file-based approach with `#:sdk Cake.Sdk` directive
- **Usage**: `dotnet new cakefile`
- **Parameters**:
  - `--name` or `-n`: The name for the generated cake.cs file. Default: folder name
  - `--IncludeExampleProject`: Include example project structure with solution, main project and xunit v3 test project on Microsoft.Testing.Platform (pair with `cakeglobaljson`, which sets the test runner). Default: false

### Cake SDK Multi-file File-based (Requires .NET 10)
- **Short name**: `cakemultifile`
- **Description**: Creates a Cake build script using the multi-file structure approach with `#:sdk Cake.Sdk` directive
- **Usage**: `dotnet new cakemultifile`
- **Parameters**:
  - `--name` or `-n`: The name for the generated cake.cs file. Default: folder name

### Cake SDK Project-based
- **Short name**: `cakeproj`
- **Description**: Creates a Cake build project using the project-based approach with Cake.Sdk
- **Usage**: `dotnet new cakeproj`
- **Parameters**:
  - `--name` or `-n`: The name for the generated project folder. Default: folder name
  - `--Framework`: Target framework (net10.0, net11.0). Default: net11.0

### Cake SDK Global.json
- **Short name**: `cakeglobaljson`
- **Description**: Creates a global.json file for Cake projects using Cake.Sdk with version placeholders
- **Usage**: `dotnet new cakeglobaljson`
- **Parameters**:
  - `--SdkVersion`: The .NET SDK version to use. Default: SDK version Cake.Template was built with
  - `--CakeSdkVersion`: The Cake.Sdk version to use. Default: current package version

### Cake SDK CI Pipeline
- **Short name**: `cakeci`
- **Description**: Creates a minimal CI pipeline that runs a Cake file-based build script
- **Usage**: `dotnet new cakeci --Provider <provider>`
- **Parameters**:
  - `--Provider`: The CI provider (required). See the table below
  - `--CakeFile`: The Cake file-based build script to run. Default: cake.cs
  - `--Framework`: Selects the .NET SDK container image (net10.0, net11.0) for container based providers. Default: net11.0
  - `--OS`: The runner OS for `github`, `azuredevops`, `appveyor` and `bitrise`, any [GitHub runner image label](https://github.com/actions/runner-images#available-images) or `matrix` (ubuntu-latest, macos-latest and windows-latest). Default: ubuntu-latest

| Provider      | File                         | .NET SDK                                                   |
|---------------|------------------------------|------------------------------------------------------------|
| `github`      | `.github/workflows/cake.yml` | global.json                                                |
| `azuredevops` | `azure-pipelines.yml`        | global.json                                                |
| `appveyor`    | `appveyor.yml`               | global.json                                                |
| `rwx`         | `.rwx/cake.yml`              | global.json                                                |
| `bitbucket`   | `bitbucket-pipelines.yml`    | `mcr.microsoft.com/dotnet/sdk:<version>-resolute-aot` image |
| `gitlab`      | `.gitlab-ci.yml`             | `mcr.microsoft.com/dotnet/sdk:<version>-resolute-aot` image |
| `woodpecker`  | `.woodpecker/cake.yml`       | `mcr.microsoft.com/dotnet/sdk:<version>-resolute-aot` image |
| `bitrise`     | `bitrise.yml`                | `mcr.microsoft.com/dotnet/sdk:<version>-resolute-aot` image, global.json on macOS |

Providers installing the .NET SDK from global.json expect one in the repository root, i.e. pair with `cakeglobaljson`.

How `--OS` maps per provider:

| Provider      | `ubuntu-*`                     | `macos-*`                                  | `windows-*`                       | `matrix`                                  |
|---------------|--------------------------------|--------------------------------------------|-----------------------------------|-------------------------------------------|
| `github`      | `runs-on` as is                | `runs-on` as is                            | `runs-on` as is                   | ubuntu-latest, macos-latest, windows-latest |
| `azuredevops` | ubuntu-24.04, ubuntu-22.04 as is, otherwise ubuntu-latest | macOS-15, macOS-14, otherwise macOS-latest | windows-2025, windows-2022 as is, otherwise windows-latest | ubuntu-latest, macOS-latest, windows-latest |
| `appveyor`    | Ubuntu2404                     | Ubuntu2404                                 | Visual Studio 2026                | Visual Studio 2026, Ubuntu2404            |
| `bitrise`     | Linux container                | macOS stack                                | Linux container                   | pipeline with Linux container and macOS workflows |

#### Examples

Create a trivial file-based build script (requires .NET 10). This example will simply print 'Hello World!' to the screen at run time. The goal of this example is to demonstrate that `dotnet` can run a cake script with the help of the Cake SDK:
```bash
dotnet new cakeminimalfile
```

Create a file-based build script (requires .NET 10):
```bash
dotnet new cakefile
```

Create a file-based build script with custom name:
```bash
dotnet new cakefile --name build
```

Create a file-based build script with example project structure:
```bash
dotnet new cakefile --IncludeExampleProject true
```

Create a file-based build script with custom name and example project structure:
```bash
dotnet new cakefile --name build --IncludeExampleProject true
```

Create a multi-file file-based build script (requires .NET 10):
```bash
dotnet new cakemultifile
```

Create a multi-file file-based build script with custom name:
```bash
dotnet new cakemultifile --name build
```

Create a project-based build targeting .NET 10.0:
```bash
dotnet new cakeproj --Framework net10.0
```

Create a project-based build targeting .NET 11.0 (default):
```bash
dotnet new cakeproj
```

Create a project-based build with custom name:
```bash
dotnet new cakeproj --name mybuild
```

Create a global.json file with default versions:
```bash
dotnet new cakeglobaljson
```

Create a global.json file with custom SDK version:
```bash
dotnet new cakeglobaljson --SdkVersion 10.0.100-preview.6.25358.103
```

Create a global.json file with custom name:
```bash
dotnet new cakeglobaljson --name myglobal
```

Create a GitHub Actions workflow running cake.cs:
```bash
dotnet new cakeci --Provider github
```

Create a GitHub Actions workflow running on Ubuntu, macOS and Windows:
```bash
dotnet new cakeci --Provider github --OS matrix
```

Create an AppVeyor pipeline running on Windows:
```bash
dotnet new cakeci --Provider appveyor --OS windows-latest
```

Create a GitLab CI/CD pipeline using the .NET 10.0 SDK container image:
```bash
dotnet new cakeci --Provider gitlab --Framework net10.0
```

Create an Azure DevOps pipeline running a custom build script:
```bash
dotnet new cakeci --Provider azuredevops --CakeFile build.cs
``` 