//HintName: CakeHelper.AddCakeToolInstaller.g.cs

using Cake.Core.Packaging;

public static partial class Program
{
    /// <summary>
    /// Gets the tool installer instance.
    /// </summary>
    public static IToolInstaller ToolInstaller { get; } = ServiceProvider.GetRequiredService<IToolInstaller>();

    /// <summary>
    /// Installs a tool using the specified package reference.
    /// </summary>
    /// <param name="tool">The package reference for the tool to install.</param>
    /// <returns>An array of file paths where the tool was installed.</returns>
    public static FilePath[] InstallTool(PackageReference tool)
        =>
            [
                .. ToolInstaller.Install(tool)
            ];

    /// <summary>
    /// Installs a tool using the specified tool string.
    /// </summary>
    /// <param name="tool">The tool string to install.</param>
    /// <returns>An array of file paths where the tool was installed.</returns>
    public static FilePath[] InstallTool(string tool)
        => InstallTool(new PackageReference(tool));

    /// <summary>
    /// Installs multiple tools using the specified package references.
    /// </summary>
    /// <param name="tools">The package references for the tools to install.</param>
    /// <returns>An array of tuples containing the package reference and installed file paths for each tool.</returns>
    public static (PackageReference Tool, FilePath[] Paths)[] InstallTools(
        params PackageReference[] tools)
        =>
            [
                .. tools
                    .Select(tool => (tool, InstallTool(tool)))
            ];

    /// <summary>
    /// Installs multiple tools using the specified tool strings.
    /// </summary>
    /// <param name="tools">The tool strings to install.</param>
    /// <returns>An array of tuples containing the package reference and installed file paths for each tool.</returns>
    public static (PackageReference Tool, FilePath[] Paths)[] InstallTools(
        params string[] tools)
        =>
            [
                .. tools
                    .Select(tool => (new PackageReference(tool), InstallTool(tool)))
            ];

    /// <summary>
    /// Interface for installing tools.
    /// </summary>
    public interface IToolInstaller
    {
        /// <summary>
        /// Installs a tool using the specified package reference.
        /// </summary>
        /// <param name="tool">The package reference for the tool to install.</param>
        /// <returns>An enumerable of file paths where the tool was installed.</returns>
        IEnumerable<FilePath> Install(PackageReference tool);
    }

    private static partial class Helper
    {
        private static IServiceCollection AddCakeToolInstaller(IServiceCollection services)
        {
            services.AddSingleton<IToolInstaller, ToolInstaller>();
            return services;
        }

        private class ToolInstaller(
                ICakeEnvironment environment,
                IToolLocator locator,
                ICakeConfiguration configuration,
                ICakeLog log,
                IEnumerable<IPackageInstaller> installers)
            : IToolInstaller
        {
            private DirectoryPath ToolPath { get; } = configuration.GetToolPath(".", environment);

            private IPackageInstaller[] Installers { get; } =
                [
                    .. installers
                ];

            public IEnumerable<FilePath> Install(PackageReference tool)
            {
                // Get the installer.
                var installer = Installers
                                    .FirstOrDefault(i => i.CanInstall(tool, PackageType.Tool))
                                    ??
                                    throw new CakeException(
                                            $"Could not find an installer for the '{tool.Scheme}' scheme.");

                // Install the tool.
                log.Debug("Installing tool '{0}'...", tool.Package);
                var result = installer.Install(tool, PackageType.Tool, ToolPath);
                if (result.Count == 0)
                {
                    throw new CakeException($"Failed to install tool '{tool.Package}'.");
                }

                // Register the tools.
                foreach (var item in result)
                {
                    locator.RegisterFile(item.Path);

                    yield return item.Path;
                }
            }
        }
    }
}
