public static partial class Program
{
    /// <summary>
    /// Executes a .NET command with the specified action to configure arguments.
    /// </summary>
    /// <param name="toolSettings">The tool settings to use.</param>
    /// <param name="action">The action to configure the command arguments.</param>
    public static void DotNet(this IToolSettings toolSettings, Func<ProcessArgumentBuilder, ProcessArgumentBuilder> action)
    {
        var dotnet = new CommandSettings
        {
            ToolName = ".NET",
            ToolExecutableNames =
                [
                    "dotnet",
                    "dotnet.exe"
                ],
            WorkingDirectory = toolSettings.WorkingDirectory,
            EnvironmentVariables =
            {
                { "NUGET_CLI_LANGUAGE", "en-US" },
                { "NUGET_RESTORE_MSBUILD_VERBOSITY", "minimal" },
                { "NUGET_PACKAGES", toolSettings.ArtifactDirectory.Combine("NuGet").Combine("Packages").FullPath },
                { "NUGET_HTTP_CACHE_PATH", toolSettings.ArtifactDirectory.Combine("NuGet").Combine("HttpCache").FullPath }
            }
        };

        var args = new ProcessArgumentBuilder();

        Command(
            dotnet,
            action(args));
    }

    /// <summary>
    /// Executes a .NET command with the specified arguments.
    /// </summary>
    /// <param name="toolSettings">The tool settings to use.</param>
    /// <param name="args">The command arguments as a string.</param>
    public static void DotNet(this IToolSettings toolSettings, string args)
         => DotNet(toolSettings, _ => args);

    /// <summary>
    /// Executes a .NET command with the specified formatted arguments.
    /// </summary>
    /// <param name="toolSettings">The tool settings to use.</param>
    /// <param name="args">The command arguments as a formatted string.</param>
    public static void DotNet(this IToolSettings toolSettings, FormattableString args)
        => DotNet(toolSettings, _ => string.Format(
                                        args.Format,
                                        args
                                            .GetArguments()
                                            .Select(value => value switch {
                                                string s when s.Contains(' ')
                                                    => s.Quote(),
                                                Cake.Core.IO.Path path
                                                    => path.FullPath.Quote(),
                                                _ => FormattableString.Invariant($"{value}")
                                            })));

    /// <summary>
    /// Executes an action with a specific verbosity level, restoring the original verbosity afterwards.
    /// </summary>
    /// <typeparam name="TData">The type of data to pass to the action.</typeparam>
    /// <param name="builder">The task builder.</param>
    /// <param name="verbosity">The verbosity level to use during execution.</param>
    /// <param name="action">The action to execute.</param>
    /// <returns>The task builder for chaining.</returns>
    public static CakeTaskBuilder Does<TData>(
        this CakeTaskBuilder builder,
        Verbosity verbosity,
        Action<ICakeContext, TData> action)
        where TData : class
    {
        return builder.Does<TData>((context, data) =>
        {
            var originalVerbosity = context.Log.Verbosity;
            try
            {
                context.Log.Verbosity = verbosity;
                action(context, data);
            }
            finally
            {
                context.Log.Verbosity = originalVerbosity;
            }
        });
    }

    /// <summary>
    /// Executes an async function with a specific verbosity level, restoring the original verbosity afterwards.
    /// </summary>
    /// <typeparam name="TData">The type of data to pass to the function.</typeparam>
    /// <param name="builder">The task builder.</param>
    /// <param name="verbosity">The verbosity level to use during execution.</param>
    /// <param name="func">The async function to execute.</param>
    /// <returns>The task builder for chaining.</returns>
    public static CakeTaskBuilder Does<TData>(
        this CakeTaskBuilder builder,
        Verbosity verbosity,
        Func<ICakeContext, TData, Task> func)
        where TData : class
    {
        return builder.Does<TData>(async (context, data) =>
        {
            var originalVerbosity = context.Log.Verbosity;
            try
            {
                context.Log.Verbosity = verbosity;
                await func(context, data);
            }
            finally
            {
                context.Log.Verbosity = originalVerbosity;
            }
        });
    }
}