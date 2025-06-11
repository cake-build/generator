# Cake.Template

This package contains templates for creating Cake build scripts and projects using Cake.Sdk.

## Templates

### Cake SDK File-based
- **Short name**: `cakefile`
- **Description**: Creates a Cake build script using the file-based approach with `#:sdk Cake.Sdk` directive
- **Usage**: `dotnet new cakefile`

### Cake SDK Project-based
- **Short name**: `cakeproj`
- **Description**: Creates a Cake build project using the project-based approach with Cake.Sdk
- **Usage**: `dotnet new cakeproj`
- **Parameters**:
  - `--Framework` or `-F`: Target framework (net8.0, net9.0, net10.0). Default: net9.0

#### Examples

Create a file-based build script:
```bash
dotnet new cakefile
```

Create a project-based build targeting .NET 8.0:
```bash
dotnet new cakeproj --Framework net8.0
```

Create a project-based build targeting .NET 9.0 (default):
```bash
dotnet new cakeproj
``` 