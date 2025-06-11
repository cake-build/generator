namespace Cake.Generator.TestApp.Models;

/// <summary>
/// Represents settings for a tool in the build process.
/// </summary>
public interface IToolSettings
{
    /// <summary>
    /// Gets the working directory for the tool.
    /// </summary>
    DirectoryPath WorkingDirectory { get; }

    /// <summary>
    /// Gets the directory where artifacts will be stored.
    /// </summary>
    DirectoryPath ArtifactDirectory { get; }
}
