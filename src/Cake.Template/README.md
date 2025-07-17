# Cake.Template

This package contains templates for creating Cake build scripts and projects using Cake.Sdk.

## Templates

### Cake SDK File-based (Requires .NET 10)
- **Short name**: `cakefile`
- **Description**: Creates a Cake build script using the file-based approach with `#:sdk Cake.Sdk` directive
- **Usage**: `dotnet new cakefile`
- **Parameters**:
  - `--name` or `-n`: The name for the generated cake.cs file. Default: folder name
  - `--IncludeExampleProject`: Include example project structure with solution, main project and test project. Default: false

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
  - `--Framework`: Target framework (net8.0, net9.0, net10.0). Default: net9.0

### Cake SDK Global.json
- **Short name**: `cakeglobaljson`
- **Description**: Creates a global.json file for Cake projects using Cake.Sdk with version placeholders
- **Usage**: `dotnet new cakeglobaljson`
- **Parameters**:
  - `--SdkVersion`: The .NET SDK version to use. Default: SDK version Cake.Template was built with
  - `--CakeSdkVersion`: The Cake.Sdk version to use. Default: current package version

#### Examples

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

Create a project-based build targeting .NET 8.0:
```bash
dotnet new cakeproj --Framework net8.0
```

Create a project-based build targeting .NET 9.0 (default):
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