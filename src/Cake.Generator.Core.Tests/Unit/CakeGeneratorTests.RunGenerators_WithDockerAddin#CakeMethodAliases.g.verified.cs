//HintName: CakeMethodAliases.g.cs

public static partial class Program
{

    public static partial class Cake_Common
    {
        /// <member name="M:Cake.Common.ArgumentAliases.HasArgument(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Determines whether or not the specified argument exist.
        /// </summary>
        /// <param name="name">The argument name.</param>
        /// <returns>Whether or not the specified argument exist.</returns>
        /// <example>
        /// This sample shows how to call the <see cref="M:Cake.Common.ArgumentAliases.HasArgument(Cake.Core.ICakeContext,System.String)" /> method.
        /// <code>
        /// var argumentName = "myArgument";
        /// // Cake.exe .\hasargument.cake -myArgument="is specified"
        /// if (HasArgument(argumentName))
        /// {
        /// Information("{0} is specified", argumentName);
        /// }
        /// // Cake.exe .\hasargument.cake
        /// else
        /// {
        /// Warning("{0} not specified", argumentName);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static bool HasArgument(string name)
            => global::Cake.Common.ArgumentAliases.HasArgument(Context, name);

        /// <member name="M:Cake.Common.ArgumentAliases.Argument``1(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Gets an argument and throws if the argument is missing.
        /// </summary>
        /// <typeparam name="T">The argument type.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <returns>The value of the argument.</returns>
        /// <example>
        /// <code>
        /// // Cake.exe .\argument.cake --myArgument="is valid" --loopCount=5
        /// Information("Argument {0}", Argument&lt;string&gt;("myArgument"));
        /// var loopCount = Argument&lt;int&gt;("loopCount");
        /// for(var index = 0;index&lt;loopCount; index++)
        /// {
        /// Information("Index {0}", index);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="T:Cake.Core.CakeException">Argument value is null.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="context" /> is null.</exception>
        /// </member>
        public static T Argument<T>(string name)
            => global::Cake.Common.ArgumentAliases.Argument<T>(Context, name);

        /// <member name="M:Cake.Common.ArgumentAliases.Arguments``1(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Gets all arguments with the specific name and throws if the argument is missing.
        /// </summary>
        /// <typeparam name="T">The argument type.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <returns>The argument values.</returns>
        /// <example>
        /// <code>
        /// // Cake.exe .\argument.cake --foo="foo" --foo="bar"
        /// var arguments = Arguments&lt;string&gt;("foo");
        /// Information("Arguments: {0}", string.Join(", ", arguments));
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.ICollection<T> Arguments<T>(string name)
            => global::Cake.Common.ArgumentAliases.Arguments<T>(Context, name);

        /// <member name="M:Cake.Common.ArgumentAliases.Arguments``1(Cake.Core.ICakeContext,System.String,``0)">
        /// <summary>
        /// Gets all arguments with the specific name and returns the
        /// provided <paramref name="defaultValue" /> if the argument is missing.
        /// </summary>
        /// <typeparam name="T">The argument type.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="defaultValue">The value to return if the argument is missing.</param>
        /// <returns>The argument values.</returns>
        /// <example>
        /// <code>
        /// // Cake.exe .\argument.cake --foo="foo" --foo="bar"
        /// var arguments = Arguments&lt;string&gt;("foo", "default");
        /// Information("Arguments: {0}", string.Join(", ", arguments));
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.ICollection<T> Arguments<T>(string name, T defaultValue)
            => global::Cake.Common.ArgumentAliases.Arguments<T>(Context, name, defaultValue);

        /// <member name="M:Cake.Common.ArgumentAliases.Arguments``1(Cake.Core.ICakeContext,System.String,System.Collections.Generic.ICollection{``0})">
        /// <summary>
        /// Gets all arguments with the specific name and returns the
        /// provided <paramref name="defaultValues" /> if the argument is missing.
        /// </summary>
        /// <typeparam name="T">The argument type.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="defaultValues">The values to return if the argument is missing.</param>
        /// <returns>The argument values.</returns>
        /// <example>
        /// <code>
        /// // Cake.exe .\argument.cake --foo="foo" --foo="bar"
        /// var arguments = Arguments&lt;string&gt;("foo", new [] { "default" });
        /// Information("Arguments: {0}", string.Join(", ", arguments));
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.ICollection<T> Arguments<T>(string name, global::System.Collections.Generic.ICollection<T> defaultValues)
            => global::Cake.Common.ArgumentAliases.Arguments<T>(Context, name, defaultValues);

        /// <member name="M:Cake.Common.ArgumentAliases.Arguments``1(Cake.Core.ICakeContext,System.String,System.Func{Cake.Core.ICakeContext,System.Collections.Generic.ICollection{``0}})">
        /// <summary>
        /// Gets all arguments with the specific name, evaluates and returns the
        /// provided <paramref name="defaultValues" /> if the argument is missing.
        /// </summary>
        /// <typeparam name="T">The argument type.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="defaultValues">The values to return if the argument is missing.</param>
        /// <returns>The argument values.</returns>
        /// <example>
        /// <code>
        /// // Cake.exe .\argument.cake --foo="foo" --foo="bar"
        /// var arguments = Arguments&lt;string&gt;("foo", ctx =&gt; new [] { "default" });
        /// Information("Arguments: {0}", string.Join(", ", arguments));
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.ICollection<T> Arguments<T>(string name, global::System.Func<global::Cake.Core.ICakeContext, global::System.Collections.Generic.ICollection<T>> defaultValues)
            => global::Cake.Common.ArgumentAliases.Arguments<T>(Context, name, defaultValues);

        /// <member name="M:Cake.Common.ArgumentAliases.Argument``1(Cake.Core.ICakeContext,System.String,``0)">
        /// <summary>
        /// Gets an argument and returns the provided <paramref name="defaultValue" /> if the argument is missing.
        /// </summary>
        /// <typeparam name="T">The argument type.</typeparam>
        /// <param name="name">The argument name.</param>
        /// <param name="defaultValue">The value to return if the argument is missing.</param>
        /// <returns>The value of the argument if it exist; otherwise <paramref name="defaultValue" />.</returns>
        /// <example>
        /// <code>
        /// // Cake.exe .\argument.cake --myArgument="is valid" --loopCount=5
        /// Information("Argument {0}", Argument&lt;string&gt;("myArgument", "is NOT valid"));
        /// var loopCount = Argument&lt;int&gt;("loopCount", 10);
        /// for(var index = 0;index&lt;loopCount; index++)
        /// {
        /// Information("Index {0}", index);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static T Argument<T>(string name, T defaultValue)
            => global::Cake.Common.ArgumentAliases.Argument<T>(Context, name, defaultValue);

        /// <member name="M:Cake.Common.ArgumentAliases.Arguments(Cake.Core.ICakeContext)">
        /// <summary>
        /// Retrieves all command line arguments.
        /// </summary>
        /// <example>
        /// <code>
        /// var args = context.Arguments();
        /// if (args.ContainsKey("verbose"))
        /// {
        /// Information("Verbose output enabled");
        /// }
        /// foreach (var arg in args)
        /// {
        /// Information(
        /// "Key: {0}\tValue: \"{1}\"",
        /// arg.Key,
        /// string.Join(";", arg.Value)
        /// );
        /// }
        /// </code>
        /// </example>
        /// <returns>The command line arguments.</returns>
        /// </member>
        public static global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.ICollection<string>> Arguments()
            => global::Cake.Common.ArgumentAliases.Arguments(Context);

        /// <member name="M:Cake.Common.DryRunAliases.IsDryRun(Cake.Core.ICakeContext)">
        /// <summary>
        /// Determines whether or not the current script execution is a dry run.
        /// </summary>
        /// <returns>Whether or not the current script execution is a dry run.</returns>
        /// <example>
        /// <code>
        /// Setup(context =&gt;
        /// {
        /// if (!context.IsDryRun())
        /// {
        /// // Do things that you don't want to
        /// // do during a dry run.
        /// }
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static bool IsDryRun()
            => global::Cake.Common.DryRunAliases.IsDryRun(Context);

        /// <member name="M:Cake.Common.EnvironmentAliases.EnvironmentVariable(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Retrieves the value of the environment variable or <c>null</c> if the environment variable does not exist.
        /// </summary>
        /// <example>
        /// <code>
        /// Information(EnvironmentVariable("HOME") ?? "Unknown location");
        /// </code>
        /// </example>
        /// <param name="variable">The environment variable.</param>
        /// <returns>The environment variable or <c>null</c> if the environment variable does not exist.</returns>
        /// </member>
        public static string EnvironmentVariable(string variable)
            => global::Cake.Common.EnvironmentAliases.EnvironmentVariable(Context, variable);

        /// <member name="M:Cake.Common.EnvironmentAliases.EnvironmentVariable``1(Cake.Core.ICakeContext,System.String,``0)">
        /// <summary>
        /// Retrieves the value of the environment variable or <paramref name="defaultValue" /> if the environment variable does not exist.
        /// </summary>
        /// <example>
        /// <code>
        /// Information(EnvironmentVariable&lt;int&gt;("BUILD_NUMBER", 42));
        /// </code>
        /// </example>
        /// <typeparam name="T">The environment variable type.</typeparam>
        /// <param name="variable">The environment variable.</param>
        /// <param name="defaultValue">The value to return if the environment variable does not exist.</param>
        /// <returns>The environment variable or <paramref name="defaultValue" /> if the environment variable does not exist.</returns>
        /// </member>
        public static T EnvironmentVariable<T>(string variable, T defaultValue)
            => global::Cake.Common.EnvironmentAliases.EnvironmentVariable<T>(Context, variable, defaultValue);

        /// <member name="M:Cake.Common.EnvironmentAliases.EnvironmentVariables(Cake.Core.ICakeContext)">
        /// <summary>
        /// Retrieves all environment variables.
        /// </summary>
        /// <example>
        /// <code>
        /// var envVars = EnvironmentVariables();
        /// string path;
        /// if (envVars.TryGetValue("PATH", out path))
        /// {
        /// Information("Path: {0}", path);
        /// }
        /// foreach (var envVar in envVars)
        /// {
        /// Information(
        /// "Key: {0}\tValue: \"{1}\"",
        /// envVar.Key,
        /// envVar.Value
        /// );
        /// }
        /// </code>
        /// </example>
        /// <returns>The environment variables.</returns>
        /// </member>
        public static global::System.Collections.Generic.IDictionary<string, string> EnvironmentVariables()
            => global::Cake.Common.EnvironmentAliases.EnvironmentVariables(Context);

        /// <member name="M:Cake.Common.EnvironmentAliases.HasEnvironmentVariable(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Checks for the existence of a value for a given environment variable.
        /// </summary>
        /// <example>
        /// <code>
        /// if (HasEnvironmentVariable("SOME_ENVIRONMENT_VARIABLE"))
        /// {
        /// Information("The environment variable was present.");
        /// }
        /// </code>
        /// </example>
        /// <param name="variable">The environment variable.</param>
        /// <returns>
        /// <c>true</c> if the environment variable exist; otherwise <c>false</c>.
        /// </returns>
        /// </member>
        public static bool HasEnvironmentVariable(string variable)
            => global::Cake.Common.EnvironmentAliases.HasEnvironmentVariable(Context, variable);

        /// <member name="M:Cake.Common.EnvironmentAliases.IsRunningOnWindows(Cake.Core.ICakeContext)">
        /// <summary>
        /// Determines whether the build script is running on Windows.
        /// </summary>
        /// <example>
        /// <code>
        /// if (IsRunningOnWindows())
        /// {
        /// Information("Windows!");
        /// }
        /// </code>
        /// </example>
        /// <returns>
        /// <c>true</c> if the build script is running on Windows; otherwise <c>false</c>.
        /// </returns>
        /// </member>
        public static bool IsRunningOnWindows()
            => global::Cake.Common.EnvironmentAliases.IsRunningOnWindows(Context);

        /// <member name="M:Cake.Common.EnvironmentAliases.IsRunningOnUnix(Cake.Core.ICakeContext)">
        /// <summary>
        /// Determines whether the build script running on a Unix or Linux based system.
        /// </summary>
        /// <example>
        /// <code>
        /// if (IsRunningOnUnix())
        /// {
        /// Information("Not Windows!");
        /// }
        /// </code>
        /// </example>
        /// <returns>
        /// <c>true</c> if the build script running on a Unix or Linux based system; otherwise <c>false</c>.
        /// </returns>
        /// </member>
        public static bool IsRunningOnUnix()
            => global::Cake.Common.EnvironmentAliases.IsRunningOnUnix(Context);

        /// <member name="M:Cake.Common.EnvironmentAliases.IsRunningOnMacOs(Cake.Core.ICakeContext)">
        /// <summary>
        /// Determines whether the build script running on a macOS based system.
        /// </summary>
        /// <example>
        /// <code>
        /// if (IsRunningOnMacOs())
        /// {
        /// Information("macOS!");
        /// }
        /// </code>
        /// </example>
        /// <returns>
        /// <c>true</c> if the build script running on a macOS based system; otherwise <c>false</c>.
        /// </returns>
        /// </member>
        public static bool IsRunningOnMacOs()
            => global::Cake.Common.EnvironmentAliases.IsRunningOnMacOs(Context);

        /// <member name="M:Cake.Common.EnvironmentAliases.IsRunningOnFreeBSD(Cake.Core.ICakeContext)">
        /// <summary>
        /// Determines whether the build script running on a FreeBSD based system.
        /// </summary>
        /// <example>
        /// <code>
        /// if (IsRunningOnFreeBSD())
        /// {
        /// Information("FreeBSD!");
        /// }
        /// </code>
        /// </example>
        /// <returns>
        /// <c>true</c> if the build script running on a FreeBSD based system; otherwise <c>false</c>.
        /// </returns>
        /// </member>
        public static bool IsRunningOnFreeBSD()
            => global::Cake.Common.EnvironmentAliases.IsRunningOnFreeBSD(Context);

        /// <member name="M:Cake.Common.EnvironmentAliases.IsRunningOnLinux(Cake.Core.ICakeContext)">
        /// <summary>
        /// Determines whether the build script running on a Linux based system.
        /// </summary>
        /// <example>
        /// <code>
        /// if (IsRunningOnLinux())
        /// {
        /// Information("Linux!");
        /// }
        /// </code>
        /// </example>
        /// <returns>
        /// <c>true</c> if the build script running on a Linux based system; otherwise <c>false</c>.
        /// </returns>
        /// </member>
        public static bool IsRunningOnLinux()
            => global::Cake.Common.EnvironmentAliases.IsRunningOnLinux(Context);

        /// <member name="M:Cake.Common.ProcessAliases.StartProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Starts the process resource that is specified by the filename.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>The exit code that the started process specified when it terminated.</returns>
        /// <example>
        /// <code>
        /// var exitCodeWithoutArguments = StartProcess("ping");
        /// // This should output 1 as argument is missing
        /// Information("Exit code: {0}", exitCodeWithoutArguments);
        /// </code>
        /// </example>
        /// </member>
        public static int StartProcess(global::Cake.Core.IO.FilePath fileName)
            => global::Cake.Common.ProcessAliases.StartProcess(Context, fileName);

        /// <member name="M:Cake.Common.ProcessAliases.StartProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String)">
        /// <summary>
        /// Starts the process resource that is specified by the filename and arguments.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="processArguments">The arguments used in the process settings.</param>
        /// <returns>The exit code that the started process specified when it terminated.</returns>
        /// <example>
        /// <code>
        /// var exitCodeWithArgument = StartProcess("ping", "localhost");
        /// // This should output 0 as valid arguments supplied
        /// Information("Exit code: {0}", exitCodeWithArgument);
        /// </code>
        /// </example>
        /// </member>
        public static int StartProcess(global::Cake.Core.IO.FilePath fileName, string processArguments)
            => global::Cake.Common.ProcessAliases.StartProcess(Context, fileName, processArguments);

        /// <member name="M:Cake.Common.ProcessAliases.StartProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.ProcessSettings)">
        /// <summary>
        /// Starts the process resource that is specified by the filename and settings.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The exit code that the started process specified when it terminated.</returns>
        /// <example>
        /// <code>
        /// var exitCodeWithArgument = StartProcess("ping", new ProcessSettings{ Arguments = "localhost" });
        /// // This should output 0 as valid arguments supplied
        /// Information("Exit code: {0}", exitCodeWithArgument);
        /// </code>
        /// </example>
        /// </member>
        public static int StartProcess(global::Cake.Core.IO.FilePath fileName, global::Cake.Core.IO.ProcessSettings settings)
            => global::Cake.Common.ProcessAliases.StartProcess(Context, fileName, settings);

        /// <member name="M:Cake.Common.ProcessAliases.StartProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.ProcessSettings,System.Collections.Generic.IEnumerable{System.String}@)">
        /// <summary>
        /// Starts the process resource that is specified by the filename and settings.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="redirectedStandardOutput">Returns process output if <see cref="P:Cake.Core.IO.ProcessSettings.RedirectStandardOutput" /> is true.
        /// Otherwise <c>null</c> is returned.</param>
        /// <returns>The exit code that the started process specified when it terminated.</returns>
        /// <example>
        /// <code>
        /// IEnumerable&lt;string&gt; redirectedStandardOutput;
        /// var exitCodeWithArgument =
        /// StartProcess(
        /// "ping",
        /// new ProcessSettings {
        /// Arguments = "localhost",
        /// RedirectStandardOutput = true
        /// },
        /// out redirectedStandardOutput
        /// );
        /// // Output last line of process output.
        /// Information("Last line of output: {0}", redirectedStandardOutput.LastOrDefault());
        /// // This should output 0 as valid arguments supplied
        /// Information("Exit code: {0}", exitCodeWithArgument);
        /// </code>
        /// </example>
        /// </member>
        public static int StartProcess(global::Cake.Core.IO.FilePath fileName, global::Cake.Core.IO.ProcessSettings settings, out global::System.Collections.Generic.IEnumerable<string> redirectedStandardOutput)
            => global::Cake.Common.ProcessAliases.StartProcess(Context, fileName, settings, out redirectedStandardOutput);

        /// <member name="M:Cake.Common.ProcessAliases.StartProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.ProcessSettings,System.Collections.Generic.IEnumerable{System.String}@,System.Collections.Generic.IEnumerable{System.String}@)">
        /// <summary>
        /// Starts the process resource that is specified by the filename and settings.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="redirectedStandardOutput">Returns process output if <see cref="P:Cake.Core.IO.ProcessSettings.RedirectStandardOutput" /> is true.
        /// Otherwise <c>null</c> is returned.</param>
        /// <param name="redirectedErrorOutput">Returns process error output if <see cref="P:Cake.Core.IO.ProcessSettings.RedirectStandardError" /> is true.
        /// Otherwise <c>null</c> is returned.</param>
        /// <returns>The exit code that the started process specified when it terminated.</returns>
        /// <example>
        /// <code>
        /// IEnumerable&lt;string&gt; redirectedStandardOutput;
        /// IEnumerable&lt;string&gt; redirectedErrorOutput;
        /// var exitCodeWithArgument =
        /// StartProcess(
        /// "ping",
        /// new ProcessSettings {
        /// Arguments = "localhost",
        /// RedirectStandardOutput = true,
        /// RedirectStandardError = true
        /// },
        /// out redirectedStandardOutput,
        /// out redirectedErrorOutput
        /// );
        /// // Output last line of process output.
        /// Information("Last line of output: {0}", redirectedStandardOutput.LastOrDefault());
        /// // Throw exception if anything was written to the standard error.
        /// if (redirectedErrorOutput.Any())
        /// {
        /// throw new Exception(
        /// string.Format(
        /// "Errors occurred: {0}",
        /// string.Join(", ", redirectedErrorOutput)));
        /// }
        /// // This should output 0 as valid arguments supplied
        /// Information("Exit code: {0}", exitCodeWithArgument);
        /// </code>
        /// </example>
        /// </member>
        public static int StartProcess(global::Cake.Core.IO.FilePath fileName, global::Cake.Core.IO.ProcessSettings settings, out global::System.Collections.Generic.IEnumerable<string> redirectedStandardOutput, out global::System.Collections.Generic.IEnumerable<string> redirectedErrorOutput)
            => global::Cake.Common.ProcessAliases.StartProcess(Context, fileName, settings, out redirectedStandardOutput, out redirectedErrorOutput);

        /// <member name="M:Cake.Common.ProcessAliases.StartAndReturnProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.ProcessSettings)">
        /// <summary>
        /// Starts the process resource that is specified by the filename and settings.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The newly started process.</returns>
        /// <example>
        /// <code>
        /// using (var process = StartAndReturnProcess("ping", new ProcessSettings{ Arguments = "localhost" }))
        /// {
        /// process.WaitForExit();
        /// // This should output 0 as valid arguments supplied
        /// Information("Exit code: {0}", process.GetExitCode());
        /// }
        /// </code>
        /// </example>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="context" />, <paramref name="fileName" />, or <paramref name="settings" />  is null.</exception>
        /// </member>
        public static global::Cake.Core.IO.IProcess StartAndReturnProcess(global::Cake.Core.IO.FilePath fileName, global::Cake.Core.IO.ProcessSettings settings)
            => global::Cake.Common.ProcessAliases.StartAndReturnProcess(Context, fileName, settings);

        /// <member name="M:Cake.Common.ProcessAliases.StartAndReturnProcess(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Starts the process resource that is specified by the filename.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>The newly started process.</returns>
        /// <example>
        /// <code>
        /// using (var process = StartAndReturnProcess("ping"))
        /// {
        /// process.WaitForExit();
        /// // This should output 0 as valid arguments supplied
        /// Information("Exit code: {0}", process.GetExitCode());
        /// }
        /// </code>
        /// </example>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="context" />, <paramref name="fileName" /> is null.</exception>
        /// </member>
        public static global::Cake.Core.IO.IProcess StartAndReturnProcess(global::Cake.Core.IO.FilePath fileName)
            => global::Cake.Common.ProcessAliases.StartAndReturnProcess(Context, fileName);

        /// <member name="M:Cake.Common.ReleaseNotesAliases.ParseAllReleaseNotes(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Parses all release notes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>All release notes.</returns>
        /// <example>
        /// <code>
        /// var releaseNotes = ParseAllReleaseNotes("./ReleaseNotes.md");
        /// foreach (var releaseNote in releaseNotes)
        /// {
        /// Information("Version: {0}", releaseNote.Version);
        /// foreach (var note in releaseNote.Notes)
        /// {
        /// Information("\t{0}", note);
        /// }
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IReadOnlyList<global::Cake.Common.ReleaseNotes> ParseAllReleaseNotes(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.ReleaseNotesAliases.ParseAllReleaseNotes(Context, filePath);

        /// <member name="M:Cake.Common.ReleaseNotesAliases.ParseReleaseNotes(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Parses the latest release notes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The latest release notes.</returns>
        /// <example>
        /// <code>
        /// var releaseNote = ParseReleaseNotes("./ReleaseNotes.md");
        /// Information("Version: {0}", releaseNote.Version);
        /// foreach (var note in releaseNote.Notes)
        /// {
        /// Information("\t{0}", note);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.ReleaseNotes ParseReleaseNotes(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.ReleaseNotesAliases.ParseReleaseNotes(Context, filePath);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Error(Cake.Core.ICakeContext,System.String,System.Object[])">
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
        /// </member>
        public static void Error(string format, params object[] args)
            => global::Cake.Common.Diagnostics.LoggingAliases.Error(Context, format, args);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Error(Cake.Core.ICakeContext,Cake.Core.Diagnostics.LogAction)">
        /// <summary>
        /// Writes an error message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="logAction">The function called for message when logging.</param>
        /// <example>
        /// <code>
        /// Error(logAction=&gt;logAction("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now));
        /// </code>
        /// </example>
        /// </member>
        public static void Error(global::Cake.Core.Diagnostics.LogAction logAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Error(Context, logAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Error(Cake.Core.ICakeContext,System.Object)">
        /// <summary>
        /// Writes an error message to the log using the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Error(new {FirstName = "John", LastName="Doe"});
        /// </code>
        /// </example>
        /// </member>
        public static void Error(object value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Error(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Error(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Writes an error message to the log using the specified string value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Error("{string}");
        /// </code>
        /// </example>
        /// </member>
        public static void Error(string value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Error(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Warning(Cake.Core.ICakeContext,System.String,System.Object[])">
        /// <summary>
        /// Writes a warning message to the log using the specified format information.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <example>
        /// <code>
        /// Warning("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now);
        /// </code>
        /// </example>
        /// </member>
        public static void Warning(string format, params object[] args)
            => global::Cake.Common.Diagnostics.LoggingAliases.Warning(Context, format, args);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Warning(Cake.Core.ICakeContext,Cake.Core.Diagnostics.LogAction)">
        /// <summary>
        /// Writes a warning message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="logAction">The function called for message when logging.</param>
        /// <example>
        /// <code>
        /// Warning(logAction=&gt;logAction("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now));
        /// </code>
        /// </example>
        /// </member>
        public static void Warning(global::Cake.Core.Diagnostics.LogAction logAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Warning(Context, logAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Warning(Cake.Core.ICakeContext,System.Object)">
        /// <summary>
        /// Writes an warning message to the log using the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Warning(new {FirstName = "John", LastName="Doe"});
        /// </code>
        /// </example>
        /// </member>
        public static void Warning(object value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Warning(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Warning(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Writes an warning message to the log using the specified string value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Warning("{string}");
        /// </code>
        /// </example>
        /// </member>
        public static void Warning(string value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Warning(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Information(Cake.Core.ICakeContext,System.String,System.Object[])">
        /// <summary>
        /// Writes an informational message to the log using the specified format information.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <example>
        /// <code>
        /// Information("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now);
        /// </code>
        /// </example>
        /// </member>
        public static void Information(string format, params object[] args)
            => global::Cake.Common.Diagnostics.LoggingAliases.Information(Context, format, args);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Information(Cake.Core.ICakeContext,Cake.Core.Diagnostics.LogAction)">
        /// <summary>
        /// Writes an informational message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="logAction">The function called for message when logging.</param>
        /// <example>
        /// <code>
        /// Information(logAction=&gt;logAction("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now));
        /// </code>
        /// </example>
        /// </member>
        public static void Information(global::Cake.Core.Diagnostics.LogAction logAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Information(Context, logAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Information(Cake.Core.ICakeContext,System.Object)">
        /// <summary>
        /// Writes an informational message to the log using the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Information(new {FirstName = "John", LastName="Doe"});
        /// </code>
        /// </example>
        /// </member>
        public static void Information(object value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Information(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Information(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Writes an informational message to the log using the specified string value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Information("{string}");
        /// </code>
        /// </example>
        /// </member>
        public static void Information(string value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Information(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Verbose(Cake.Core.ICakeContext,System.String,System.Object[])">
        /// <summary>
        /// Writes a verbose message to the log using the specified format information.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <example>
        /// <code>
        /// Verbose("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now);
        /// </code>
        /// </example>
        /// </member>
        public static void Verbose(string format, params object[] args)
            => global::Cake.Common.Diagnostics.LoggingAliases.Verbose(Context, format, args);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Verbose(Cake.Core.ICakeContext,Cake.Core.Diagnostics.LogAction)">
        /// <summary>
        /// Writes a verbose message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="logAction">The function called for message when logging.</param>
        /// <example>
        /// <code>
        /// Verbose(logAction=&gt;logAction("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now));
        /// </code>
        /// </example>
        /// </member>
        public static void Verbose(global::Cake.Core.Diagnostics.LogAction logAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Verbose(Context, logAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Verbose(Cake.Core.ICakeContext,System.Object)">
        /// <summary>
        /// Writes a verbose message to the log using the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Verbose(new {FirstName = "John", LastName="Doe"});
        /// </code>
        /// </example>
        /// </member>
        public static void Verbose(object value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Verbose(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Verbose(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Writes a verbose message to the log using the specified string value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Verbose("{string}");
        /// </code>
        /// </example>
        /// </member>
        public static void Verbose(string value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Verbose(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Debug(Cake.Core.ICakeContext,System.String,System.Object[])">
        /// <summary>
        /// Writes a debug message to the log using the specified format information.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <example>
        /// <code>
        /// Debug("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now);
        /// </code>
        /// </example>
        /// </member>
        public static void Debug(string format, params object[] args)
            => global::Cake.Common.Diagnostics.LoggingAliases.Debug(Context, format, args);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Debug(Cake.Core.ICakeContext,Cake.Core.Diagnostics.LogAction)">
        /// <summary>
        /// Writes a debug message to the log using the specified log message action.
        /// Evaluation message only if verbosity same or more verbose.
        /// </summary>
        /// <param name="logAction">The function called for message when logging.</param>
        /// <example>
        /// <code>
        /// Debug(logAction=&gt;logAction("Hello {0}! Today is an {1:dddd}", "World", DateTime.Now));
        /// </code>
        /// </example>
        /// </member>
        public static void Debug(global::Cake.Core.Diagnostics.LogAction logAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Debug(Context, logAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Debug(Cake.Core.ICakeContext,System.Object)">
        /// <summary>
        /// Writes a debug message to the log using the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Debug(new {FirstName = "John", LastName="Doe"});
        /// </code>
        /// </example>
        /// </member>
        public static void Debug(object value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Debug(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Debug(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Writes a debug message to the log using the specified string value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code>
        /// Debug("{string}");
        /// </code>
        /// </example>
        /// </member>
        public static void Debug(string value)
            => global::Cake.Common.Diagnostics.LoggingAliases.Debug(Context, value);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.QuietVerbosity(Cake.Core.ICakeContext)">
        /// <summary>
        /// Sets the log verbosity to quiet and returns a disposable that restores the log verbosity on dispose.
        /// </summary>
        /// <returns>A disposable that restores the log verbosity.</returns>
        /// <example>
        /// <code>
        /// using (QuietVerbosity())
        /// {
        /// Error("Show me.");
        /// Warning("Hide me.");
        /// Information("Hide me.");
        /// Verbose("Hide me.");
        /// Debug("Hide me.");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.IDisposable QuietVerbosity()
            => global::Cake.Common.Diagnostics.LoggingAliases.QuietVerbosity(Context);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.MinimalVerbosity(Cake.Core.ICakeContext)">
        /// <summary>
        /// Sets the log verbosity to minimal and returns a disposable that restores the log verbosity on dispose.
        /// </summary>
        /// <returns>A disposable that restores the log verbosity.</returns>
        /// <example>
        /// <code>
        /// using (MinimalVerbosity())
        /// {
        /// Error("Show me.");
        /// Warning("Show me.");
        /// Information("Hide me.");
        /// Verbose("Hide me.");
        /// Debug("Hide me.");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.IDisposable MinimalVerbosity()
            => global::Cake.Common.Diagnostics.LoggingAliases.MinimalVerbosity(Context);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.NormalVerbosity(Cake.Core.ICakeContext)">
        /// <summary>
        /// Sets the log verbosity to normal and returns a disposable that restores the log verbosity on dispose.
        /// </summary>
        /// <returns>A disposable that restores the log verbosity.</returns>
        /// <example>
        /// <code>
        /// using (NormalVerbosity())
        /// {
        /// Error("Show me.");
        /// Warning("Show me.");
        /// Information("Show me.");
        /// Verbose("Hide me.");
        /// Debug("Hide me.");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.IDisposable NormalVerbosity()
            => global::Cake.Common.Diagnostics.LoggingAliases.NormalVerbosity(Context);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.VerboseVerbosity(Cake.Core.ICakeContext)">
        /// <summary>
        /// Sets the log verbosity to verbose and returns a disposable that restores the log verbosity on dispose.
        /// </summary>
        /// <returns>A disposable that restores the log verbosity.</returns>
        /// <example>
        /// <code>
        /// using (VerboseVerbosity())
        /// {
        /// Error("Show me.");
        /// Warning("Show me.");
        /// Information("Show me.");
        /// Verbose("Show me.");
        /// Debug("Hide me.");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.IDisposable VerboseVerbosity()
            => global::Cake.Common.Diagnostics.LoggingAliases.VerboseVerbosity(Context);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.DiagnosticVerbosity(Cake.Core.ICakeContext)">
        /// <summary>
        /// Sets the log verbosity to diagnostic and returns a disposable that restores the log verbosity on dispose.
        /// </summary>
        /// <returns>A disposable that restores the log verbosity.</returns>
        /// <example>
        /// <code>
        /// using (DiagnosticVerbosity())
        /// {
        /// Error("Show me.");
        /// Warning("Show me.");
        /// Information("Show me.");
        /// Verbose("Show me.");
        /// Debug("Show me.");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.IDisposable DiagnosticVerbosity()
            => global::Cake.Common.Diagnostics.LoggingAliases.DiagnosticVerbosity(Context);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.WithVerbosity(Cake.Core.ICakeContext,Cake.Core.Diagnostics.Verbosity)">
        /// <summary>
        /// Sets the log verbosity as specified and returns a disposable that restores the log verbosity on dispose.
        /// </summary>
        /// <param name="verbosity">The verbosity.</param>
        /// <returns>A disposable that restores the log verbosity.</returns>
        /// <example>
        /// <code>
        /// using (DiagnosticVerbosity())
        /// {
        /// Error("Show me.");
        /// Warning("Show me.");
        /// Information("Show me.");
        /// Verbose("Show me.");
        /// Debug("Show me.");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.IDisposable WithVerbosity(global::Cake.Core.Diagnostics.Verbosity verbosity)
            => global::Cake.Common.Diagnostics.LoggingAliases.WithVerbosity(Context, verbosity);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Error(Cake.Core.ICakeContext,System.FormattableString)">
        /// <summary>
        /// Writes an error message to the log using the specified format information.
        /// </summary>
        /// <param name="formattable">The string to be formatted.</param>
        /// <example>
        /// <code>
        /// Error($"Hello {"World"}! Today is an {DateTime.Now:dddd}");
        /// </code>
        /// </example>
        /// </member>
        public static void Error(global::System.FormattableString formattable)
            => global::Cake.Common.Diagnostics.LoggingAliases.Error(Context, formattable);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Warning(Cake.Core.ICakeContext,System.FormattableString)">
        /// <summary>
        /// Writes an warning message to the log using the specified format information.
        /// </summary>
        /// <param name="formattable">The string to be formatted.</param>
        /// <example>
        /// <code>
        /// Warning($"Hello {"World"}! Today is an {DateTime.Now:dddd}");
        /// </code>
        /// </example>
        /// </member>
        public static void Warning(global::System.FormattableString formattable)
            => global::Cake.Common.Diagnostics.LoggingAliases.Warning(Context, formattable);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Information(Cake.Core.ICakeContext,System.FormattableString)">
        /// <summary>
        /// Writes an informational message to the log using the specified formattable string.
        /// </summary>
        /// <param name="formattable">The string to be formatted.</param>
        /// <example>
        /// <code>
        /// Information($"Hello {"World"}! Today is an {DateTime.Now:dddd}");
        /// </code>
        /// </example>
        /// </member>
        public static void Information(global::System.FormattableString formattable)
            => global::Cake.Common.Diagnostics.LoggingAliases.Information(Context, formattable);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Verbose(Cake.Core.ICakeContext,System.FormattableString)">
        /// <summary>
        /// Writes an verbose message to the log using the specified formattable string.
        /// </summary>
        /// <param name="formattable">The string to be formatted.</param>
        /// <example>
        /// <code>
        /// Verbose($"Hello {"World"}! Today is an {DateTime.Now:dddd}");
        /// </code>
        /// </example>
        /// </member>
        public static void Verbose(global::System.FormattableString formattable)
            => global::Cake.Common.Diagnostics.LoggingAliases.Verbose(Context, formattable);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Debug(Cake.Core.ICakeContext,System.FormattableString)">
        /// <summary>
        /// Writes an debug message to the log using the specified formattable string.
        /// </summary>
        /// <param name="formattable">The string to be formatted.</param>
        /// <example>
        /// <code>
        /// Debug($"Hello {"World"}! Today is an {DateTime.Now:dddd}");
        /// </code>
        /// </example>
        /// </member>
        public static void Debug(global::System.FormattableString formattable)
            => global::Cake.Common.Diagnostics.LoggingAliases.Debug(Context, formattable);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Error(Cake.Core.ICakeContext,Cake.Core.Diagnostics.FormattableLogAction)">
        /// <summary>
        /// Writes an error message to the log using the specified format information.
        /// </summary>
        /// <param name="formattableLogAction">The log action.</param>
        /// <example>
        /// <code>
        /// Error(logAction =&gt; logAction($"Hello {"World"}! Today is an {DateTime.Now:dddd}"));
        /// </code>
        /// </example>
        /// </member>
        public static void Error(global::Cake.Core.Diagnostics.FormattableLogAction formattableLogAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Error(Context, formattableLogAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Warning(Cake.Core.ICakeContext,Cake.Core.Diagnostics.FormattableLogAction)">
        /// <summary>
        /// Writes an warning message to the log using the specified format information.
        /// </summary>
        /// <param name="formattableLogAction">The log action.</param>
        /// <example>
        /// <code>
        /// Warning(logAction =&gt; logAction($"Hello {"World"}! Today is an {DateTime.Now:dddd}"));
        /// </code>
        /// </example>
        /// </member>
        public static void Warning(global::Cake.Core.Diagnostics.FormattableLogAction formattableLogAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Warning(Context, formattableLogAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Information(Cake.Core.ICakeContext,Cake.Core.Diagnostics.FormattableLogAction)">
        /// <summary>
        /// Writes an informational message to the log using the specified formattable string.
        /// </summary>
        /// <param name="formattableLogAction">The log action.</param>
        /// <example>
        /// <code>
        /// Information(logAction =&gt; logAction($"Hello {"World"}! Today is an {DateTime.Now:dddd}"));
        /// </code>
        /// </example>
        /// </member>
        public static void Information(global::Cake.Core.Diagnostics.FormattableLogAction formattableLogAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Information(Context, formattableLogAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Verbose(Cake.Core.ICakeContext,Cake.Core.Diagnostics.FormattableLogAction)">
        /// <summary>
        /// Writes an verbose message to the log using the specified formattable string.
        /// </summary>
        /// <param name="formattableLogAction">The log action.</param>
        /// <example>
        /// <code>
        /// Verbose(logAction =&gt; logAction($"Hello {"World"}! Today is an {DateTime.Now:dddd}"));
        /// </code>
        /// </example>
        /// </member>
        public static void Verbose(global::Cake.Core.Diagnostics.FormattableLogAction formattableLogAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Verbose(Context, formattableLogAction);

        /// <member name="M:Cake.Common.Diagnostics.LoggingAliases.Debug(Cake.Core.ICakeContext,Cake.Core.Diagnostics.FormattableLogAction)">
        /// <summary>
        /// Writes an debug message to the log using the specified formattable string.
        /// </summary>
        /// <param name="formattableLogAction">The log action.</param>
        /// <example>
        /// <code>
        /// Debug(logAction =&gt; logAction($"Hello {"World"}! Today is an {DateTime.Now:dddd}"));
        /// </code>
        /// </example>
        /// </member>
        public static void Debug(global::Cake.Core.Diagnostics.FormattableLogAction formattableLogAction)
            => global::Cake.Common.Diagnostics.LoggingAliases.Debug(Context, formattableLogAction);

        /// <member name="M:Cake.Common.Diagnostics.ScriptCallerAliases.GetCallerInfo(Cake.Core.ICakeContext,System.String,System.String,System.Int32)">
        /// <summary>
        /// Performs script caller information.
        /// </summary>
        /// <param name="memberName">The member name.</param>
        /// <param name="sourceFilePath">The source file path.</param>
        /// <param name="sourceLineNumber">The source line number.</param>
        /// <returns>A <see cref="M:Cake.Common.Diagnostics.ScriptCallerAliases.GetCallerInfo(Cake.Core.ICakeContext,System.String,System.String,System.Int32)" /> instance representing the caller information.</returns>
        /// </member>
        public static global::Cake.Common.Diagnostics.ScriptCallerInfo GetCallerInfo(string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
            => global::Cake.Common.Diagnostics.ScriptCallerAliases.GetCallerInfo(Context, memberName, sourceFilePath, sourceLineNumber);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.Directory(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Gets a directory path from string.
        /// </summary>
        /// <example>
        /// <code>
        /// // Get the temp directory.
        /// var root = Directory("./");
        /// var temp = root + Directory("temp");
        /// // Clean the directory.
        /// CleanDirectory(temp);
        /// </code>
        /// </example>
        /// <param name="path">The path.</param>
        /// <returns>A directory path.</returns>
        /// </member>
        public static global::Cake.Common.IO.Paths.ConvertableDirectoryPath Directory(string path)
            => global::Cake.Common.IO.DirectoryAliases.Directory(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.DeleteDirectories(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.DirectoryPath},Cake.Common.IO.DeleteDirectorySettings)">
        /// <summary>
        /// Deletes the specified directories.
        /// </summary>
        /// <example>
        /// <code>
        /// var directoriesToDelete = new DirectoryPath[]{
        /// Directory("be"),
        /// Directory("gone")
        /// };
        /// DeleteDirectories(directoriesToDelete, new DeleteDirectorySettings {
        /// Recursive = true,
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="directories">The directory paths.</param>
        /// <param name="settings">The delete settings.</param>
        /// </member>
        public static void DeleteDirectories(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.DirectoryPath> directories, global::Cake.Common.IO.DeleteDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.DeleteDirectories(Context, directories, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.DeleteDirectories(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.IO.DeleteDirectorySettings)">
        /// <summary>
        /// Deletes the specified directories.
        /// </summary>
        /// <example>
        /// <code>
        /// var directoriesToDelete = new []{
        /// "be",
        /// "gone"
        /// };
        /// DeleteDirectories(directoriesToDelete, new DeleteDirectorySettings {
        /// Recursive = true,
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="directories">The directory paths.</param>
        /// <param name="settings">The delete settings.</param>
        /// </member>
        public static void DeleteDirectories(global::System.Collections.Generic.IEnumerable<string> directories, global::Cake.Common.IO.DeleteDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.DeleteDirectories(Context, directories, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.DeleteDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Common.IO.DeleteDirectorySettings)">
        /// <summary>
        /// Deletes the specified directory.
        /// </summary>
        /// <example>
        /// <code>
        /// DeleteDirectory("./be/gone", new DeleteDirectorySettings {
        /// Recursive = true,
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// <param name="settings">The delete settings.</param>
        /// </member>
        public static void DeleteDirectory(global::Cake.Core.IO.DirectoryPath path, global::Cake.Common.IO.DeleteDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.DeleteDirectory(Context, path, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Cleans the directories matching the specified pattern.
        /// Cleaning the directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// CleanDirectories("./src/**/bin/debug");
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern to match.</param>
        /// </member>
        public static void CleanDirectories(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, pattern);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.IO.CleanDirectorySettings)">
        /// <summary>
        /// Cleans the directories matching the specified pattern.
        /// Cleaning the directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// CleanDirectories("./src/**/bin/debug", new CleanDirectorySettings() { Force = true });
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern to match.</param>
        /// <param name="settings">The clean settings.</param>
        /// </member>
        public static void CleanDirectories(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.IO.CleanDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, pattern, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,System.Func{Cake.Core.IO.IFileSystemInfo,System.Boolean})">
        /// <summary>
        /// Cleans the directories matching the specified pattern.
        /// Cleaning the directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// Func&lt;IFileSystemInfo, bool&gt; exclude_node_modules =
        /// fileSystemInfo=&gt;!fileSystemInfo.Path.FullPath.EndsWith(
        /// "node_modules",
        /// StringComparison.OrdinalIgnoreCase);
        /// CleanDirectories("./src/**/bin/debug", exclude_node_modules);
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern to match.</param>
        /// <param name="predicate">The predicate used to filter directories based on file system information.</param>
        /// </member>
        public static void CleanDirectories(global::Cake.Core.IO.GlobPattern pattern, global::System.Func<global::Cake.Core.IO.IFileSystemInfo, bool> predicate)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, pattern, predicate);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,System.Func{Cake.Core.IO.IFileSystemInfo,System.Boolean},Cake.Common.IO.CleanDirectorySettings)">
        /// <summary>
        /// Cleans the directories matching the specified pattern.
        /// Cleaning the directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// Func&lt;IFileSystemInfo, bool&gt; exclude_node_modules =
        /// fileSystemInfo=&gt;!fileSystemInfo.Path.FullPath.EndsWith(
        /// "node_modules",
        /// StringComparison.OrdinalIgnoreCase);
        /// CleanDirectories("./src/**/bin/debug", exclude_node_modules, new CleanDirectorySettings() { Force = true });
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern to match.</param>
        /// <param name="predicate">The predicate used to filter directories based on file system information.</param>
        /// <param name="settings">The clean settings.</param>
        /// </member>
        public static void CleanDirectories(global::Cake.Core.IO.GlobPattern pattern, global::System.Func<global::Cake.Core.IO.IFileSystemInfo, bool> predicate, global::Cake.Common.IO.CleanDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, pattern, predicate, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.DirectoryPath})">
        /// <summary>
        /// Cleans the specified directories.
        /// Cleaning a directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// var directoriesToClean = GetDirectories("./src/**/bin/");
        /// CleanDirectories(directoriesToClean);
        /// </code>
        /// </example>
        /// <param name="directories">The directory paths.</param>
        /// </member>
        public static void CleanDirectories(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.DirectoryPath> directories)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, directories);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.DirectoryPath},Cake.Common.IO.CleanDirectorySettings)">
        /// <summary>
        /// Cleans the specified directories.
        /// Cleaning a directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// var directoriesToClean = GetDirectories("./src/**/bin/");
        /// CleanDirectories(directoriesToClean, new CleanDirectorySettings() { Force = true });
        /// </code>
        /// </example>
        /// <param name="directories">The directory paths.</param>
        /// <param name="settings">The clean settings.</param>
        /// </member>
        public static void CleanDirectories(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.DirectoryPath> directories, global::Cake.Common.IO.CleanDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, directories, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Cleans the specified directories.
        /// Cleaning a directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// var directoriesToClean = new []{
        /// "./src/Cake/obj",
        /// "./src/Cake.Common/obj"
        /// };
        /// CleanDirectories(directoriesToClean);
        /// </code>
        /// </example>
        /// <param name="directories">The directory paths.</param>
        /// </member>
        public static void CleanDirectories(global::System.Collections.Generic.IEnumerable<string> directories)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, directories);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectories(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.IO.CleanDirectorySettings)">
        /// <summary>
        /// Cleans the specified directories.
        /// Cleaning a directory will remove all its content but not the directory itself.
        /// </summary>
        /// <example>
        /// <code>
        /// var directoriesToClean = new []{
        /// "./src/Cake/obj",
        /// "./src/Cake.Common/obj"
        /// };
        /// CleanDirectories(directoriesToClean, new CleanDirectorySettings() { Force = true });
        /// </code>
        /// </example>
        /// <param name="directories">The directory paths.</param>
        /// <param name="settings">The clean settings.</param>
        /// </member>
        public static void CleanDirectories(global::System.Collections.Generic.IEnumerable<string> directories, global::Cake.Common.IO.CleanDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectories(Context, directories, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Cleans the specified directory.
        /// </summary>
        /// <example>
        /// <code>
        /// CleanDirectory("./src/Cake.Common/obj");
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// </member>
        public static void CleanDirectory(global::Cake.Core.IO.DirectoryPath path)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectory(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Common.IO.CleanDirectorySettings)">
        /// <summary>
        /// Cleans the specified directory.
        /// </summary>
        /// <example>
        /// <code>
        /// CleanDirectory("./src/Cake.Common/obj", new CleanDirectorySettings {
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// <param name="settings">The clean settings.</param>
        /// </member>
        public static void CleanDirectory(global::Cake.Core.IO.DirectoryPath path, global::Cake.Common.IO.CleanDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectory(Context, path, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,System.Func{Cake.Core.IO.IFileSystemInfo,System.Boolean})">
        /// <summary>
        /// Cleans the specified directory.
        /// </summary>
        /// <example>
        /// <code>
        /// CleanDirectory("./src/Cake.Common/obj", fileSystemInfo=&gt;!fileSystemInfo.Hidden);
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// <param name="predicate">Predicate used to determine which files/directories should get deleted.</param>
        /// </member>
        public static void CleanDirectory(global::Cake.Core.IO.DirectoryPath path, global::System.Func<global::Cake.Core.IO.IFileSystemInfo, bool> predicate)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectory(Context, path, predicate);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CleanDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,System.Func{Cake.Core.IO.IFileSystemInfo,System.Boolean},Cake.Common.IO.CleanDirectorySettings)">
        /// <summary>
        /// Cleans the specified directory.
        /// </summary>
        /// <example>
        /// <code>
        /// CleanDirectory("./src/Cake.Common/obj", fileSystemInfo=&gt;!fileSystemInfo.Hidden, new CleanDirectorySettings {
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// <param name="predicate">Predicate used to determine which files/directories should get deleted.</param>
        /// <param name="settings">The clean settings.</param>
        /// </member>
        public static void CleanDirectory(global::Cake.Core.IO.DirectoryPath path, global::System.Func<global::Cake.Core.IO.IFileSystemInfo, bool> predicate, global::Cake.Common.IO.CleanDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.CleanDirectory(Context, path, predicate, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CreateDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Creates the specified directory.
        /// </summary>
        /// <example>
        /// <code>
        /// CreateDirectory("publish");
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// </member>
        public static void CreateDirectory(global::Cake.Core.IO.DirectoryPath path)
            => global::Cake.Common.IO.DirectoryAliases.CreateDirectory(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.EnsureDirectoryExists(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Creates the specified directory if it does not exist.
        /// </summary>
        /// <example>
        /// <code>
        /// EnsureDirectoryExists("publish");
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// </member>
        public static void EnsureDirectoryExists(global::Cake.Core.IO.DirectoryPath path)
            => global::Cake.Common.IO.DirectoryAliases.EnsureDirectoryExists(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.EnsureDirectoryDoesNotExist(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Deletes the specified directory and its contents if it exists.
        /// </summary>
        /// <example>
        /// <code>
        /// EnsureDirectoryDoesNotExist("./be/gone");
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// </member>
        public static void EnsureDirectoryDoesNotExist(global::Cake.Core.IO.DirectoryPath path)
            => global::Cake.Common.IO.DirectoryAliases.EnsureDirectoryDoesNotExist(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.EnsureDirectoryDoesNotExist(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Common.IO.DeleteDirectorySettings)">
        /// <summary>
        /// Deletes the specified directory if it exists.
        /// </summary>
        /// <example>
        /// <code>
        /// EnsureDirectoryDoesNotExist("./be/gone", new DeleteDirectorySettings {
        /// Recursive = true,
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// <param name="settings">The delete settings.</param>
        /// </member>
        public static void EnsureDirectoryDoesNotExist(global::Cake.Core.IO.DirectoryPath path, global::Cake.Common.IO.DeleteDirectorySettings settings)
            => global::Cake.Common.IO.DirectoryAliases.EnsureDirectoryDoesNotExist(Context, path, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.EnsureDirectoryDoesNotExist(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Common.IO.EnsureDirectoryDoesNotExistSettings)">
        /// <summary>
        /// Deletes the specified directory if it exists.
        /// </summary>
        /// <example>
        /// <code>
        /// EnsureDirectoryDoesNotExist("./be/gone", new EnsureDirectoryDoesNotExistSettings {
        /// Recursive = true,
        /// Force = true
        /// });
        /// </code>
        /// </example>
        /// <param name="path">The directory path.</param>
        /// <param name="settings">The delete settings.</param>
        /// </member>
        public static void EnsureDirectoryDoesNotExist(global::Cake.Core.IO.DirectoryPath path, global::Cake.Common.IO.EnsureDirectoryDoesNotExistSettings settings)
            => global::Cake.Common.IO.DirectoryAliases.EnsureDirectoryDoesNotExist(Context, path, settings);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.CopyDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Copies the contents of a directory, including subdirectories to the specified location.
        /// </summary>
        /// <example>
        /// <code>
        /// CopyDirectory("source_path", "destination_path");
        /// </code>
        /// </example>
        /// <param name="source">The source directory path.</param>
        /// <param name="destination">The destination directory path.</param>
        /// </member>
        public static void CopyDirectory(global::Cake.Core.IO.DirectoryPath source, global::Cake.Core.IO.DirectoryPath destination)
            => global::Cake.Common.IO.DirectoryAliases.CopyDirectory(Context, source, destination);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.DirectoryExists(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Determines whether the given path refers to an existing directory.
        /// </summary>
        /// <example>
        /// <code>
        /// var dir = "publish";
        /// if (!DirectoryExists(dir))
        /// {
        /// CreateDirectory(dir);
        /// }
        /// </code>
        /// </example>
        /// <param name="path">The <see cref="T:Cake.Core.IO.DirectoryPath" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="path" /> refers to an existing directory;
        /// <c>false</c> if the directory does not exist or an error occurs when trying to
        /// determine if the specified path exists.</returns>
        /// </member>
        public static bool DirectoryExists(global::Cake.Core.IO.DirectoryPath path)
            => global::Cake.Common.IO.DirectoryAliases.DirectoryExists(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.MakeAbsolute(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Makes the path absolute (if relative) using the current working directory.
        /// </summary>
        /// <example>
        /// <code>
        /// var path = MakeAbsolute(Directory("./resources"));
        /// </code>
        /// </example>
        /// <param name="path">The path.</param>
        /// <returns>An absolute directory path.</returns>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPath MakeAbsolute(global::Cake.Core.IO.DirectoryPath path)
            => global::Cake.Common.IO.DirectoryAliases.MakeAbsolute(Context, path);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.MakeRelative(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Makes the directory path relative (if absolute) to a specified root directory. If no root directory is defined
        /// the current working directory is used as default root.
        /// </summary>
        /// <example>
        /// <code>
        /// var path = MakeRelative(Directory("C:\Cake\Tests\Integration"));
        /// </code>
        /// </example>
        /// <param name="path">The path.</param>
        /// <param name="rootPath">The root path.</param>
        /// <returns>A relative directory path.</returns>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPath MakeRelative(global::Cake.Core.IO.DirectoryPath path, global::Cake.Core.IO.DirectoryPath? rootPath = null)
            => global::Cake.Common.IO.DirectoryAliases.MakeRelative(Context, path, rootPath);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.MakeRelative(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Makes the file path relative (if absolute) to a specified root directory. If no root directory is defined
        /// the current working directory is used as default root.
        /// </summary>
        /// <example>
        /// <code>
        /// var path = MakeRelative(Directory("C:\Cake\Tests\Integration\file.cake"));
        /// </code>
        /// </example>
        /// <param name="path">The path.</param>
        /// <param name="rootPath">The root path.</param>
        /// <returns>A relative file path.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePath MakeRelative(global::Cake.Core.IO.FilePath path, global::Cake.Core.IO.DirectoryPath? rootPath = null)
            => global::Cake.Common.IO.DirectoryAliases.MakeRelative(Context, path, rootPath);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.MoveDirectory(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Moves an existing directory to a new location, providing the option to specify a new directory name.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// MoveDirectory("mydir", "newparent/newdir");
        /// </code>
        /// </example>
        /// </member>
        public static void MoveDirectory(global::Cake.Core.IO.DirectoryPath directoryPath, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.DirectoryAliases.MoveDirectory(Context, directoryPath, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.GetSubDirectories(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Gets a list of all the directories inside a directory.
        /// </summary>
        /// <example>
        /// <code>
        /// var directories = GetSubDirectories("some/dir");
        /// </code>
        /// </example>
        /// <param name="directoryPath">The directory path.</param>
        /// <returns>An absolute directory path.</returns>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection GetSubDirectories(global::Cake.Core.IO.DirectoryPath directoryPath)
            => global::Cake.Common.IO.DirectoryAliases.GetSubDirectories(Context, directoryPath);

        /// <member name="M:Cake.Common.IO.DirectoryAliases.ExpandEnvironmentVariables(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Expands all environment variables in the provided <see cref="T:Cake.Core.IO.DirectoryPath" />.
        /// </summary>
        /// <example>
        /// <code>
        /// var path = new DirectoryPath("%APPDATA%/foo");
        /// var expanded = path.ExpandEnvironmentVariables(environment);
        /// </code>
        /// </example>
        /// <param name="directoryPath">The path.</param>
        /// <returns>A new <see cref="T:Cake.Core.IO.DirectoryPath" /> with each environment variable replaced by its value.</returns>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPath ExpandEnvironmentVariables(global::Cake.Core.IO.DirectoryPath directoryPath)
            => global::Cake.Common.IO.DirectoryAliases.ExpandEnvironmentVariables(Context, directoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.File(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Gets a file path from string.
        /// </summary>
        /// <example>
        /// <code>
        /// // Get the temp file.
        /// var root = Directory("./");
        /// var temp = root + File("temp");
        /// // Delete the file.
        /// CleanDirectory(temp);
        /// </code>
        /// </example>
        /// <param name="path">The path.</param>
        /// <returns>A file path.</returns>
        /// </member>
        public static global::Cake.Common.IO.Paths.ConvertableFilePath File(string path)
            => global::Cake.Common.IO.FileAliases.File(Context, path);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFileToDirectory(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Copies an existing file to a new location.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// CopyFileToDirectory("test.txt", "./targetdir");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFileToDirectory(global::Cake.Core.IO.FilePath filePath, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.CopyFileToDirectory(Context, filePath, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFile(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Copies an existing file to a new file, providing the option to specify a new file name.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="targetFilePath">The target file path.</param>
        /// <example>
        /// <code>
        /// CopyFile("test.tmp", "test.txt");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFile(global::Cake.Core.IO.FilePath filePath, global::Cake.Core.IO.FilePath targetFilePath)
            => global::Cake.Common.IO.FileAliases.CopyFile(Context, filePath, targetFilePath);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFiles(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Copies all files matching the provided pattern to a new location.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// CopyFiles("Cake.*", "./publish");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFiles(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.CopyFiles(Context, pattern, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFiles(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Copies existing files to a new location.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// var files = GetFiles("./**/Cake.*");
        /// CopyFiles(files, "destination");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFiles(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.CopyFiles(Context, filePaths, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFiles(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Copies existing files to a new location.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// CreateDirectory("destination");
        /// var files = new [] {
        /// "Cake.exe",
        /// "Cake.pdb"
        /// };
        /// CopyFiles(files, "destination");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFiles(global::System.Collections.Generic.IEnumerable<string> filePaths, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.CopyFiles(Context, filePaths, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFiles(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.DirectoryPath,System.Boolean)">
        /// <summary>
        /// Copies all files matching the provided pattern to a new location.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <param name="preserveFolderStructure">Keep the folder structure.</param>
        /// <example>
        /// <code>
        /// CopyFiles("Cake.*", "./publish");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFiles(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.DirectoryPath targetDirectoryPath, bool preserveFolderStructure)
            => global::Cake.Common.IO.FileAliases.CopyFiles(Context, pattern, targetDirectoryPath, preserveFolderStructure);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFiles(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.DirectoryPath,System.Boolean)">
        /// <summary>
        /// Copies existing files to a new location.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <param name="preserveFolderStructure">Keep the folder structure.</param>
        /// <example>
        /// <code>
        /// var files = GetFiles("./**/Cake.*");
        /// CopyFiles(files, "destination");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFiles(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths, global::Cake.Core.IO.DirectoryPath targetDirectoryPath, bool preserveFolderStructure)
            => global::Cake.Common.IO.FileAliases.CopyFiles(Context, filePaths, targetDirectoryPath, preserveFolderStructure);

        /// <member name="M:Cake.Common.IO.FileAliases.CopyFiles(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Core.IO.DirectoryPath,System.Boolean)">
        /// <summary>
        /// Copies existing files to a new location.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <param name="preserveFolderStructure">Keep the folder structure.</param>
        /// <example>
        /// <code>
        /// CreateDirectory("destination");
        /// var files = new [] {
        /// "Cake.exe",
        /// "Cake.pdb"
        /// };
        /// CopyFiles(files, "destination");
        /// </code>
        /// </example>
        /// </member>
        public static void CopyFiles(global::System.Collections.Generic.IEnumerable<string> filePaths, global::Cake.Core.IO.DirectoryPath targetDirectoryPath, bool preserveFolderStructure)
            => global::Cake.Common.IO.FileAliases.CopyFiles(Context, filePaths, targetDirectoryPath, preserveFolderStructure);

        /// <member name="M:Cake.Common.IO.FileAliases.MoveFileToDirectory(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Moves an existing file to a new location.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// MoveFileToDirectory("test.txt", "./targetdir");
        /// </code>
        /// </example>
        /// </member>
        public static void MoveFileToDirectory(global::Cake.Core.IO.FilePath filePath, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.MoveFileToDirectory(Context, filePath, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.MoveFiles(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Moves existing files matching the specified pattern to a new location.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// MoveFiles("./publish/Cake.*", "./destination");
        /// </code>
        /// </example>
        /// </member>
        public static void MoveFiles(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.MoveFiles(Context, pattern, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.MoveFiles(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Moves existing files to a new location.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        /// <param name="targetDirectoryPath">The target directory path.</param>
        /// <example>
        /// <code>
        /// var files = GetFiles("./publish/Cake.*");
        /// MoveFiles(files, "destination");
        /// </code>
        /// </example>
        /// </member>
        public static void MoveFiles(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths, global::Cake.Core.IO.DirectoryPath targetDirectoryPath)
            => global::Cake.Common.IO.FileAliases.MoveFiles(Context, filePaths, targetDirectoryPath);

        /// <member name="M:Cake.Common.IO.FileAliases.MoveFile(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Moves an existing file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="targetFilePath">The target file path.</param>
        /// <example>
        /// <code>
        /// MoveFile("test.tmp", "test.txt");
        /// </code>
        /// </example>
        /// </member>
        public static void MoveFile(global::Cake.Core.IO.FilePath filePath, global::Cake.Core.IO.FilePath targetFilePath)
            => global::Cake.Common.IO.FileAliases.MoveFile(Context, filePath, targetFilePath);

        /// <member name="M:Cake.Common.IO.FileAliases.DeleteFiles(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Deletes the specified files.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// DeleteFiles("./publish/Cake.*");
        /// </code>
        /// </example>
        /// </member>
        public static void DeleteFiles(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.IO.FileAliases.DeleteFiles(Context, pattern);

        /// <member name="M:Cake.Common.IO.FileAliases.DeleteFiles(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Deletes the specified files.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        /// <example>
        /// <code>
        /// var files = GetFiles("./destination/Cake.*");
        /// DeleteFiles(files);
        /// </code>
        /// </example>
        /// </member>
        public static void DeleteFiles(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths)
            => global::Cake.Common.IO.FileAliases.DeleteFiles(Context, filePaths);

        /// <member name="M:Cake.Common.IO.FileAliases.DeleteFile(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <example>
        /// <code>
        /// DeleteFile("deleteme.txt");
        /// </code>
        /// </example>
        /// </member>
        public static void DeleteFile(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.IO.FileAliases.DeleteFile(Context, filePath);

        /// <member name="M:Cake.Common.IO.FileAliases.FileExists(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Determines whether the given path refers to an existing file.
        /// </summary>
        /// <param name="filePath">The <see cref="T:Cake.Core.IO.FilePath" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="filePath" /> refers to an existing file;
        /// <c>false</c> if the file does not exist or an error occurs when trying to
        /// determine if the specified file exists.</returns>
        /// <example>
        /// <code>
        /// if (FileExists("findme.txt"))
        /// {
        /// Information("File exists!");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static bool FileExists(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.IO.FileAliases.FileExists(Context, filePath);

        /// <member name="M:Cake.Common.IO.FileAliases.MakeAbsolute(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Makes the path absolute (if relative) using the current working directory.
        /// </summary>
        /// <param name="filePath">The path.</param>
        /// <returns>An absolute file path.</returns>
        /// <example>
        /// <code>
        /// var path = MakeAbsolute(File("./resources"));
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.FilePath MakeAbsolute(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.IO.FileAliases.MakeAbsolute(Context, filePath);

        /// <member name="M:Cake.Common.IO.FileAliases.FileSize(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Gets the size of a file in bytes.
        /// </summary>
        /// <param name="filePath">The path.</param>
        /// <returns>Size of file in bytes or -1 if file doesn't exist.</returns>
        /// <example>
        /// <code>
        /// Information("File size: {0}", FileSize("./build.cake"));
        /// </code>
        /// </example>
        /// </member>
        public static long FileSize(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.IO.FileAliases.FileSize(Context, filePath);

        /// <member name="M:Cake.Common.IO.FileAliases.ExpandEnvironmentVariables(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Expands all environment variables in the provided <see cref="T:Cake.Core.IO.FilePath" />.
        /// </summary>
        /// <example>
        /// <code>
        /// var path = new FilePath("%APPDATA%/foo.bar");
        /// var expanded = path.ExpandEnvironmentVariables(environment);
        /// </code>
        /// </example>
        /// <param name="filePath">The path.</param>
        /// <returns>A new <see cref="T:Cake.Core.IO.FilePath" /> with each environment variable replaced by its value.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePath ExpandEnvironmentVariables(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.IO.FileAliases.ExpandEnvironmentVariables(Context, filePath);

        /// <member name="M:Cake.Common.IO.GlobbingAliases.GetFiles(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Gets all files matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// var files = GetFiles("./**/Cake.*.dll");
        /// foreach (var file in files)
        /// {
        /// Information("File: {0}", file);
        /// }
        /// </code>
        /// </example>
        /// <param name="pattern">The glob pattern to match.</param>
        /// <returns>A <see cref="T:Cake.Core.IO.FilePathCollection" />.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePathCollection GetFiles(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.IO.GlobbingAliases.GetFiles(Context, pattern);

        /// <member name="M:Cake.Common.IO.GlobbingAliases.GetFiles(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.GlobberSettings)">
        /// <summary>
        /// Gets all files matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// Func&lt;IFileSystemInfo, bool&gt; exclude_node_modules =
        /// fileSystemInfo =&gt; !fileSystemInfo.Path.FullPath.EndsWith(
        /// "node_modules", StringComparison.OrdinalIgnoreCase);
        /// var files = GetFiles("./**/Cake.*.dll", new GlobberSettings { Predicate = exclude_node_modules });
        /// foreach (var file in files)
        /// {
        /// Information("File: {0}", file);
        /// }
        /// </code>
        /// </example>
        /// <param name="pattern">The glob pattern to match.</param>
        /// <param name="settings">The globber settings.</param>
        /// <returns>A <see cref="T:Cake.Core.IO.FilePathCollection" />.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePathCollection GetFiles(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.GlobberSettings settings)
            => global::Cake.Common.IO.GlobbingAliases.GetFiles(Context, pattern, settings);

        /// <member name="M:Cake.Common.IO.GlobbingAliases.GetDirectories(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Gets all directories matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// var directories = GetDirectories("./src/**/obj/*");
        /// foreach (var directory in directories)
        /// {
        /// Information("Directory: {0}", directory);
        /// }
        /// </code>
        /// </example>
        /// <param name="pattern">The glob pattern to match.</param>
        /// <returns>A <see cref="T:Cake.Core.IO.DirectoryPathCollection" />.</returns>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection GetDirectories(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.IO.GlobbingAliases.GetDirectories(Context, pattern);

        /// <member name="M:Cake.Common.IO.GlobbingAliases.GetDirectories(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.GlobberSettings)">
        /// <summary>
        /// Gets all directories matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// Func&lt;IFileSystemInfo, bool&gt; exclude_node_modules =
        /// fileSystemInfo =&gt; !fileSystemInfo.Path.FullPath.EndsWith(
        /// "node_modules", StringComparison.OrdinalIgnoreCase);
        /// var directories = GetDirectories("./src/**/obj/*", new GlobberSettings { Predicate = exclude_node_modules });
        /// foreach (var directory in directories)
        /// {
        /// Information("Directory: {0}", directory);
        /// }
        /// </code>
        /// </example>
        /// <param name="pattern">The glob pattern to match.</param>
        /// <param name="settings">The globber settings.</param>
        /// <returns>A <see cref="T:Cake.Core.IO.DirectoryPathCollection" />.</returns>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection GetDirectories(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.GlobberSettings settings)
            => global::Cake.Common.IO.GlobbingAliases.GetDirectories(Context, pattern, settings);

        /// <member name="M:Cake.Common.IO.GlobbingAliases.GetPaths(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Gets all paths matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// var paths = GetPaths("./src/**/obj/*");
        /// foreach (var path in paths)
        /// {
        /// Information("Path: {0}", path);
        /// }
        /// </code>
        /// </example>
        /// <param name="pattern">The glob pattern to match.</param>
        /// <returns>A <see cref="T:Cake.Core.IO.PathCollection" />.</returns>
        /// </member>
        public static global::Cake.Core.IO.PathCollection GetPaths(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.IO.GlobbingAliases.GetPaths(Context, pattern);

        /// <member name="M:Cake.Common.IO.GlobbingAliases.GetPaths(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.GlobberSettings)">
        /// <summary>
        /// Gets all paths matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// Func&lt;IFileSystemInfo, bool&gt; exclude_node_modules =
        /// fileSystemInfo =&gt; !fileSystemInfo.Path.FullPath.EndsWith(
        /// "node_modules", StringComparison.OrdinalIgnoreCase);
        /// var paths = GetPaths("./src/**/obj/*", new GlobberSettings { Predicate = exclude_node_modules });
        /// foreach (var path in paths)
        /// {
        /// Information("Path: {0}", path);
        /// }
        /// </code>
        /// </example>
        /// <param name="pattern">The glob pattern to match.</param>
        /// <param name="settings">The globber settings.</param>
        /// <returns>A <see cref="T:Cake.Core.IO.PathCollection" />.</returns>
        /// </member>
        public static global::Cake.Core.IO.PathCollection GetPaths(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.GlobberSettings settings)
            => global::Cake.Common.IO.GlobbingAliases.GetPaths(Context, pattern, settings);

        /// <member name="M:Cake.Common.IO.ZipAliases.Zip(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Zips the specified directory.
        /// </summary>
        /// <param name="rootPath">The root path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <example>
        /// <code>
        /// Zip("./publish", "publish.zip");
        /// </code>
        /// </example>
        /// </member>
        public static void Zip(global::Cake.Core.IO.DirectoryPath rootPath, global::Cake.Core.IO.FilePath outputPath)
            => global::Cake.Common.IO.ZipAliases.Zip(Context, rootPath, outputPath);

        /// <member name="M:Cake.Common.IO.ZipAliases.Zip(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.FilePath,System.String)">
        /// <summary>
        /// Zips the files matching the specified pattern.
        /// </summary>
        /// <param name="rootPath">The root path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// Zip("./", "XmlFiles.zip", "./*.xml");
        /// </code>
        /// </example>
        /// </member>
        public static void Zip(global::Cake.Core.IO.DirectoryPath rootPath, global::Cake.Core.IO.FilePath outputPath, string pattern)
            => global::Cake.Common.IO.ZipAliases.Zip(Context, rootPath, outputPath, pattern);

        /// <member name="M:Cake.Common.IO.ZipAliases.Zip(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Zips the specified files.
        /// </summary>
        /// <param name="rootPath">The root path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="filePaths">The file paths.</param>
        /// <example>
        /// <code>
        /// var files = GetFiles("./**/Cake.*.dll");
        /// Zip("./", "CakeAssemblies.zip", files);
        /// </code>
        /// </example>
        /// </member>
        public static void Zip(global::Cake.Core.IO.DirectoryPath rootPath, global::Cake.Core.IO.FilePath outputPath, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths)
            => global::Cake.Common.IO.ZipAliases.Zip(Context, rootPath, outputPath, filePaths);

        /// <member name="M:Cake.Common.IO.ZipAliases.Zip(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Zips the specified files.
        /// </summary>
        /// <param name="rootPath">The root path.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="filePaths">The file paths.</param>
        /// <example>
        /// <code>
        /// var files = new [] {
        /// "./src/Cake/bin/Debug/Autofac.dll",
        /// "./src/Cake/bin/Debug/Cake.Common.dll",
        /// "./src/Cake/bin/Debug/Cake.Core.dll",
        /// "./src/Cake/bin/Debug/Cake.exe"
        /// };
        /// Zip("./", "CakeBinaries.zip", files);
        /// </code>
        /// </example>
        /// </member>
        public static void Zip(global::Cake.Core.IO.DirectoryPath rootPath, global::Cake.Core.IO.FilePath outputPath, global::System.Collections.Generic.IEnumerable<string> filePaths)
            => global::Cake.Common.IO.ZipAliases.Zip(Context, rootPath, outputPath, filePaths);

        /// <member name="M:Cake.Common.IO.ZipAliases.Unzip(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Unzips the specified file.
        /// </summary>
        /// <param name="zipFile">Zip file to unzip.</param>
        /// <param name="outputPath">Output path to unzip into.</param>
        /// <example>
        /// <code>
        /// Unzip("Cake.zip", "./cake");
        /// </code>
        /// </example>
        /// </member>
        public static void Unzip(global::Cake.Core.IO.FilePath zipFile, global::Cake.Core.IO.DirectoryPath outputPath)
            => global::Cake.Common.IO.ZipAliases.Unzip(Context, zipFile, outputPath);

        /// <member name="M:Cake.Common.IO.ZipAliases.Unzip(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath,System.Boolean)">
        /// <summary>
        /// Unzips the specified file.
        /// </summary>
        /// <param name="zipFile">Zip file to unzip.</param>
        /// <param name="outputPath">Output path to unzip into.</param>
        /// <param name="overwriteFiles">Flag for if files should be overwritten in output.</param>
        /// <example>
        /// <code>
        /// Unzip("Cake.zip", "./cake", true);
        /// </code>
        /// </example>
        /// </member>
        public static void Unzip(global::Cake.Core.IO.FilePath zipFile, global::Cake.Core.IO.DirectoryPath outputPath, bool overwriteFiles)
            => global::Cake.Common.IO.ZipAliases.Unzip(Context, zipFile, outputPath, overwriteFiles);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Downloads the specified resource over HTTP to a temporary file.
        /// </summary>
        /// <example>
        /// <code>
        /// var resource = DownloadFile("http://www.example.org/index.html");
        /// </code>
        /// </example>
        /// <param name="address">The URL of the resource to download.</param>
        /// <returns>The path to the downloaded file.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePath DownloadFile(string address)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.String,Cake.Common.Net.DownloadFileSettings)">
        /// <summary>
        /// Downloads the specified resource over HTTP to a temporary file with specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var resource = DownloadFile("http://www.example.org/index.html", new DownloadFileSettings()
        /// {
        /// Username = "bob",
        /// Password = "builder"
        /// });
        /// </code>
        /// </example>
        /// <param name="address">The URL of the resource to download.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The path to the downloaded file.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePath DownloadFile(string address, global::Cake.Common.Net.DownloadFileSettings settings)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address, settings);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.Uri)">
        /// <summary>
        /// Downloads the specified resource over HTTP to a temporary file.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = new Uri("http://www.example.org/index.html");
        /// var resource = DownloadFile(address);
        /// </code>
        /// </example>
        /// <param name="address">The URL of file to download.</param>
        /// <returns>The path to the downloaded file.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePath DownloadFile(global::System.Uri address)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.Uri,Cake.Common.Net.DownloadFileSettings)">
        /// <summary>
        /// Downloads the specified resource over HTTP to a temporary file with specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = new Uri("http://www.example.org/index.html");
        /// var resource = DownloadFile(address, new DownloadFileSettings()
        /// {
        /// Username = "bob",
        /// Password = "builder"
        /// });
        /// </code>
        /// </example>
        /// <param name="address">The URL of file to download.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The path to the downloaded file.</returns>
        /// </member>
        public static global::Cake.Core.IO.FilePath DownloadFile(global::System.Uri address, global::Cake.Common.Net.DownloadFileSettings settings)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address, settings);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.String,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Downloads the specified resource over HTTP to the specified output path.
        /// </summary>
        /// <example>
        /// <code>
        /// var outputPath = File("./index.html");
        /// DownloadFile("http://www.example.org/index.html", outputPath);
        /// </code>
        /// </example>
        /// <param name="address">The URL of the resource to download.</param>
        /// <param name="outputPath">The output path.</param>
        /// </member>
        public static void DownloadFile(string address, global::Cake.Core.IO.FilePath outputPath)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address, outputPath);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.String,Cake.Core.IO.FilePath,Cake.Common.Net.DownloadFileSettings)">
        /// <summary>
        /// Downloads the specified resource over HTTP to the specified output path and settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var outputPath = File("./index.html");
        /// DownloadFile("http://www.example.org/index.html", outputPath, new DownloadFileSettings()
        /// {
        /// Username = "bob",
        /// Password = "builder"
        /// });
        /// </code>
        /// </example>
        /// <param name="address">The URL of the resource to download.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DownloadFile(string address, global::Cake.Core.IO.FilePath outputPath, global::Cake.Common.Net.DownloadFileSettings settings)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address, outputPath, settings);

        /// <member name="M:Cake.Common.Net.HttpAliases.DownloadFile(Cake.Core.ICakeContext,System.Uri,Cake.Core.IO.FilePath,Cake.Common.Net.DownloadFileSettings)">
        /// <summary>
        /// Downloads the specified resource over HTTP to the specified output path.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = new Uri("http://www.example.org/index.html");
        /// var outputPath = File("./index.html");
        /// DownloadFile(address, outputPath, new DownloadFileSettings()
        /// {
        /// Username = "bob",
        /// Password = "builder"
        /// });
        /// </code>
        /// </example>
        /// <param name="address">The URL of the resource to download.</param>
        /// <param name="outputPath">The output path.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DownloadFile(global::System.Uri address, global::Cake.Core.IO.FilePath outputPath, global::Cake.Common.Net.DownloadFileSettings settings)
            => global::Cake.Common.Net.HttpAliases.DownloadFile(Context, address, outputPath, settings);

        /// <member name="M:Cake.Common.Net.HttpAliases.UploadFile(Cake.Core.ICakeContext,System.Uri,Cake.Core.IO.FilePath,Cake.Common.Net.UploadFileSettings)">
        /// <summary>
        /// Uploads the specified file via a HTTP POST to the specified uri using multipart/form-data.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = new Uri("http://www.example.org/upload");
        /// UploadFile(address, @"path/to/file.txt", new UploadFileSettings()
        /// {
        /// Username = "bob",
        /// Password = "builder"
        /// }
        /// </code>
        /// </example>
        /// <param name="address">The URL of the upload resource.</param>
        /// <param name="filePath">The file to upload.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void UploadFile(global::System.Uri address, global::Cake.Core.IO.FilePath filePath, global::Cake.Common.Net.UploadFileSettings settings)
            => global::Cake.Common.Net.HttpAliases.UploadFile(Context, address, filePath, settings);

        /// <member name="M:Cake.Common.Net.HttpAliases.UploadFile(Cake.Core.ICakeContext,System.String,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Uploads the specified file via a HTTP POST to the specified uri using multipart/form-data.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = "http://www.example.org/upload";
        /// UploadFile(address, @"path/to/file.txt");
        /// </code>
        /// </example>
        /// <param name="address">The URL of the upload resource.</param>
        /// <param name="filePath">The file to upload.</param>
        /// </member>
        public static void UploadFile(string address, global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.Net.HttpAliases.UploadFile(Context, address, filePath);

        /// <member name="M:Cake.Common.Net.HttpAliases.UploadFile(Cake.Core.ICakeContext,System.Uri,System.Byte[],System.String,Cake.Common.Net.UploadFileSettings)">
        /// <summary>
        /// Uploads the specified byte array via a HTTP POST to the specified uri using multipart/form-data.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = new Uri("http://www.example.org/upload");
        /// UploadFile(address, @"path/to/file.txt", new UploadFileSettings() {
        /// Username = "bob",
        /// Password = "builder"
        /// });
        /// </code>
        /// </example>
        /// <param name="address">The URL of the upload resource.</param>
        /// <param name="data">The data to upload.</param>
        /// <param name="fileName">The filename to give the uploaded data.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void UploadFile(global::System.Uri address, byte[] data, string fileName, global::Cake.Common.Net.UploadFileSettings settings)
            => global::Cake.Common.Net.HttpAliases.UploadFile(Context, address, data, fileName, settings);

        /// <member name="M:Cake.Common.Net.HttpAliases.UploadFile(Cake.Core.ICakeContext,System.String,System.Byte[],System.String)">
        /// <summary>
        /// Uploads the specified byte array via a HTTP POST to the specified uri using multipart/form-data.
        /// </summary>
        /// <example>
        /// <code>
        /// var address = "http://www.example.org/upload";
        /// UploadFile(address, @"path/to/file.txt");
        /// </code>
        /// </example>
        /// <param name="address">The URL of the upload resource.</param>
        /// <param name="data">The data to upload.</param>
        /// <param name="fileName">The filename to give the uploaded data.</param>
        /// </member>
        public static void UploadFile(string address, byte[] data, string fileName)
            => global::Cake.Common.Net.HttpAliases.UploadFile(Context, address, data, fileName);

        /// <member name="M:Cake.Common.Security.SecurityAliases.CalculateFileHash(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Calculates the hash for a given file using the default (SHA256) algorithm.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>A <see cref="T:Cake.Common.Security.FileHash" /> instance representing the calculated hash.</returns>
        /// <example>
        /// <code>
        /// Information(
        /// "Cake executable file SHA256 hash: {0}",
        /// CalculateFileHash("Cake.exe").ToHex());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Security.FileHash CalculateFileHash(global::Cake.Core.IO.FilePath filePath)
            => global::Cake.Common.Security.SecurityAliases.CalculateFileHash(Context, filePath);

        /// <member name="M:Cake.Common.Security.SecurityAliases.CalculateFileHash(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Security.HashAlgorithm)">
        /// <summary>
        /// Calculates the hash for a given file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="hashAlgorithm">The hash algorithm to use.</param>
        /// <returns>A <see cref="T:Cake.Common.Security.FileHash" /> instance representing the calculated hash.</returns>
        /// <example>
        /// <code>
        /// Information(
        /// "Cake executable file MD5 hash: {0}",
        /// CalculateFileHash("Cake.exe", HashAlgorithm.MD5).ToHex());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Security.FileHash CalculateFileHash(global::Cake.Core.IO.FilePath filePath, global::Cake.Common.Security.HashAlgorithm hashAlgorithm)
            => global::Cake.Common.Security.SecurityAliases.CalculateFileHash(Context, filePath, hashAlgorithm);

        /// <member name="M:Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.GlobPattern},Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Calculates the hash for a given directory using the default (SHA256) algorithm.
        /// </summary>
        /// <param name="directoryPath">The file path.</param>
        /// <param name="globs">The glob pattern to match.</param>
        /// <returns>A <see cref="T:Cake.Common.Security.DirectoryHash" /> instance representing the calculated hash.</returns>
        /// <example>
        /// <code>
        /// Information(
        /// "Cake It calculates the hashes from all cs files in all subdirectories using a SHA256 hash: {0}",
        /// CalculateDirectoryHash("C:\directoryToHash", "./**/*.cs").ToHex());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Security.DirectoryHash CalculateDirectoryHash(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.GlobPattern> globs, global::Cake.Core.IO.DirectoryPath directoryPath)
            => global::Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Context, globs, directoryPath);

        /// <member name="M:Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,System.Collections.Generic.IEnumerable{Cake.Core.IO.GlobPattern},Cake.Common.Security.HashAlgorithm)">
        /// <summary>
        /// Calculates the hash for a given directory.
        /// </summary>
        /// <param name="directoryPath">The file path.</param>
        /// <param name="globs">The glob pattern to match.</param>
        /// <param name="hashAlgorithm">The hash algorithm to use.</param>
        /// <returns>A <see cref="T:Cake.Common.Security.DirectoryHash" /> instance representing the calculated hash.</returns>
        /// <example>
        /// <code>
        /// Information(
        /// "Cake It calculates the hashes from all cs files in all subdirectories using a MD5 hash: {0}",
        /// CalculateDirectoryHash("C:\directoryToHash", "./**/*.cs", HashAlgorithm.MD5).ToHex());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Security.DirectoryHash CalculateDirectoryHash(global::Cake.Core.IO.DirectoryPath directoryPath, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.GlobPattern> globs, global::Cake.Common.Security.HashAlgorithm hashAlgorithm)
            => global::Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Context, directoryPath, globs, hashAlgorithm);

        /// <member name="M:Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Calculates the hash for a given directory using the default (SHA256) algorithm.
        /// </summary>
        /// <param name="directoryPath">The file path.</param>
        /// <param name="globs">The glob pattern to match.</param>
        /// <returns>A <see cref="T:Cake.Common.Security.DirectoryHash" /> instance representing the calculated hash.</returns>
        /// <example>
        /// <code>
        /// Information(
        /// "Cake It calculates the hashes from all cs files in all subdirectories using a SHA256 hash: {0}",
        /// CalculateDirectoryHash("C:\directoryToHash", "./**/*.cs").ToHex());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Security.DirectoryHash CalculateDirectoryHash(global::System.Collections.Generic.IEnumerable<string> globs, global::Cake.Core.IO.DirectoryPath directoryPath)
            => global::Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Context, globs, directoryPath);

        /// <member name="M:Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Security.HashAlgorithm)">
        /// <summary>
        /// Calculates the hash for a given directory.
        /// </summary>
        /// <param name="directoryPath">The file path.</param>
        /// <param name="globs">The glob pattern to match.</param>
        /// <param name="hashAlgorithm">The hash algorithm to use.</param>
        /// <returns>A <see cref="T:Cake.Common.Security.DirectoryHash" /> instance representing the calculated hash.</returns>
        /// <example>
        /// <code>
        /// Information(
        /// "Cake It calculates the hashes from all cs files in all subdirectories using a MD5 hash: {0}",
        /// CalculateDirectoryHash("C:\directoryToHash", "./**/*.cs", HashAlgorithm.MD5).ToHex());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Security.DirectoryHash CalculateDirectoryHash(global::Cake.Core.IO.DirectoryPath directoryPath, global::System.Collections.Generic.IEnumerable<string> globs, global::Cake.Common.Security.HashAlgorithm hashAlgorithm)
            => global::Cake.Common.Security.SecurityAliases.CalculateDirectoryHash(Context, directoryPath, globs, hashAlgorithm);

        /// <member name="M:Cake.Common.Solution.SolutionAliases.ParseSolution(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Parses project information from a solution file.
        /// </summary>
        /// <param name="solutionPath">The solution path.</param>
        /// <returns>A parsed solution.</returns>
        /// <example>
        /// <code>
        /// var solutionPath = "./src/Cake.sln";
        /// Information("Parsing {0}", solutionPath);
        /// var parsedSolution = ParseSolution(solutionPath);
        /// foreach (var project in parsedSolution.Projects)
        /// {
        /// Information(
        /// @"Solution project file:
        /// Name: {0}
        /// Path: {1}
        /// Id  : {2}
        /// Type: {3}",
        /// project.Name,
        /// project.Path,
        /// project.Id,
        /// project.Type
        /// );
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Solution.SolutionParserResult ParseSolution(global::Cake.Core.IO.FilePath solutionPath)
            => global::Cake.Common.Solution.SolutionAliases.ParseSolution(Context, solutionPath);

        /// <member name="M:Cake.Common.Solution.Project.ProjectAliases.ParseProject(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Parses project information from project file.
        /// </summary>
        /// <param name="projectPath">The project file path.</param>
        /// <returns>A parsed project.</returns>
        /// <example>
        /// <code>
        /// var parsedProject = ParseProject("./src/Cake/Cake.csproj");
        /// Information(
        /// @"    Parsed project file:
        /// Configuration         : {0}
        /// Platform              : {1}
        /// OutputType            : {2}
        /// OutputPath            : {3}
        /// RootNameSpace         : {4}
        /// AssemblyName          : {5}
        /// TargetFrameworkVersion: {6}
        /// Files                 : {7}",
        /// parsedProject.Configuration,
        /// parsedProject.Platform,
        /// parsedProject.OutputType,
        /// parsedProject.OutputPath,
        /// parsedProject.RootNameSpace,
        /// parsedProject.AssemblyName,
        /// parsedProject.TargetFrameworkVersion,
        /// string.Concat(
        /// parsedProject
        /// .Files
        /// .Select(
        /// file=&gt;  string.Format(
        /// "\r\n            {0}",
        /// file.FilePath
        /// )
        /// )
        /// )
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Solution.Project.ProjectParserResult ParseProject(global::Cake.Core.IO.FilePath projectPath)
            => global::Cake.Common.Solution.Project.ProjectAliases.ParseProject(Context, projectPath);

        /// <member name="M:Cake.Common.Solution.Project.Properties.AssemblyInfoAliases.CreateAssemblyInfo(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Solution.Project.Properties.AssemblyInfoSettings)">
        /// <summary>
        /// Creates an assembly information file.
        /// </summary>
        /// <param name="outputPath">The output path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var file = "./SolutionInfo.cs";
        /// var version = "0.0.1";
        /// var buildNo = "123";
        /// var semVersion = string.Concat(version + "-" + buildNo);
        /// CreateAssemblyInfo(file, new AssemblyInfoSettings {
        /// Product = "SampleProject",
        /// Version = version,
        /// FileVersion = version,
        /// InformationalVersion = semVersion,
        /// Copyright = string.Format("Copyright (c) Contoso 2014 - {0}", DateTime.Now.Year)
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void CreateAssemblyInfo(global::Cake.Core.IO.FilePath outputPath, global::Cake.Common.Solution.Project.Properties.AssemblyInfoSettings settings)
            => global::Cake.Common.Solution.Project.Properties.AssemblyInfoAliases.CreateAssemblyInfo(Context, outputPath, settings);

        /// <member name="M:Cake.Common.Solution.Project.Properties.AssemblyInfoAliases.ParseAssemblyInfo(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Parses an existing assembly information file.
        /// </summary>
        /// <param name="assemblyInfoPath">The assembly info path.</param>
        /// <returns>The content of the assembly info file.</returns>
        /// <example>
        /// <code>
        /// var assemblyInfo = ParseAssemblyInfo("./SolutionInfo.cs");
        /// Information("Version: {0}", assemblyInfo.AssemblyVersion);
        /// Information("File version: {0}", assemblyInfo.AssemblyFileVersion);
        /// Information("Informational version: {0}", assemblyInfo.AssemblyInformationalVersion);
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Solution.Project.Properties.AssemblyInfoParseResult ParseAssemblyInfo(global::Cake.Core.IO.FilePath assemblyInfoPath)
            => global::Cake.Common.Solution.Project.Properties.AssemblyInfoAliases.ParseAssemblyInfo(Context, assemblyInfoPath);

        /// <member name="M:Cake.Common.Solution.Project.XmlDoc.XmlDocAliases.ParseXmlDocExampleCode(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Parses Xml documentation example code from given path.
        /// </summary>
        /// <param name="xmlFilePath">The Path to the file to parse.</param>
        /// <returns>Parsed example code.</returns>
        /// <example>
        /// <code>
        /// var exampleCodes = ParseXmlDocExampleCode("./Cake.Common.xml");
        /// foreach (var exampleCode in exampleCodes)
        /// {
        /// Information(
        /// "{0}\r\n{1}",
        /// exampleCode.Name,
        /// exampleCode.Code
        /// );
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Solution.Project.XmlDoc.XmlDocExampleCode> ParseXmlDocExampleCode(global::Cake.Core.IO.FilePath xmlFilePath)
            => global::Cake.Common.Solution.Project.XmlDoc.XmlDocAliases.ParseXmlDocExampleCode(Context, xmlFilePath);

        /// <member name="M:Cake.Common.Solution.Project.XmlDoc.XmlDocAliases.ParseXmlDocFilesExampleCode(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Parses Xml documentation example code from file(s) using given pattern.
        /// </summary>
        /// <param name="pattern">The globber file pattern.</param>
        /// <returns>Parsed example code.</returns>
        /// <example>
        /// <code>
        /// var filesExampleCodes = ParseXmlDocFilesExampleCode("./Cake.*.xml");
        /// foreach (var exampleCode in filesExampleCodes)
        /// {
        /// Information(
        /// "{0}\r\n{1}",
        /// exampleCode.Name,
        /// exampleCode.Code
        /// );
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Solution.Project.XmlDoc.XmlDocExampleCode> ParseXmlDocFilesExampleCode(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Solution.Project.XmlDoc.XmlDocAliases.ParseXmlDocFilesExampleCode(Context, pattern);

        /// <member name="M:Cake.Common.Text.TextTransformationAliases.TransformText(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Creates a text transformation from the provided template.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <returns>A <see cref="T:Cake.Common.Text.TextTransformation`1" /> representing the provided template.</returns>
        /// <example>
        /// This sample shows how to create a <see cref="T:Cake.Common.Text.TextTransformation`1" /> using
        /// the specified template.
        /// <code>
        /// string text = TransformText("Hello &lt;%subject%&gt;!")
        /// .WithToken("subject", "world")
        /// .ToString();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Text.TextTransformation<global::Cake.Core.Text.TextTransformationTemplate> TransformText(string template)
            => global::Cake.Common.Text.TextTransformationAliases.TransformText(Context, template);

        /// <member name="M:Cake.Common.Text.TextTransformationAliases.TransformText(Cake.Core.ICakeContext,System.String,System.String,System.String)">
        /// <summary>
        /// Creates a text transformation from the provided template, using the specified placeholder.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <param name="leftPlaceholder">The left placeholder.</param>
        /// <param name="rightPlaceholder">The right placeholder.</param>
        /// <returns>A <see cref="T:Cake.Common.Text.TextTransformation`1" /> representing the provided template.</returns>
        /// <example>
        /// This sample shows how to create a <see cref="T:Cake.Common.Text.TextTransformation`1" /> using
        /// the specified template and placeholder.
        /// <code>
        /// string text = TransformText("Hello {subject}!", "{", "}")
        /// .WithToken("subject", "world")
        /// .ToString();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Text.TextTransformation<global::Cake.Core.Text.TextTransformationTemplate> TransformText(string template, string leftPlaceholder, string rightPlaceholder)
            => global::Cake.Common.Text.TextTransformationAliases.TransformText(Context, template, leftPlaceholder, rightPlaceholder);

        /// <member name="M:Cake.Common.Text.TextTransformationAliases.TransformTextFile(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Creates a text transformation from the provided template on disc.
        /// </summary>
        /// <param name="path">The template file path.</param>
        /// <returns>A <see cref="T:Cake.Common.Text.TextTransformation`1" /> representing the provided template.</returns>
        /// <example>
        /// This sample shows how to create a <see cref="T:Cake.Common.Text.TextTransformation`1" /> using
        /// the specified template file with the placeholder format <c>&lt;%key%&gt;</c>.
        /// <code>
        /// string text = TransformTextFile("./template.txt")
        /// .WithToken("subject", "world")
        /// .ToString();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Text.TextTransformation<global::Cake.Core.Text.TextTransformationTemplate> TransformTextFile(global::Cake.Core.IO.FilePath path)
            => global::Cake.Common.Text.TextTransformationAliases.TransformTextFile(Context, path);

        /// <member name="M:Cake.Common.Text.TextTransformationAliases.TransformTextFile(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String,System.String)">
        /// <summary>
        /// Creates a text transformation from the provided template on disc, using the specified placeholder.
        /// </summary>
        /// <param name="path">The template file path.</param>
        /// <param name="leftPlaceholder">The left placeholder.</param>
        /// <param name="rightPlaceholder">The right placeholder.</param>
        /// <returns>A <see cref="T:Cake.Common.Text.TextTransformation`1" /> representing the provided template.</returns>
        /// <example>
        /// This sample shows how to create a <see cref="T:Cake.Common.Text.TextTransformation`1" /> using
        /// the specified template file and placeholder.
        /// <code>
        /// string text = TransformTextFile("./template.txt", "{", "}")
        /// .WithToken("subject", "world")
        /// .ToString();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Text.TextTransformation<global::Cake.Core.Text.TextTransformationTemplate> TransformTextFile(global::Cake.Core.IO.FilePath path, string leftPlaceholder, string rightPlaceholder)
            => global::Cake.Common.Text.TextTransformationAliases.TransformTextFile(Context, path, leftPlaceholder, rightPlaceholder);

        /// <member name="M:Cake.Common.Tools.Cake.CakeAliases.CakeExecuteScript(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Executes cake script out of process.
        /// </summary>
        /// <param name="cakeScriptPath">The script file.</param>
        /// <example>
        /// <code>
        /// CakeExecuteScript("./helloworld.cake");
        /// </code>
        /// </example>
        /// </member>
        public static void CakeExecuteScript(global::Cake.Core.IO.FilePath cakeScriptPath)
            => global::Cake.Common.Tools.Cake.CakeAliases.CakeExecuteScript(Context, cakeScriptPath);

        /// <member name="M:Cake.Common.Tools.Cake.CakeAliases.CakeExecuteScript(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.Cake.CakeSettings)">
        /// <summary>
        /// Executes cake script out of process.
        /// </summary>
        /// <param name="cakeScriptPath">The script file.</param>
        /// <param name="settings">The settings <see cref="T:Cake.Common.Tools.Cake.CakeSettings" />.</param>
        /// <example>
        /// <code>
        /// CakeExecuteScript("./helloworld.cake", new CakeSettings{ ToolPath="./Cake.exe" });
        /// </code>
        /// </example>
        /// </member>
        public static void CakeExecuteScript(global::Cake.Core.IO.FilePath cakeScriptPath, global::Cake.Common.Tools.Cake.CakeSettings settings)
            => global::Cake.Common.Tools.Cake.CakeAliases.CakeExecuteScript(Context, cakeScriptPath, settings);

        /// <member name="M:Cake.Common.Tools.Cake.CakeAliases.CakeExecuteExpression(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Executes Cake expression out of process.
        /// </summary>
        /// <param name="cakeExpression">The cake expression.</param>
        /// <example>
        /// <code>
        /// CakeExecuteExpression("Information(\"Hello {0}\", \"World\");");
        /// </code>
        /// </example>
        /// </member>
        public static void CakeExecuteExpression(string cakeExpression)
            => global::Cake.Common.Tools.Cake.CakeAliases.CakeExecuteExpression(Context, cakeExpression);

        /// <member name="M:Cake.Common.Tools.Cake.CakeAliases.CakeExecuteExpression(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Cake.CakeSettings)">
        /// <summary>
        /// Executes Cake expression out of process.
        /// </summary>
        /// <param name="cakeExpression">The cake expression.</param>
        /// <param name="settings">The settings <see cref="T:Cake.Common.Tools.Cake.CakeSettings" />.</param>
        /// <example>
        /// <code>
        /// CakeExecuteExpression(
        /// "Information(\"Hello {0}!\", Argument&lt;string&gt;(\"name\"));",
        /// new CakeSettings {
        /// ToolPath="./Cake.exe" ,
        /// Arguments = new Dictionary&lt;string, string&gt;{{"name", "World"}}
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void CakeExecuteExpression(string cakeExpression, global::Cake.Common.Tools.Cake.CakeSettings settings)
            => global::Cake.Common.Tools.Cake.CakeAliases.CakeExecuteExpression(Context, cakeExpression, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPack(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.Chocolatey.Pack.ChocolateyPackSettings)">
        /// <summary>
        /// Creates a Chocolatey package using the specified Nuspec file.
        /// </summary>
        /// <param name="nuspecFilePath">The nuspec file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var chocolateyPackSettings   = new ChocolateyPackSettings {
        /// Id                      = "TestChocolatey",
        /// Title                   = "The tile of the package",
        /// Version                 = "0.0.0.1",
        /// Authors                 = new[] {"John Doe"},
        /// Owners                  = new[] {"Contoso"},
        /// Summary                 = "Excellent summary of what the package does",
        /// Description             = "The description of the package",
        /// ProjectUrl              = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// PackageSourceUrl        = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// ProjectSourceUrl        = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// DocsUrl                 = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// MailingListUrl          = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// BugTrackerUrl           = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// Tags                    = new [] {"Cake", "Script", "Build"},
        /// Copyright               = "Some company 2015",
        /// LicenseUrl              = new Uri("https://github.com/SomeUser/TestChocolatey/blob/master/LICENSE.md"),
        /// RequireLicenseAcceptance= false,
        /// IconUrl                 = new Uri("http://cdn.rawgit.com/SomeUser/TestChocolatey/master/icons/testchocolatey.png"),
        /// ReleaseNotes            = new [] {"Bug fixes", "Issue fixes", "Typos"},
        /// Files                   = new [] {
        /// new ChocolateyNuSpecContent {Source = "bin/TestChocolatey.dll", Target = "bin"},
        /// },
        /// Debug                   = false,
        /// Verbose                 = false,
        /// Force                   = false,
        /// Noop                    = false,
        /// LimitOutput             = false,
        /// ExecutionTimeout        = 13,
        /// CacheLocation           = @"C:\temp",
        /// AllowUnofficial          = false
        /// };
        /// ChocolateyPack("./nuspec/TestChocolatey.nuspec", chocolateyPackSettings);
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyPack(global::Cake.Core.IO.FilePath nuspecFilePath, global::Cake.Common.Tools.Chocolatey.Pack.ChocolateyPackSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPack(Context, nuspecFilePath, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPack(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.Chocolatey.Pack.ChocolateyPackSettings)">
        /// <summary>
        /// Creates Chocolatey packages using the specified Nuspec files.
        /// </summary>
        /// <param name="filePaths">The nuspec file paths.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var chocolateyPackSettings   = new ChocolateyPackSettings {
        /// Id                      = "TestChocolatey",
        /// Title                   = "The tile of the package",
        /// Version                 = "0.0.0.1",
        /// Authors                 = new[] {"John Doe"},
        /// Owners                  = new[] {"Contoso"},
        /// Summary                 = "Excellent summary of what the package does",
        /// Description             = "The description of the package",
        /// ProjectUrl              = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// PackageSourceUrl        = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// ProjectSourceUrl        = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// DocsUrl                 = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// MailingListUrl          = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// BugTrackerUrl           = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// Tags                    = new [] {"Cake", "Script", "Build"},
        /// Copyright               = "Some company 2015",
        /// LicenseUrl              = new Uri("https://github.com/SomeUser/TestChocolatey/blob/master/LICENSE.md"),
        /// RequireLicenseAcceptance= false,
        /// IconUrl                 = new Uri("http://cdn.rawgit.com/SomeUser/TestChocolatey/master/icons/testchocolatey.png"),
        /// ReleaseNotes            = new [] {"Bug fixes", "Issue fixes", "Typos"},
        /// Files                   = new [] {
        /// new ChocolateyNuSpecContent {Source = "bin/TestChocolatey.dll", Target = "bin"},
        /// },
        /// Debug                   = false,
        /// Verbose                 = false,
        /// Force                   = false,
        /// Noop                    = false,
        /// LimitOutput             = false,
        /// ExecutionTimeout        = 13,
        /// CacheLocation           = @"C:\temp",
        /// AllowUnofficial          = false
        /// };
        /// var nuspecFiles = GetFiles("./**/*.nuspec");
        /// ChocolateyPack(nuspecFiles, chocolateyPackSettings);
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyPack(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths, global::Cake.Common.Tools.Chocolatey.Pack.ChocolateyPackSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPack(Context, filePaths, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPack(Cake.Core.ICakeContext,Cake.Common.Tools.Chocolatey.Pack.ChocolateyPackSettings)">
        /// <summary>
        /// Creates a Chocolatey package using the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var chocolateyPackSettings   = new ChocolateyPackSettings {
        /// Id                      = "TestChocolatey",
        /// Title                   = "The tile of the package",
        /// Version                 = "0.0.0.1",
        /// Authors                 = new[] {"John Doe"},
        /// Owners                  = new[] {"Contoso"},
        /// Summary                 = "Excellent summary of what the package does",
        /// Description             = "The description of the package",
        /// ProjectUrl              = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// PackageSourceUrl        = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// ProjectSourceUrl        = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// DocsUrl                 = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// MailingListUrl          = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// BugTrackerUrl           = new Uri("https://github.com/SomeUser/TestChocolatey/"),
        /// Tags                    = new [] {"Cake", "Script", "Build"},
        /// Copyright               = "Some company 2015",
        /// LicenseUrl              = new Uri("https://github.com/SomeUser/TestChocolatey/blob/master/LICENSE.md"),
        /// RequireLicenseAcceptance= false,
        /// IconUrl                 = new Uri("http://cdn.rawgit.com/SomeUser/TestChocolatey/master/icons/testchocolatey.png"),
        /// ReleaseNotes            = new [] {"Bug fixes", "Issue fixes", "Typos"},
        /// Files                   = new [] {
        /// new ChocolateyNuSpecContent {Source = "bin/TestChocolatey.dll", Target = "bin"},
        /// },
        /// Debug                   = false,
        /// Verbose                 = false,
        /// Force                   = false,
        /// Noop                    = false,
        /// LimitOutput             = false,
        /// ExecutionTimeout        = 13,
        /// CacheLocation           = @"C:\temp",
        /// AllowUnofficial          = false
        /// };
        /// ChocolateyPack(chocolateyPackSettings);
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyPack(global::Cake.Common.Tools.Chocolatey.Pack.ChocolateyPackSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPack(Context, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Installs a Chocolatey package.
        /// </summary>
        /// <param name="packageId">The id of the package to install.</param>
        /// <example>
        /// <code>
        /// ChocolateyInstall("MyChocolateyPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyInstall(string packageId)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstall(Context, packageId);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstall(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Install.ChocolateyInstallSettings)">
        /// <summary>
        /// Installs a Chocolatey package using the specified settings.
        /// </summary>
        /// <param name="packageId">The id of the package to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyInstall("MyChocolateyPackage", new ChocolateyInstallSettings {
        /// Source                = true,
        /// Version               = "1.2.3",
        /// Prerelease            = false,
        /// Forcex86              = false,
        /// InstallArguments      = "arg1",
        /// OverrideArguments     = false,
        /// NotSilent             = false,
        /// PackageParameters     = "param1",
        /// AllowDowngrade        = false,
        /// SideBySide            = false,
        /// IgnoreDependencies    = false,
        /// ForceDependencies     = false,
        /// SkipPowerShell        = false,
        /// User                  = "user",
        /// Password              = "password",
        /// IgnoreChecksums       = false,
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyInstall(string packageId, global::Cake.Common.Tools.Chocolatey.Install.ChocolateyInstallSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstall(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstallFromConfig(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Installs Chocolatey packages using the specified package configuration.
        /// </summary>
        /// <param name="packageConfigPath">The package configuration to install.</param>
        /// <example>
        /// <code>
        /// ChocolateyInstallFromConfig("./tools/packages.config");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyInstallFromConfig(global::Cake.Core.IO.FilePath packageConfigPath)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstallFromConfig(Context, packageConfigPath);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstallFromConfig(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.Chocolatey.Install.ChocolateyInstallSettings)">
        /// <summary>
        /// Installs Chocolatey packages using the specified package configuration and settings.
        /// </summary>
        /// <param name="packageConfigPath">The package configuration to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyInstallFromConfig("./tools/packages.config", new ChocolateyInstallSettings {
        /// Source                = true,
        /// Version               = "1.2.3",
        /// Prerelease            = false,
        /// Forcex86              = false,
        /// InstallArguments      = "arg1",
        /// OverrideArguments     = false,
        /// NotSilent             = false,
        /// PackageParameters     = "param1",
        /// AllowDowngrade        = false,
        /// SideBySide            = false,
        /// IgnoreDependencies    = false,
        /// ForceDependencies     = false,
        /// SkipPowerShell        = false,
        /// User                  = "user",
        /// Password              = "password",
        /// IgnoreChecksums       = false,
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyInstallFromConfig(global::Cake.Core.IO.FilePath packageConfigPath, global::Cake.Common.Tools.Chocolatey.Install.ChocolateyInstallSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyInstallFromConfig(Context, packageConfigPath, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Uninstalls a Chocolatey package.
        /// </summary>
        /// <param name="packageId">The id of the package to uninstall.</param>
        /// <example>
        /// <code>
        /// ChocolateyUninstall("MyChocolateyPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyUninstall(string packageId)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Context, packageId);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Uninstall.ChocolateyUninstallSettings)">
        /// <summary>
        /// Uninstalls a Chocolatey package using the specified settings.
        /// </summary>
        /// <param name="packageId">The id of the package to uninstall.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyUninstall("MyChocolateyPackage", new ChocolateyUninstallSettings {
        /// Source                  = true,
        /// Version                 = "1.2.3",
        /// UninstallArguments      = "arg1",
        /// OverrideArguments       = false,
        /// NotSilent               = false,
        /// PackageParameters       = "param1",
        /// SideBySide              = false,
        /// IgnoreDependencies      = false,
        /// ForceDependencies       = false,
        /// SkipPowerShell          = false,
        /// Debug                   = false,
        /// Verbose                 = false,
        /// FailOnStandardError     = false,
        /// UseSystemPowershell     = false,
        /// AllVersions             = false,
        /// Force                   = false,
        /// Noop                    = false,
        /// LimitOutput             = false,
        /// ExecutionTimeout        = 13,
        /// CacheLocation           = @"C:\temp",
        /// AllowUnofficial         = false,
        /// GlobalArguments         = false,
        /// GlobalPackageParameters = false,
        /// IgnorePackageExitCodes  = false,
        /// UsePackageExitCodes     = false,
        /// UseAutoUninstaller      = false,
        /// SkipAutoUninstaller     = false,
        /// FailOnAutoUninstaller   = false,
        /// IgnoreAutoUninstaller   = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyUninstall(string packageId, global::Cake.Common.Tools.Chocolatey.Uninstall.ChocolateyUninstallSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Uninstalls a Chocolatey package.
        /// </summary>
        /// <param name="packageIds">The ids of the packages to uninstall.</param>
        /// <example>
        /// <code>
        /// ChocolateyUninstall("MyChocolateyPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyUninstall(global::System.Collections.Generic.IEnumerable<string> packageIds)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Context, packageIds);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.Chocolatey.Uninstall.ChocolateyUninstallSettings)">
        /// <summary>
        /// Uninstalls Chocolatey packages using the specified settings.
        /// </summary>
        /// <param name="packageIds">The ids of the packages to uninstall.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyUninstall("MyChocolateyPackage", new ChocolateyUninstallSettings {
        /// Source                  = true,
        /// Version                 = "1.2.3",
        /// UninstallArguments      = "arg1",
        /// OverrideArguments       = false,
        /// NotSilent               = false,
        /// PackageParameters       = "param1",
        /// SideBySide              = false,
        /// IgnoreDependencies      = false,
        /// ForceDependencies       = false,
        /// SkipPowerShell          = false,
        /// Debug                   = false,
        /// Verbose                 = false,
        /// FailOnStandardError     = false,
        /// UseSystemPowershell     = false,
        /// AllVersions             = false,
        /// Force                   = false,
        /// Noop                    = false,
        /// LimitOutput             = false,
        /// ExecutionTimeout        = 13,
        /// CacheLocation           = @"C:\temp",
        /// AllowUnofficial         = false,
        /// GlobalArguments         = false,
        /// GlobalPackageParameters = false,
        /// IgnorePackageExitCodes  = false,
        /// UsePackageExitCodes     = false,
        /// UseAutoUninstaller      = false,
        /// SkipAutoUninstaller     = false,
        /// FailOnAutoUninstaller   = false,
        /// IgnoreAutoUninstaller   = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyUninstall(global::System.Collections.Generic.IEnumerable<string> packageIds, global::Cake.Common.Tools.Chocolatey.Uninstall.ChocolateyUninstallSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUninstall(Context, packageIds, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPin(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Pin.ChocolateyPinSettings)">
        /// <summary>
        /// Pins a Chocolatey package using the specified settings.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyPin("MyChocolateyPackage", new ChocolateyPinSettings {
        /// Version               = "1.2.3",
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyPin(string name, global::Cake.Common.Tools.Chocolatey.Pin.ChocolateyPinSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPin(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyApiKey(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.ApiKey.ChocolateyApiKeySettings)">
        /// <summary>
        /// Sets the Api Key for a Chocolatey Source using the specified settings.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyApiKey("http://www.mysource.com", new ChocolateyApiKeySettings {
        /// ApiKey                = "myApiKey",
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyApiKey(string source, global::Cake.Common.Tools.Chocolatey.ApiKey.ChocolateyApiKeySettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyApiKey(Context, source, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyConfig(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.Chocolatey.Config.ChocolateyConfigSettings)">
        /// <summary>
        /// Sets the config parameter using the specified settings.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyConfig("cacheLocation", @"c:\temp", new ChocolateyConfigSettings {
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyConfig(string name, string value, global::Cake.Common.Tools.Chocolatey.Config.ChocolateyConfigSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyConfig(Context, name, value, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableFeature(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Enables a Chocolatey Feature using the specified name.
        /// </summary>
        /// <param name="name">Name of the feature.</param>
        /// <example>
        /// <code>
        /// ChocolateyEnableFeature("checkSumFiles");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyEnableFeature(string name)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableFeature(Context, name);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableFeature(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Features.ChocolateyFeatureSettings)">
        /// <summary>
        /// Enables a Chocolatey Feature using the specified name and settings.
        /// </summary>
        /// <param name="name">Name of the feature.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyEnableFeature("checkSumFiles", new ChocolateyFeatureSettings {
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyEnableFeature(string name, global::Cake.Common.Tools.Chocolatey.Features.ChocolateyFeatureSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableFeature(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableFeature(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Disables a Chocolatey Feature using the specified name.
        /// </summary>
        /// <param name="name">Name of the feature.</param>
        /// <example>
        /// <code>
        /// ChocolateyDisableFeature("checkSumFiles");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyDisableFeature(string name)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableFeature(Context, name);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableFeature(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Features.ChocolateyFeatureSettings)">
        /// <summary>
        /// Disables a Chocolatey Feature using the specified name and settings.
        /// </summary>
        /// <param name="name">Name of the feature.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyDisableFeature("checkSumFiles", new ChocolateyFeatureSettings {
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyDisableFeature(string name, global::Cake.Common.Tools.Chocolatey.Features.ChocolateyFeatureSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableFeature(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyAddSource(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Adds Chocolatey package source using the specified name &amp;source to global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="source">Path to the package(s) source.</param>
        /// <example>
        /// <code>
        /// ChocolateyAddSource("MySource", "http://www.mysource.com");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyAddSource(string name, string source)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyAddSource(Context, name, source);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyAddSource(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings)">
        /// <summary>
        /// Adds Chocolatey package source using the specified name, source &amp; settings to global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="source">Path to the package(s) source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyAddSource("MySource", "http://www.mysource.com", new ChocolateySourcesSettings {
        /// UserName              = "user",
        /// Password              = "password",
        /// Priority              = 13,
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyAddSource(string name, string source, global::Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyAddSource(Context, name, source, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyRemoveSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Removes Chocolatey package source using the specified name &amp; source from global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <example>
        /// <code>
        /// ChocolateyRemoveSource("MySource");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyRemoveSource(string name)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyRemoveSource(Context, name);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyRemoveSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings)">
        /// <summary>
        /// Removes Chocolatey package source using the specified name, source &amp; settings from global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyRemoveSource("MySource", new ChocolateySourcesSettings {
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyRemoveSource(string name, global::Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyRemoveSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Enables a Chocolatey Source using the specified name.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <example>
        /// <code>
        /// ChocolateyEnableSource("MySource");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyEnableSource(string name)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableSource(Context, name);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings)">
        /// <summary>
        /// Enables a Chocolatey Source using the specified name and settings.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyEnableSource("MySource", new ChocolateySourcesSettings {
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyEnableSource(string name, global::Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyEnableSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Disables a Chocolatey Source using the specified name.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <example>
        /// <code>
        /// ChocolateyDisableSource("MySource");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyDisableSource(string name)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableSource(Context, name);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings)">
        /// <summary>
        /// Disables a Chocolatey Source using the specified name and settings.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyDisableSource("MySource", new ChocolateySourcesSettings {
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyDisableSource(string name, global::Cake.Common.Tools.Chocolatey.Sources.ChocolateySourcesSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDisableSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPush(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.Chocolatey.Push.ChocolateyPushSettings)">
        /// <summary>
        /// Pushes a Chocolatey package to a Chocolatey server and publishes it.
        /// </summary>
        /// <param name="packageFilePath">The <c>.nupkg</c> file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// // Get the path to the package.
        /// var package = "./chocolatey/MyChocolateyPackage.0.0.1.nupkg";
        /// // Push the package.
        /// ChocolateyPush(package, new ChocolateyPushSettings {
        /// Source                = "http://example.com/chocolateyfeed",
        /// ApiKey                = "4003d786-cc37-4004-bfdf-c4f3e8ef9b3a"
        /// Timeout               = 300
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyPush(global::Cake.Core.IO.FilePath packageFilePath, global::Cake.Common.Tools.Chocolatey.Push.ChocolateyPushSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPush(Context, packageFilePath, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPush(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.Chocolatey.Push.ChocolateyPushSettings)">
        /// <summary>
        /// Pushes Chocolatey packages to a Chocolatey server and publishes them.
        /// </summary>
        /// <param name="packageFilePaths">The <c>.nupkg</c> file paths.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// // Get the paths to the packages.
        /// var packages = GetFiles("./**/*.nupkg");
        /// // Push the package.
        /// ChocolateyPush(packages, new ChocolateyPushSettings {
        /// Source                = "http://example.com/chocolateyfeed",
        /// ApiKey                = "4003d786-cc37-4004-bfdf-c4f3e8ef9b3a"
        /// Timeout               = 300
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyPush(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> packageFilePaths, global::Cake.Common.Tools.Chocolatey.Push.ChocolateyPushSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyPush(Context, packageFilePaths, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUpgrade(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Upgrades Chocolatey package.
        /// </summary>
        /// <param name="packageId">The id of the package to upgrade.</param>
        /// <example>
        /// <code>
        /// ChocolateyUpgrade("MyChocolateyPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyUpgrade(string packageId)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUpgrade(Context, packageId);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUpgrade(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Upgrade.ChocolateyUpgradeSettings)">
        /// <summary>
        /// Upgrades Chocolatey package using the specified settings.
        /// </summary>
        /// <param name="packageId">The id of the package to upgrade.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyUpgrade("MyChocolateyPackage", new ChocolateyUpgradeSettings {
        /// Source                = true,
        /// Version               = "1.2.3",
        /// Prerelease            = false,
        /// Forcex86              = false,
        /// InstallArguments      = "arg1",
        /// OverrideArguments     = false,
        /// NotSilent             = false,
        /// PackageParameters     = "param1",
        /// AllowDowngrade        = false,
        /// SideBySide            = false,
        /// IgnoreDependencies    = false,
        /// SkipPowerShell        = false,
        /// FailOnUnfound        = false,
        /// FailOnNotInstalled        = false,
        /// User                  = "user",
        /// Password              = "password",
        /// IgnoreChecksums       = false,
        /// Debug                 = false,
        /// Verbose               = false,
        /// Force                 = false,
        /// Noop                  = false,
        /// LimitOutput           = false,
        /// ExecutionTimeout      = 13,
        /// CacheLocation         = @"C:\temp",
        /// AllowUnofficial        = false
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyUpgrade(string packageId, global::Cake.Common.Tools.Chocolatey.Upgrade.ChocolateyUpgradeSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyUpgrade(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyNew(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Generate package specification files for a new package using the default settings.
        /// </summary>
        /// <param name="packageId">The id of the package to create.</param>
        /// <example>
        /// <code>
        /// ChocolateyNew("MyChocolateyPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyNew(string packageId)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyNew(Context, packageId);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyNew(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.New.ChocolateyNewSettings)">
        /// <summary>
        /// Generate package specification files for a new package using the specified settings.
        /// </summary>
        /// <param name="packageId">The id of the package to create.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ChocolateyNew("MyChocolateyPackage", new ChocolateyNewSettings {
        /// PackageVersion = "1.2.3",
        /// MaintainerName = "John Doe",
        /// MaintainerRepo = "johndoe"
        /// });
        /// </code>
        /// </example>
        /// <example>
        /// <code>
        /// var settings = new ChocolateyNewSettings {
        /// MaintainerName = "John Doe"
        /// }
        /// settings.AdditionalPropertyValues("Tags", "CustomPackage");
        /// ChocolateyNew("MyChocolateyPackage", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyNew(string packageId, global::Cake.Common.Tools.Chocolatey.New.ChocolateyNewSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyNew(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDownload(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Downloads a Chocolatey package to the current working directory.
        /// Requires Chocolatey licensed edition.
        /// </summary>
        /// <param name="packageId">The id of the package to download.</param>
        /// <example>
        /// <code>
        /// ChocolateyDownload("MyChocolateyPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyDownload(string packageId)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDownload(Context, packageId);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDownload(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.Chocolatey.Download.ChocolateyDownloadSettings)">
        /// <summary>
        /// Downloads a Chocolatey package using the specified settings.
        /// Requires Chocolatey licensed edition.
        /// Features requiring Chocolatey for Business or a minimum version are documented
        /// in <see cref="T:Cake.Common.Tools.Chocolatey.Download.ChocolateyDownloadSettings" />.
        /// </summary>
        /// <param name="packageId">The id of the package to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>Download a package to a specific folder:</para>
        /// <code>
        /// ChocolateyDownload(
        /// "MyChocolateyPackage",
        /// new ChocolateyDownloadSettings {
        /// OutputDirectory = @"C:\download\"
        /// });
        /// </code>
        /// <para>Download and internalize a package:</para>
        /// <code>
        /// ChocolateyDownload(
        /// "MyChocolateyPackage",
        /// new ChocolateyDownloadSettings {
        /// Internalize = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyDownload(string packageId, global::Cake.Common.Tools.Chocolatey.Download.ChocolateyDownloadSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyDownload(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyExport(Cake.Core.ICakeContext)">
        /// <summary>
        /// Exports the currently installed Chocolatey packages to a packages.config file in the current working directory.
        /// </summary>
        /// <example>
        /// <code>
        /// ChocolateyExport();
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyExport()
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyExport(Context);

        /// <member name="M:Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyExport(Cake.Core.ICakeContext,Cake.Common.Tools.Chocolatey.Export.ChocolateyExportSettings)">
        /// <summary>
        /// Exports the currently installed Chocolatey packages using the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>Exported information should contain the package version numbers:</para>
        /// <code>
        /// ChocolateyExport(
        /// new ChocolateyExportSettings {
        /// IncludeVersionNumbers = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ChocolateyExport(global::Cake.Common.Tools.Chocolatey.Export.ChocolateyExportSettings settings)
            => global::Cake.Common.Tools.Chocolatey.ChocolateyAliases.ChocolateyExport(Context, settings);

        /// <member name="M:Cake.Common.Tools.Command.CommandAliases.Command(Cake.Core.ICakeContext,System.Collections.Generic.ICollection{System.String},Cake.Core.IO.ProcessArgumentBuilder,System.Int32,System.Func{Cake.Common.Tools.Command.CommandSettings,Cake.Common.Tools.Command.CommandSettings})">
        /// <summary>
        /// Executes a generic tool/process based on arguments and settings.
        /// </summary>
        /// <param name="toolExecutableNames">The tool executable names.</param>
        /// <param name="arguments">The optional arguments.</param>
        /// <param name="expectedExitCode">The expected exit code (default 0).</param>
        /// <param name="settingsCustomization">The optional settings customization (default null).</param>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="context" /> or <paramref name="toolExecutableNames" /> is null or empty.</exception>
        /// <example>
        /// <code>
        /// // Example with ProcessArgumentBuilder
        /// #tool dotnet:?package=DPI&amp;version=2022.8.21.54
        /// Command(
        /// new []{ "dpi", "dpi.exe"},
        /// new ProcessArgumentBuilder()
        /// .Append("nuget")
        /// .AppendQuoted(Context.Environment.WorkingDirectory.FullPath)
        /// .AppendSwitch("--output", " ", "TABLE")
        /// .Append("analyze")
        /// );
        /// // Example with implicit ProcessArgumentBuilder
        /// Command(
        /// new []{ "dotnet", "dotnet.exe"},
        /// "--version"
        /// );
        /// // Example specify expected exit code
        /// Command(
        /// new []{ "dotnet", "dotnet.exe"},
        /// expectedExitCode: -2147450751
        /// );
        /// // Example settings customization
        /// Command(
        /// new []{ "dotnet", "dotnet.exe"},
        /// settingsCustomization: settings =&gt; settings
        /// .WithToolName(".NET tool")
        /// .WithExpectedExitCode(1)
        /// .WithArgumentCustomization(args =&gt; args.Append("tool"))
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static void Command(global::System.Collections.Generic.ICollection<string> toolExecutableNames, global::Cake.Core.IO.ProcessArgumentBuilder? arguments = null, int expectedExitCode = 0, global::System.Func<global::Cake.Common.Tools.Command.CommandSettings, global::Cake.Common.Tools.Command.CommandSettings>? settingsCustomization = null)
            => global::Cake.Common.Tools.Command.CommandAliases.Command(Context, toolExecutableNames, arguments, expectedExitCode, settingsCustomization);

        /// <member name="M:Cake.Common.Tools.Command.CommandAliases.Command(Cake.Core.ICakeContext,Cake.Common.Tools.Command.CommandSettings,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <summary>
        /// Executes a generic command based on arguments and settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="arguments">The optional arguments.</param>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="context" /> or <paramref name="settings" /> is null.</exception>
        /// <example>
        /// <code>
        /// #tool dotnet:?package=DPI&amp;version=2022.8.21.54
        /// // Reusable tools settings i.e. created in setup.
        /// var settings = new CommandSettings {
        /// ToolName = "DPI",
        /// ToolExecutableNames =  new []{ "dpi", "dpi.exe"},
        /// };
        /// // Example with ProcessArgumentBuilder
        /// Command(
        /// settings,
        /// new ProcessArgumentBuilder()
        /// .Append("nuget")
        /// .AppendQuoted(Context.Environment.WorkingDirectory.FullPath)
        /// .AppendSwitch("--output", " ", "TABLE")
        /// .Append("analyze")
        /// );
        /// // Example with implicit ProcessArgumentBuilder
        /// Command(
        /// settings,
        /// $"nuget --output TABLE analyze"
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static void Command(global::Cake.Common.Tools.Command.CommandSettings settings, global::Cake.Core.IO.ProcessArgumentBuilder? arguments = null)
            => global::Cake.Common.Tools.Command.CommandAliases.Command(Context, settings, arguments);

        /// <member name="M:Cake.Common.Tools.Command.CommandAliases.Command(Cake.Core.ICakeContext,System.Collections.Generic.ICollection{System.String},System.String@,Cake.Core.IO.ProcessArgumentBuilder,System.Int32,System.Func{Cake.Common.Tools.Command.CommandSettings,Cake.Common.Tools.Command.CommandSettings})">
        /// <summary>
        /// Executes a generic tool/process based on arguments, tool executable names and redirects standard output.
        /// </summary>
        /// <param name="toolExecutableNames">The tool executable names.</param>
        /// <param name="standardOutput">The standard output.</param>
        /// <param name="arguments">The optional arguments.</param>
        /// <param name="expectedExitCode">The expected exit code (default 0).</param>
        /// <param name="settingsCustomization">The optional settings customization.</param>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="arguments" />, <paramref name="context" /> or <paramref name="toolExecutableNames" /> is null.</exception>
        /// <returns>The exit code.</returns>
        /// <example>
        /// <code>
        /// using System.Text.Json.Serialization;
        /// using System.Text.Json;
        /// #tool dotnet:?package=DPI&amp;version=2022.8.21.54
        /// // Example with ProcessArgumentBuilder
        /// var exitCode = Command(
        /// new []{ "dpi", "dpi.exe"},
        /// out var standardOutput,
        /// new ProcessArgumentBuilder()
        /// .Append("nuget")
        /// .AppendQuoted(Context.Environment.WorkingDirectory.FullPath)
        /// .AppendSwitch("--output", " ", "JSON")
        /// .Append("analyze")
        /// );
        /// var packageReferences =  JsonSerializer.Deserialize&lt;DPIPackageReference[]&gt;(
        /// standardOutput
        /// );
        /// // Example with implicit ProcessArgumentBuilder
        /// var implicitExitCode = Command(
        /// new []{ "dpi", "dpi.exe"},
        /// out var implicitStandardOutput,
        /// $"nuget --output JSON analyze"
        /// );
        /// var implicitPackageReferences =  JsonSerializer.Deserialize&lt;DPIPackageReference[]&gt;(
        /// implicitStandardOutput
        /// );
        /// // Example settings customization
        /// var settingsCustomizationExitCode = Command(
        /// new []{ "dpi", "dpi.exe"},
        /// out var settingsCustomizationStandardOutput,
        /// $"nuget --output JSON analyze",
        /// settingsCustomization: settings =&gt; settings
        /// .WithToolName("DPI")
        /// .WithArgumentCustomization(args =&gt; args.AppendSwitchQuoted("--buildversion", " ", "1.0.0"))
        /// );
        /// var settingsCustomizationPackageReferences =  JsonSerializer.Deserialize&lt;DPIPackageReference[]&gt;(
        /// settingsCustomizationStandardOutput
        /// );
        /// // Record used in example above
        /// public record DPIPackageReference(
        /// [property: JsonPropertyName("source")]
        /// string Source,
        /// [property: JsonPropertyName("sourceType")]
        /// string SourceType,
        /// [property: JsonPropertyName("packageId")]
        /// string PackageId,
        /// [property: JsonPropertyName("version")]
        /// string Version
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static int Command(global::System.Collections.Generic.ICollection<string> toolExecutableNames, out string standardOutput, global::Cake.Core.IO.ProcessArgumentBuilder? arguments = null, int expectedExitCode = 0, global::System.Func<global::Cake.Common.Tools.Command.CommandSettings, global::Cake.Common.Tools.Command.CommandSettings>? settingsCustomization = null)
            => global::Cake.Common.Tools.Command.CommandAliases.Command(Context, toolExecutableNames, out standardOutput, arguments, expectedExitCode, settingsCustomization);

        /// <member name="M:Cake.Common.Tools.Command.CommandAliases.Command(Cake.Core.ICakeContext,Cake.Common.Tools.Command.CommandSettings,System.String@,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <summary>
        /// Executes a generic tool/process based on arguments, settings and redirects standard output.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="standardOutput">The standard output.</param>
        /// <param name="arguments">The optional arguments.</param>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="context" /> or <paramref name="settings" /> is null.</exception>
        /// <returns>The exit code.</returns>
        /// <example>
        /// <code>
        /// using System.Text.Json.Serialization;
        /// using System.Text.Json;
        /// #tool dotnet:?package=DPI&amp;version=2022.8.21.54
        /// // Reusable tools settings i.e. created in setup.
        /// var settings = new CommandSettings {
        /// ToolName = "DPI",
        /// ToolExecutableNames =  new []{ "dpi", "dpi.exe" },
        /// };
        /// // Example with ProcessArgumentBuilder
        /// var exitCode = Command(
        /// settings,
        /// out var standardOutput,
        /// new ProcessArgumentBuilder()
        /// .Append("nuget")
        /// .AppendQuoted(Context.Environment.WorkingDirectory.FullPath)
        /// .AppendSwitch("--output", " ", "JSON")
        /// .Append("analyze")
        /// );
        /// var packageReferences =  JsonSerializer.Deserialize&lt;DPIPackageReference[]&gt;(
        /// standardOutput
        /// );
        /// // Example with implicit ProcessArgumentBuilder
        /// var implicitExitCode = Command(
        /// settings,
        /// out var implicitStandardOutput,
        /// $"nuget --output JSON analyze"
        /// );
        /// var implicitPackageReferences =  JsonSerializer.Deserialize&lt;DPIPackageReference[]&gt;(
        /// implicitStandardOutput
        /// );
        /// // Record used in example above
        /// public record DPIPackageReference(
        /// [property: JsonPropertyName("source")]
        /// string Source,
        /// [property: JsonPropertyName("sourceType")]
        /// string SourceType,
        /// [property: JsonPropertyName("packageId")]
        /// string PackageId,
        /// [property: JsonPropertyName("version")]
        /// string Version
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static int Command(global::Cake.Common.Tools.Command.CommandSettings settings, out string standardOutput, global::Cake.Core.IO.ProcessArgumentBuilder? arguments = null)
            => global::Cake.Common.Tools.Command.CommandAliases.Command(Context, settings, out standardOutput, arguments);

        /// <member name="M:Cake.Common.Tools.Command.CommandAliases.Command(Cake.Core.ICakeContext,System.Collections.Generic.ICollection{System.String},System.String@,System.String@,Cake.Core.IO.ProcessArgumentBuilder,System.Int32,System.Func{Cake.Common.Tools.Command.CommandSettings,Cake.Common.Tools.Command.CommandSettings})">
        /// <summary>
        /// Executes a generic tool/process based on arguments, settings, redirects standard output and standard error.
        /// </summary>
        /// <param name="toolExecutableNames">The tool executable names.</param>
        /// <param name="standardOutput">The standard output.</param>
        /// <param name="standardError">The standard error.</param>
        /// <param name="arguments">The optional arguments.</param>
        /// <param name="expectedExitCode">The expected exit code (default 0).</param>
        /// <param name="settingsCustomization">The optional settings customization (default null).</param>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="context" /> or <paramref name="toolExecutableNames" /> is null.</exception>
        /// <returns>The exit code.</returns>
        /// <example>
        /// <code>
        /// // Example with ProcessArgumentBuilder
        /// var exitCode = Command(
        /// new []{ "dotnet", "dotnet.exe" },
        /// out var standardOutput,
        /// out var standardError,
        /// new ProcessArgumentBuilder()
        /// .Append("tool"),
        /// expectedExitCode:1
        /// );
        /// Verbose("Exit code: {0}", exitCode);
        /// Information("Output: {0}", standardOutput);
        /// Error("Error: {0}", standardError);
        /// // Example with implicit ProcessArgumentBuilder
        /// var implicitExitCode = Command(
        /// new []{ "dotnet", "dotnet.exe" },
        /// out var implicitStandardOutput,
        /// out var implicitStandardError,
        /// "tool",
        /// expectedExitCode:1
        /// );
        /// Verbose("Exit code: {0}", implicitExitCode);
        /// Information("Output: {0}", implicitStandardOutput);
        /// Error("Error: {0}", implicitStandardError);
        /// // Example settings customization
        /// var settingsCustomizationExitCode = Command(
        /// new []{ "dotnet", "dotnet.exe" },
        /// out var settingsCustomizationStandardOutput,
        /// out var settingsCustomizationStandardError,
        /// settingsCustomization: settings =&gt; settings
        /// .WithToolName(".NET Tool")
        /// .WithArgumentCustomization(args =&gt; args.Append("tool"))
        /// .WithExpectedExitCode(1)
        /// );
        /// Verbose("Exit code: {0}", settingsCustomizationExitCode);
        /// Information("Output: {0}", settingsCustomizationStandardOutput);
        /// Error("Error: {0}", settingsCustomizationStandardError);
        /// </code>
        /// </example>
        /// </member>
        public static int Command(global::System.Collections.Generic.ICollection<string> toolExecutableNames, out string standardOutput, out string standardError, global::Cake.Core.IO.ProcessArgumentBuilder? arguments = null, int expectedExitCode = 0, global::System.Func<global::Cake.Common.Tools.Command.CommandSettings, global::Cake.Common.Tools.Command.CommandSettings>? settingsCustomization = null)
            => global::Cake.Common.Tools.Command.CommandAliases.Command(Context, toolExecutableNames, out standardOutput, out standardError, arguments, expectedExitCode, settingsCustomization);

        /// <member name="M:Cake.Common.Tools.Command.CommandAliases.Command(Cake.Core.ICakeContext,Cake.Common.Tools.Command.CommandSettings,System.String@,System.String@,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <summary>
        /// Executes a generic tool/process based on arguments and settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="standardOutput">The standard output.</param>
        /// <param name="standardError">The standard error.</param>
        /// <param name="arguments">The optional arguments.</param>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="context" /> or <paramref name="settings" /> is null.</exception>
        /// <returns>The exit code.</returns>
        /// <example>
        /// <code>
        /// // Reusable tools settings i.e. created in setup.
        /// var settings = new CommandSettings {
        /// ToolName = ".NET CLI",
        /// ToolExecutableNames =  new []{ "dotnet", "dotnet.exe" },
        /// }.WithExpectedExitCode(1);
        /// // Example with ProcessArgumentBuilder
        /// var exitCode = Command(
        /// settings,
        /// out var standardOutput,
        /// out var standardError,
        /// new ProcessArgumentBuilder()
        /// .Append("tool")
        /// );
        /// Verbose("Exit code: {0}", exitCode);
        /// Information("Output: {0}", standardOutput);
        /// Error("Error: {0}", standardError);
        /// // Example with implicit ProcessArgumentBuilder
        /// var implicitExitCode = Command(
        /// settings,
        /// out var implicitStandardOutput,
        /// out var implicitStandardError,
        /// "tool"
        /// );
        /// Verbose("Exit code: {0}", implicitExitCode);
        /// Information("Output: {0}", implicitStandardOutput);
        /// Error("Error: {0}", implicitStandardError);
        /// </code>
        /// </example>
        /// </member>
        public static int Command(global::Cake.Common.Tools.Command.CommandSettings settings, out string standardOutput, out string standardError, global::Cake.Core.IO.ProcessArgumentBuilder? arguments = null)
            => global::Cake.Common.Tools.Command.CommandAliases.Command(Context, settings, out standardOutput, out standardError, arguments);

        /// <member name="M:Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverAnalyse(Cake.Core.ICakeContext,System.Action{Cake.Core.ICakeContext},Cake.Core.IO.FilePath,Cake.Common.Tools.DotCover.Analyse.DotCoverAnalyseSettings)">
        /// <summary>
        /// Runs <see href="https://www.jetbrains.com/dotcover/help/dotCover__Console_Runner_Commands.html#analyse">DotCover Analyse</see>
        /// for the specified action and settings.
        /// </summary>
        /// <param name="action">The action to run DotCover for.</param>
        /// <param name="outputFile">The DotCover output file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotCoverAnalyse(tool =&gt; {
        /// tool.XUnit2("./**/App.Tests.dll",
        /// new XUnit2Settings {
        /// ShadowCopy = false
        /// });
        /// },
        /// new FilePath("./result.xml"),
        /// new DotCoverAnalyseSettings()
        /// .WithFilter("+:App")
        /// .WithFilter("-:App.Tests"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotCoverAnalyse(global::System.Action<global::Cake.Core.ICakeContext> action, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.DotCover.Analyse.DotCoverAnalyseSettings settings)
            => global::Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverAnalyse(Context, action, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverCover(Cake.Core.ICakeContext,System.Action{Cake.Core.ICakeContext},Cake.Core.IO.FilePath,Cake.Common.Tools.DotCover.Cover.DotCoverCoverSettings)">
        /// <summary>
        /// Runs <see href="https://www.jetbrains.com/dotcover/help/dotCover__Console_Runner_Commands.html#cover">DotCover Cover</see>
        /// for the specified action and settings.
        /// </summary>
        /// <param name="action">The action to run DotCover for.</param>
        /// <param name="outputFile">The DotCover output file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotCoverCover(tool =&gt; {
        /// tool.XUnit2("./**/App.Tests.dll",
        /// new XUnit2Settings {
        /// ShadowCopy = false
        /// });
        /// },
        /// new FilePath("./result.dcvr"),
        /// new DotCoverCoverSettings()
        /// .WithFilter("+:App")
        /// .WithFilter("-:App.Tests"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotCoverCover(global::System.Action<global::Cake.Core.ICakeContext> action, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.DotCover.Cover.DotCoverCoverSettings settings)
            => global::Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverCover(Context, action, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverReport(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Common.Tools.DotCover.Report.DotCoverReportSettings)">
        /// <summary>
        /// Runs <see href="https://www.jetbrains.com/dotcover/help/dotCover__Console_Runner_Commands.html#report">DotCover Report</see>
        /// for the specified action and settings.
        /// </summary>
        /// <param name="sourceFile">The DotCover coverage snapshot file name.</param>
        /// <param name="outputFile">The DotCover output file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotCoverReport(new FilePath("./result.dcvr"),
        /// new FilePath("./result.html"),
        /// new DotCoverReportSettings {
        /// ReportType = DotCoverReportType.HTML
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotCoverReport(global::Cake.Core.IO.FilePath sourceFile, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.DotCover.Report.DotCoverReportSettings settings)
            => global::Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverReport(Context, sourceFile, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverMerge(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.FilePath)">
        /// <summary>
        /// Runs <see href="https://www.jetbrains.com/dotcover/help/dotCover__Console_Runner_Commands.html#merge">DotCover Merge</see>
        /// for the specified action and settings.
        /// </summary>
        /// <param name="sourceFiles">The list of DotCover coverage snapshot files.</param>
        /// <param name="outputFile">The merged output file.</param>
        /// <example>
        /// <code>
        /// DotCoverMerge(new[] {
        /// new FilePath("./result1.dcvr"),
        /// new FilePath("./result2.dcvr")
        /// },
        /// new FilePath("./merged.dcvr"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotCoverMerge(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> sourceFiles, global::Cake.Core.IO.FilePath outputFile)
            => global::Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverMerge(Context, sourceFiles, outputFile);

        /// <member name="M:Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverMerge(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.FilePath,Cake.Common.Tools.DotCover.Merge.DotCoverMergeSettings)">
        /// <summary>
        /// Runs <see href="https://www.jetbrains.com/dotcover/help/dotCover__Console_Runner_Commands.html#merge">DotCover Merge</see>
        /// for the specified action and settings.
        /// </summary>
        /// <param name="sourceFiles">The list of DotCover coverage snapshot files.</param>
        /// <param name="outputFile">The merged output file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotCoverMerge(new[] {
        /// new FilePath("./result1.dcvr"),
        /// new FilePath("./result2.dcvr")
        /// },
        /// new FilePath("./merged.dcvr"),
        /// new DotCoverMergeSettings {
        /// LogFile = new FilePath("./log.txt")
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotCoverMerge(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> sourceFiles, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.DotCover.Merge.DotCoverMergeSettings settings)
            => global::Cake.Common.Tools.DotCover.DotCoverAliases.DotCoverMerge(Context, sourceFiles, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuild(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Build all projects.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <example>
        /// <code>
        /// DotNetBuild("./src/*");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetBuild(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuild(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuild(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Build.DotNetBuildSettings)">
        /// <summary>
        /// Build all projects.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetBuildSettings
        /// {
        /// Framework = "netcoreapp2.0",
        /// Configuration = "Debug",
        /// OutputDirectory = "./artifacts/"
        /// };
        /// DotNetBuild("./src/*", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetBuild(string project, global::Cake.Common.Tools.DotNet.Build.DotNetBuildSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuild(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuildServerShutdown(Cake.Core.ICakeContext)">
        /// <summary>
        /// Shuts down build servers that are started from dotnet.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetBuildServerShutdown();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetBuildServerShutdown()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuildServerShutdown(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuildServerShutdown(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.BuildServer.DotNetBuildServerShutdownSettings)">
        /// <summary>
        /// Shuts down build servers that are started from dotnet.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetBuildServerShutdownSettings
        /// {
        /// MSBuild = true
        /// };
        /// DotNetBuildServerShutdown(settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetBuildServerShutdown(global::Cake.Common.Tools.DotNet.BuildServer.DotNetBuildServerShutdownSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetBuildServerShutdown(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetClean(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Cleans a project's output.
        /// </summary>
        /// <param name="project">The project's path.</param>
        /// <example>
        /// <code>
        /// DotNetClean("./src/project");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetClean(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetClean(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetClean(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Clean.DotNetCleanSettings)">
        /// <summary>
        /// Cleans a project's output.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetCleanSettings
        /// {
        /// Framework = "netcoreapp2.0",
        /// Configuration = "Debug",
        /// OutputDirectory = "./artifacts/"
        /// };
        /// DotNetClean("./src/project", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetClean(string project, global::Cake.Common.Tools.DotNet.Clean.DotNetCleanSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetClean(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetExecute(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Execute an assembly.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <example>
        /// <code>
        /// DotNetExecute("./bin/Debug/app.dll");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetExecute(global::Cake.Core.IO.FilePath assemblyPath)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetExecute(Context, assemblyPath);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetExecute(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <summary>
        /// Execute an assembly with arguments in the specific path.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <param name="arguments">The arguments.</param>
        /// <example>
        /// <code>
        /// DotNetExecute("./bin/Debug/app.dll", "--arg");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetExecute(global::Cake.Core.IO.FilePath assemblyPath, global::Cake.Core.IO.ProcessArgumentBuilder arguments)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetExecute(Context, assemblyPath, arguments);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetExecute(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.ProcessArgumentBuilder,Cake.Common.Tools.DotNet.Execute.DotNetExecuteSettings)">
        /// <summary>
        /// Execute an assembly with arguments in the specific path with settings.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <param name="arguments">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetExecuteSettings
        /// {
        /// FrameworkVersion = "1.0.3"
        /// };
        /// DotNetExecute("./bin/Debug/app.dll", "--arg", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetExecute(global::Cake.Core.IO.FilePath assemblyPath, global::Cake.Core.IO.ProcessArgumentBuilder arguments, global::Cake.Common.Tools.DotNet.Execute.DotNetExecuteSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetExecute(Context, assemblyPath, arguments, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormat(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Formats code to match editorconfig settings.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <example>
        /// <code>
        /// DotNetFormat("./src/project");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormat(string root)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormat(Context, root);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormat(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Format.DotNetFormatSettings)">
        /// <summary>
        /// Formats code to match editorconfig settings.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetFormatSettings
        /// {
        /// NoRestore = true,
        /// Include = "Program.cs Utility\Logging.cs",
        /// Severity = DotNetFormatSeverity.Error
        /// };
        /// DotNetFormat("./src/project", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormat(string root, global::Cake.Common.Tools.DotNet.Format.DotNetFormatSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormat(Context, root, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatWhitespace(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Format code to match editorconfig settings for whitespace.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <example>
        /// <code>
        /// DotNetFormatWhitespace("./src/*");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormatWhitespace(string root)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatWhitespace(Context, root);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatWhitespace(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Format.DotNetFormatSettings)">
        /// <summary>
        /// Format code to match editorconfig settings for whitespace.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetFormatSettings
        /// {
        /// NoRestore = true,
        /// Include = "Program.cs Utility\Logging.cs"
        /// };
        /// DotNetFormatWhitespace("./src/*", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormatWhitespace(string root, global::Cake.Common.Tools.DotNet.Format.DotNetFormatSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatWhitespace(Context, root, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatStyle(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Format code to match editorconfig settings for code style.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <example>
        /// <code>
        /// DotNetFormatStyle("./src/*");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormatStyle(string root)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatStyle(Context, root);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatStyle(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Format.DotNetFormatSettings)">
        /// <summary>
        /// Format code to match editorconfig settings for code style.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetFormatSettings
        /// {
        /// NoRestore = true,
        /// Include = "Program.cs Utility\Logging.cs"
        /// };
        /// DotNetFormatStyle("./src/*", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormatStyle(string root, global::Cake.Common.Tools.DotNet.Format.DotNetFormatSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatStyle(Context, root, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatAnalyzers(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Format code to match editorconfig settings for analyzers.
        /// </summary>
        /// <param name="project">The project or solution path.</param>
        /// <example>
        /// <code>
        /// DotNetFormatAnalyzers("./src/*");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormatAnalyzers(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatAnalyzers(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatAnalyzers(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Format.DotNetFormatSettings)">
        /// <summary>
        /// Format code to match editorconfig settings for analyzers.
        /// </summary>
        /// <param name="root">The project or solution path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetFormatSettings
        /// {
        /// NoRestore = true,
        /// Include = "Program.cs Utility\Logging.cs"
        /// };
        /// DotNetFormatAnalyzers("./src/*", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetFormatAnalyzers(string root, global::Cake.Common.Tools.DotNet.Format.DotNetFormatSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetFormatAnalyzers(Context, root, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Cake.Core.ICakeContext)">
        /// <summary>
        /// Builds the specified targets in a project file found in the current working directory.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetMSBuild();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetMSBuild()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Builds the specified targets in the project file.
        /// </summary>
        /// <param name="projectOrDirectory">Project file or directory to search for project file.</param>
        /// <example>
        /// <code>
        /// DotNetMSBuild("foobar.proj");
        /// </code>
        /// </example>
        /// <remarks>
        /// If a directory is specified, MSBuild searches that directory for a project file.
        /// </remarks>
        /// </member>
        public static void DotNetMSBuild(string projectOrDirectory)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Context, projectOrDirectory);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings)">
        /// <summary>
        /// Builds the specified targets in a project file found in the current working directory.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetMSBuildSettings
        /// {
        /// NoLogo = true,
        /// MaxCpuCount = -1
        /// };
        /// DotNetMSBuild(settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetMSBuild(global::Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings,System.Action{System.Collections.Generic.IEnumerable{System.String}})">
        /// <summary>
        /// Builds the specified targets in a project file found in the current working directory.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="standardOutputAction">The action to invoke with the standard output.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetMSBuildSettings
        /// {
        /// NoLogo = true,
        /// MaxCpuCount = -1
        /// };
        /// DotNetMSBuild(settings,
        /// output =&gt; foreach (var line in output) outputBuilder.AppendLine(line));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetMSBuild(global::Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings settings, global::System.Action<global::System.Collections.Generic.IEnumerable<string>> standardOutputAction)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Context, settings, standardOutputAction);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings)">
        /// <summary>
        /// Builds the specified targets in the project file.
        /// </summary>
        /// <param name="projectOrDirectory">Project file or directory to search for project file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetMSBuildSettings
        /// {
        /// NoLogo = true,
        /// MaxCpuCount = -1
        /// };
        /// DotNetMSBuild("foobar.proj", settings);
        /// </code>
        /// </example>
        /// <remarks>
        /// If a project file is not specified, MSBuild searches the current working directory for a file that has a file
        /// extension that ends in "proj" and uses that file. If a directory is specified, MSBuild searches that directory for a project file.
        /// </remarks>
        /// </member>
        public static void DotNetMSBuild(string projectOrDirectory, global::Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Context, projectOrDirectory, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings,System.Action{System.Collections.Generic.IEnumerable{System.String}})">
        /// <summary>
        /// Builds the specified targets in the project file.
        /// </summary>
        /// <param name="projectOrDirectory">Project file or directory to search for project file.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="standardOutputAction">The action to invoke with the standard output.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetMSBuildSettings
        /// {
        /// NoLogo = true,
        /// MaxCpuCount = -1
        /// };
        /// DotNetMSBuild("foobar.proj", settings,
        /// output =&gt; foreach (var line in output) outputBuilder.AppendLine(line));
        /// </code>
        /// </example>
        /// <remarks>
        /// If a project file is not specified, MSBuild searches the current working directory for a file that has a file
        /// extension that ends in "proj" and uses that file. If a directory is specified, MSBuild searches that directory for a project file.
        /// </remarks>
        /// </member>
        public static void DotNetMSBuild(string projectOrDirectory, global::Cake.Common.Tools.DotNet.MSBuild.DotNetMSBuildSettings settings, global::System.Action<global::System.Collections.Generic.IEnumerable<string>> standardOutputAction)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetMSBuild(Context, projectOrDirectory, settings, standardOutputAction);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Cake.Core.ICakeContext)">
        /// <summary>
        /// Delete a NuGet Package from a server.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetNuGetDelete();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDelete()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Deletes a package from nuget.org.
        /// </summary>
        /// <param name="packageName">Name of package to delete.</param>
        /// <example>
        /// <code>
        /// DotNetNuGetDelete("Microsoft.AspNetCore.Mvc");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDelete(string packageName)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Context, packageName);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Deletes a specific version of a package from nuget.org.
        /// </summary>
        /// <param name="packageName">Name of package to delete.</param>
        /// <param name="packageVersion">Version of package to delete.</param>
        /// <example>
        /// <code>
        /// DotNetRestore("Microsoft.AspNetCore.Mvc", "1.0");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDelete(string packageName, string packageVersion)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Context, packageName, packageVersion);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Delete.DotNetNuGetDeleteSettings)">
        /// <summary>
        /// Deletes a package from a server.
        /// </summary>
        /// <param name="packageName">Name of package to delete.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetDeleteSettings
        /// {
        /// Source = "https://www.example.com/nugetfeed",
        /// NonInteractive = true
        /// };
        /// DotNetNuGetDelete("Microsoft.AspNetCore.Mvc", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDelete(string packageName, global::Cake.Common.Tools.DotNet.NuGet.Delete.DotNetNuGetDeleteSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Context, packageName, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.NuGet.Delete.DotNetNuGetDeleteSettings)">
        /// <summary>
        /// Deletes a package from a server using the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetDeleteSettings
        /// {
        /// Source = "https://www.example.com/nugetfeed",
        /// NonInteractive = true
        /// };
        /// DotNetNuGetDelete(settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDelete(global::Cake.Common.Tools.DotNet.NuGet.Delete.DotNetNuGetDeleteSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.DotNet.NuGet.Delete.DotNetNuGetDeleteSettings)">
        /// <summary>
        /// Deletes a package from a server using the specified settings.
        /// </summary>
        /// <param name="packageName">Name of package to delete.</param>
        /// <param name="packageVersion">Version of package to delete.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetDeleteSettings
        /// {
        /// Source = "https://www.example.com/nugetfeed",
        /// NonInteractive = true
        /// };
        /// DotNetNuGetDelete("Microsoft.AspNetCore.Mvc", "1.0", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDelete(string packageName, string packageVersion, global::Cake.Common.Tools.DotNet.NuGet.Delete.DotNetNuGetDeleteSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDelete(Context, packageName, packageVersion, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetPush(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Pushes one or more packages to a server.
        /// </summary>
        /// <param name="packageFilePath"><see cref="T:Cake.Core.IO.FilePath" /> of the package to push.</param>
        /// <example>
        /// <code>
        /// // With FilePath instance
        /// var packageFilePath = GetFiles("*.nupkg").Single();
        /// DotNetNuGetPush(packageFilePath);
        /// // With string parameter
        /// DotNetNuGetPush("foo*.nupkg");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetPush(global::Cake.Core.IO.FilePath packageFilePath)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetPush(Context, packageFilePath);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetPush(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.DotNet.NuGet.Push.DotNetNuGetPushSettings)">
        /// <summary>
        /// Pushes one or more packages to a server using the specified settings.
        /// </summary>
        /// <param name="packageFilePath"><see cref="T:Cake.Core.IO.FilePath" /> of the package to push.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetPushSettings
        /// {
        /// Source = "https://www.example.com/nugetfeed",
        /// ApiKey = "4003d786-cc37-4004-bfdf-c4f3e8ef9b3a"
        /// };
        /// // With FilePath instance
        /// var packageFilePath = GetFiles("foo*.nupkg").Single();
        /// DotNetNuGetPush(packageFilePath);
        /// // With string parameter
        /// DotNetNuGetPush("foo*.nupkg", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetPush(global::Cake.Core.IO.FilePath packageFilePath, global::Cake.Common.Tools.DotNet.NuGet.Push.DotNetNuGetPushSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetPush(Context, packageFilePath, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetAddSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings)">
        /// <summary>
        /// Add the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetSourceSettings
        /// {
        /// Source = "https://www.example.com/nugetfeed",
        /// UserName = "username",
        /// Password = "password",
        /// StorePasswordInClearText = true,
        /// ValidAuthenticationTypes = "basic,negotiate"
        /// };
        /// DotNetNuGetAddSource("example", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetAddSource(string name, global::Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetAddSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDisableSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Disable the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <example>
        /// <code>
        /// DotNetNuGetDisableSource("example");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDisableSource(string name)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDisableSource(Context, name);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDisableSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings)">
        /// <summary>
        /// Disable the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetSourceSettings
        /// {
        /// ConfigFile = "NuGet.config"
        /// };
        /// DotNetNuGetDisableSource("example", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetDisableSource(string name, global::Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetDisableSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetEnableSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Enable the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <example>
        /// <code>
        /// DotNetNuGetEnableSource("example");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetEnableSource(string name)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetEnableSource(Context, name);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetEnableSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings)">
        /// <summary>
        /// Enable the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetSourceSettings
        /// {
        /// ConfigFile = "NuGet.config"
        /// };
        /// DotNetNuGetEnableSource("example", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetEnableSource(string name, global::Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetEnableSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetHasSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Determines whether the specified NuGet source exists.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <returns>Whether the specified NuGet source exists.</returns>
        /// <example>
        /// <code>
        /// var exists = DotNetNuGetHasSource("example");
        /// </code>
        /// </example>
        /// </member>
        public static bool DotNetNuGetHasSource(string name)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetHasSource(Context, name);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetHasSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings)">
        /// <summary>
        /// Determines whether the specified NuGet source exists.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>Whether the specified NuGet source exists.</returns>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetSourceSettings
        /// {
        /// ConfigFile = "NuGet.config"
        /// };
        /// var exists = DotNetNuGetHasSource("example", settings);
        /// </code>
        /// </example>
        /// </member>
        public static bool DotNetNuGetHasSource(string name, global::Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetHasSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetRemoveSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Remove the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <example>
        /// <code>
        /// DotNetNuGetRemoveSource("example");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetRemoveSource(string name)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetRemoveSource(Context, name);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetRemoveSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings)">
        /// <summary>
        /// Remove the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetSourceSettings
        /// {
        /// ConfigFile = "NuGet.config"
        /// };
        /// DotNetNuGetRemoveSource("example", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetRemoveSource(string name, global::Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetRemoveSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetUpdateSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings)">
        /// <summary>
        /// Update the specified NuGet source.
        /// </summary>
        /// <param name="name">The name of the source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetNuGetSourceSettings
        /// {
        /// Source = "https://www.example.com/nugetfeed",
        /// UserName = "username",
        /// Password = "password",
        /// StorePasswordInClearText = true,
        /// ValidAuthenticationTypes = "basic,negotiate"
        /// };
        /// DotNetNuGetUpdateSource("example", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetNuGetUpdateSource(string name, global::Cake.Common.Tools.DotNet.NuGet.Source.DotNetNuGetSourceSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetNuGetUpdateSource(Context, name, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetPack(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Package all projects.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <example>
        /// <code>
        /// DotNetPack("./src/*");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetPack(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetPack(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetPack(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Pack.DotNetPackSettings)">
        /// <summary>
        /// Package all projects.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetPackSettings
        /// {
        /// Configuration = "Release",
        /// OutputDirectory = "./artifacts/"
        /// };
        /// DotNetPack("./src/*", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetPack(string project, global::Cake.Common.Tools.DotNet.Pack.DotNetPackSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetPack(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Adds or updates a package reference in a project file.
        /// </summary>
        /// <param name="packageName">The package reference to add.</param>
        /// <example>
        /// <code>
        /// DotNetAddPackage("Cake.FileHelper");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddPackage(string packageName)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Context, packageName);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Adds or updates a package reference in a project file.
        /// </summary>
        /// <param name="packageName">The package reference to add.</param>
        /// <param name="project">The target project file path.</param>
        /// <example>
        /// <code>
        /// DotNetAddPackage("Cake.FileHelper", "ToDo.csproj");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddPackage(string packageName, string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Context, packageName, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Package.Add.DotNetPackageAddSettings)">
        /// <summary>
        /// Adds or updates a package reference in a project file.
        /// </summary>
        /// <param name="packageName">The package reference to add.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetPackageAddSettings
        /// {
        /// NoRestore = true,
        /// Version = "6.1.3"
        /// };
        /// DotNetAddPackage("Cake.FileHelper", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddPackage(string packageName, global::Cake.Common.Tools.DotNet.Package.Add.DotNetPackageAddSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Context, packageName, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.DotNet.Package.Add.DotNetPackageAddSettings)">
        /// <summary>
        /// Adds or updates a package reference in a project file.
        /// </summary>
        /// <param name="packageName">The package reference to add.</param>
        /// <param name="project">The target project file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetPackageAddSettings
        /// {
        /// NoRestore = true,
        /// Version = "6.1.3"
        /// };
        /// DotNetAddPackage("Cake.FileHelper", "ToDo.csproj", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddPackage(string packageName, string project, global::Cake.Common.Tools.DotNet.Package.Add.DotNetPackageAddSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddPackage(Context, packageName, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemovePackage(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Removes package reference from a project file.
        /// </summary>
        /// <param name="packageName">The package reference to remove.</param>
        /// <example>
        /// <code>
        /// DotNetRemovePackage("Cake.FileHelper");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemovePackage(string packageName)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemovePackage(Context, packageName);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemovePackage(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Removes package reference from a project file.
        /// </summary>
        /// <param name="packageName">The package reference to remove.</param>
        /// <param name="project">The target project file path.</param>
        /// <example>
        /// <code>
        /// DotNetRemovePackage("Cake.FileHelper", "ToDo.csproj");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemovePackage(string packageName, string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemovePackage(Context, packageName, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemovePackage(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.DotNet.Package.Remove.DotNetPackageRemoveSettings)">
        /// <summary>
        /// Removes package reference from a project file.
        /// </summary>
        /// <param name="packageName">The package reference to remove.</param>
        /// <param name="project">The target project file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetRemovePackage(
        /// "Cake.FileHelper",
        /// "ToDo.csproj",
        /// new DotNetPackageRemoveSettings { WorkingDirectory = "./src" });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemovePackage(string packageName, string project, global::Cake.Common.Tools.DotNet.Package.Remove.DotNetPackageRemoveSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemovePackage(Context, packageName, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSearchPackage(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchSettings)">
        /// <summary>
        /// List packages on available from source using specified settings.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>List of packages with their version.</returns>
        /// <example>
        /// <code>
        /// var packageList = DotNetPackageSearch("Cake", new DotNetPackageSearchSettings {
        /// AllVersions = false,
        /// Prerelease = false
        /// });
        /// foreach (var package in packageList)
        /// {
        /// Information("Found package {0}, version {1}", package.Name, package.Version);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchItem> DotNetSearchPackage(string searchTerm, global::Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSearchPackage(Context, searchTerm, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSearchPackage(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// List packages on available from source using specified settings.
        /// </summary>
        /// <param name="searchTerm">The package Id.</param>
        /// <returns>List of packages with their version.</returns>
        /// <example>
        /// <code>
        /// var packageList = DotNetPackageSearch("Cake", new DotNetPackageSearchSettings {
        /// AllVersions = false,
        /// Prerelease = false
        /// });
        /// foreach (var package in packageList)
        /// {
        /// Information("Found package {0}, version {1}", package.Name, package.Version);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchItem> DotNetSearchPackage(string searchTerm)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSearchPackage(Context, searchTerm);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSearchPackage(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchSettings)">
        /// <summary>
        /// List packages on available from source using specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>List of packages with their version.</returns>
        /// <example>
        /// <code>
        /// var packageList = DotNetPackageSearch("Cake", new DotNetPackageSearchSettings {
        /// AllVersions = false,
        /// Prerelease = false
        /// });
        /// foreach (var package in packageList)
        /// {
        /// Information("Found package {0}, version {1}", package.Name, package.Version);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchItem> DotNetSearchPackage(global::Cake.Common.Tools.DotNet.Package.Search.DotNetPackageSearchSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSearchPackage(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetListPackage(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists the package references for a project or solution.
        /// </summary>
        /// <returns>The the package references.</returns>
        /// <example>
        /// <code>
        /// DotNetPackageList output = DotNetListPackage();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Tools.DotNet.Package.List.DotNetPackageList DotNetListPackage()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetListPackage(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetListPackage(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Lists the package references for a project or solution.
        /// </summary>
        /// <param name="project">The project or solution file to operate on. If not specified, the command searches the current directory for one. If more than one solution or project is found, an error is thrown.</param>
        /// <returns>The the package references.</returns>
        /// <example>
        /// <code>
        /// DotNetPackageList output = DotNetListPackage("./src/MyProject/MyProject.csproj");
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Tools.DotNet.Package.List.DotNetPackageList DotNetListPackage(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetListPackage(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetListPackage(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Package.List.DotNetPackageListSettings)">
        /// <summary>
        /// Lists the package references for a project or solution.
        /// </summary>
        /// <param name="project">The project or solution file to operate on. If not specified, the command searches the current directory for one. If more than one solution or project is found, an error is thrown.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The the package references.</returns>
        /// <example>
        /// <code>
        /// var settings = new DotNetPackageListSettings
        /// {
        /// Outdated = true
        /// };
        /// DotNetPackageList output = DotNetListPackage("./src/MyProject/MyProject.csproj", settings);
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Tools.DotNet.Package.List.DotNetPackageList DotNetListPackage(string project, global::Cake.Common.Tools.DotNet.Package.List.DotNetPackageListSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetListPackage(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetPublish(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Publish all projects.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <example>
        /// <code>
        /// DotNetPublish("./src/*");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetPublish(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetPublish(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetPublish(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Publish.DotNetPublishSettings)">
        /// <summary>
        /// Publish all projects.
        /// </summary>
        /// <param name="project">The projects path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetPublishSettings
        /// {
        /// Framework = "netcoreapp2.0",
        /// Configuration = "Release",
        /// OutputDirectory = "./artifacts/"
        /// };
        /// DotNetPublish("./src/*", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetPublish(string project, global::Cake.Common.Tools.DotNet.Publish.DotNetPublishSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetPublish(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Adds project-to-project (P2P) references.
        /// </summary>
        /// <param name="projectReferences">One or more project references to add. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <example>
        /// <code>
        /// DotNetAddReference(GetFiles("./src/*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddReference(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Context, projectReferences);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Reference.Add.DotNetReferenceAddSettings)">
        /// <summary>
        /// Adds project-to-project (P2P) references.
        /// </summary>
        /// <param name="projectReferences">One or more project references to add. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetReferenceAddSettings
        /// {
        /// Framework = "net8.0"
        /// };
        /// DotNetAddReference(GetFiles("./src/*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddReference(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences, global::Cake.Common.Tools.DotNet.Reference.Add.DotNetReferenceAddSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Context, projectReferences, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Cake.Core.ICakeContext,System.String,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Adds project-to-project (P2P) references.
        /// </summary>
        /// <param name="project">The target project file path. If not specified, the command searches the current directory for one.</param>
        /// <param name="projectReferences">One or more project references to add. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <example>
        /// <code>
        /// DotNetAddReference("./app/app.csproj", GetFiles("./src/*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddReference(string project, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Context, project, projectReferences);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Cake.Core.ICakeContext,System.String,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Reference.Add.DotNetReferenceAddSettings)">
        /// <summary>
        /// Adds project-to-project (P2P) references.
        /// </summary>
        /// <param name="project">The target project file path. If not specified, the command searches the current directory for one.</param>
        /// <param name="projectReferences">One or more project references to add. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetReferenceAddSettings
        /// {
        /// Framework = "net8.0"
        /// };
        /// DotNetAddReference("./app/app.csproj", GetFiles("./src/*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetAddReference(string project, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences, global::Cake.Common.Tools.DotNet.Reference.Add.DotNetReferenceAddSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetAddReference(Context, project, projectReferences, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Removes project-to-project (P2P) references.
        /// </summary>
        /// <param name="projectReferences">Project-to-project (P2P) references to remove. You can specify one or multiple projects. Glob patterns are supported on Unix/Linux based terminals.</param>
        /// <example>
        /// <code>
        /// DotNetRemoveReference(GetFiles("./src/*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemoveReference(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Context, projectReferences);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Reference.Remove.DotNetReferenceRemoveSettings)">
        /// <summary>
        /// Removes project-to-project (P2P) references.
        /// </summary>
        /// <param name="projectReferences">Project-to-project (P2P) references to remove. You can specify one or multiple projects. Glob patterns are supported on Unix/Linux based terminals.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetReferenceRemoveSettings
        /// {
        /// Framework = "net8.0"
        /// };
        /// DotNetRemoveReference(GetFiles("./src/*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemoveReference(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences, global::Cake.Common.Tools.DotNet.Reference.Remove.DotNetReferenceRemoveSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Context, projectReferences, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Cake.Core.ICakeContext,System.String,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Removes project-to-project (P2P) references.
        /// </summary>
        /// <param name="project">Target project file. If not specified, the command searches the current directory for one.</param>
        /// <param name="projectReferences">Project-to-project (P2P) references to remove. You can specify one or multiple projects. Glob patterns are supported on Unix/Linux based terminals.</param>
        /// <example>
        /// <code>
        /// DotNetRemoveReference("./app/app.csproj", GetFiles("./src/*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemoveReference(string project, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Context, project, projectReferences);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Cake.Core.ICakeContext,System.String,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Reference.Remove.DotNetReferenceRemoveSettings)">
        /// <summary>
        /// Removes project-to-project (P2P) references.
        /// </summary>
        /// <param name="project">Target project file. If not specified, the command searches the current directory for one.</param>
        /// <param name="projectReferences">Project-to-project (P2P) references to remove. You can specify one or multiple projects. Glob patterns are supported on Unix/Linux based terminals.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetReferenceRemoveSettings
        /// {
        /// Framework = "net8.0"
        /// };
        /// DotNetRemoveReference("./app/app.csproj", GetFiles("./src/*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRemoveReference(string project, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectReferences, global::Cake.Common.Tools.DotNet.Reference.Remove.DotNetReferenceRemoveSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRemoveReference(Context, project, projectReferences, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetListReference(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists project-to-project references.
        /// </summary>
        /// <returns>The list of project-to-project references.</returns>
        /// <example>
        /// <code>
        /// var references = DotNetListReference();
        /// foreach (var reference in references)
        /// {
        /// Information(reference);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DotNetListReference()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetListReference(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetListReference(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Lists project-to-project references.
        /// </summary>
        /// <param name="project">The project file to operate on. If a file is not specified, the command will search the current directory for one.</param>
        /// <returns>The list of project-to-project references.</returns>
        /// <example>
        /// <code>
        /// var references = DotNetListReference("./app/app.csproj");
        /// foreach (var reference in references)
        /// {
        /// Information(reference);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DotNetListReference(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetListReference(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetListReference(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Reference.List.DotNetReferenceListSettings)">
        /// <summary>
        /// Lists project-to-project references.
        /// </summary>
        /// <param name="project">The project file to operate on. If a file is not specified, the command will search the current directory for one.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The list of project-to-project references.</returns>
        /// <example>
        /// <code>
        /// var settings = new DotNetReferenceListSettings
        /// {
        /// Verbosity = DotNetVerbosity.Diagnostic
        /// };
        /// var references = DotNetListReference("./app/app.csproj", settings);
        /// foreach (var reference in references)
        /// {
        /// Information(reference);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DotNetListReference(string project, global::Cake.Common.Tools.DotNet.Reference.List.DotNetReferenceListSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetListReference(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Cake.Core.ICakeContext)">
        /// <summary>
        /// Restore all NuGet Packages.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetRestore();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRestore()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Restore all NuGet Packages in the specified path.
        /// </summary>
        /// <param name="root">Path to the project file to restore.</param>
        /// <example>
        /// <code>
        /// DotNetRestore("./src/MyProject/MyProject.csproj");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRestore(string root)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Context, root);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Restore.DotNetRestoreSettings)">
        /// <summary>
        /// Restore all NuGet Packages with the settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetRestoreSettings
        /// {
        /// Sources = new[] {"https://www.example.com/nugetfeed", "https://www.example.com/nugetfeed2"},
        /// FallbackSources = new[] {"https://www.example.com/fallbacknugetfeed"},
        /// PackagesDirectory = "./packages",
        /// DotNetVerbosity.Information,
        /// DisableParallel = true,
        /// InferRuntimes = new[] {"runtime1", "runtime2"}
        /// };
        /// DotNetRestore(settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRestore(global::Cake.Common.Tools.DotNet.Restore.DotNetRestoreSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Restore.DotNetRestoreSettings)">
        /// <summary>
        /// Restore all NuGet Packages in the specified path with settings.
        /// </summary>
        /// <param name="root">Path to the project file to restore.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetRestoreSettings
        /// {
        /// Sources = new[] {"https://www.example.com/nugetfeed", "https://www.example.com/nugetfeed2"},
        /// FallbackSources = new[] {"https://www.example.com/fallbacknugetfeed"},
        /// PackagesDirectory = "./packages",
        /// DotNetVerbosity.Information,
        /// DisableParallel = true,
        /// InferRuntimes = new[] {"runtime1", "runtime2"}
        /// };
        /// DotNetRestore("./src/MyProject/MyProject.csproj", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRestore(string root, global::Cake.Common.Tools.DotNet.Restore.DotNetRestoreSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRestore(Context, root, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Cake.Core.ICakeContext)">
        /// <summary>
        /// Run all projects.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetRun();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRun()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Run project.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <example>
        /// <code>
        /// DotNetRun("./src/Project");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRun(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <summary>
        /// Run project with path and arguments.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <param name="arguments">The arguments.</param>
        /// <example>
        /// <code>
        /// DotNetRun("./src/Project", "--args");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRun(string project, global::Cake.Core.IO.ProcessArgumentBuilder arguments)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Context, project, arguments);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder,Cake.Common.Tools.DotNet.Run.DotNetRunSettings)">
        /// <summary>
        /// Run project with settings.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <param name="arguments">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetRunSettings
        /// {
        /// Framework = "netcoreapp2.0",
        /// Configuration = "Release"
        /// };
        /// DotNetRun("./src/Project", "--args", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRun(string project, global::Cake.Core.IO.ProcessArgumentBuilder arguments, global::Cake.Common.Tools.DotNet.Run.DotNetRunSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Context, project, arguments, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Run.DotNetRunSettings)">
        /// <summary>
        /// Run project with settings.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetRunSettings
        /// {
        /// Framework = "netcoreapp2.0",
        /// Configuration = "Release"
        /// };
        /// DotNetRun("./src/Project", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetRun(string project, global::Cake.Common.Tools.DotNet.Run.DotNetRunSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetRun(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSDKCheck(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists the latest available version of the .NET SDK and .NET Runtime.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetSDKCheck();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSDKCheck()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSDKCheck(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnList(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists all projects in a solution file.
        /// </summary>
        /// <returns>The list of projects.</returns>
        /// <example>
        /// <code>
        /// var projects = DotNetSlnList();
        /// foreach (var project in projects)
        /// {
        /// Information(project);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DotNetSlnList()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnList(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnList(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Lists all projects in a solution file.
        /// </summary>
        /// <param name="solution">The solution file to use. If this argument is omitted, the command searches the current directory for one. If it finds no solution file or multiple solution files, the command fails.</param>
        /// <returns>The list of projects.</returns>
        /// <example>
        /// <code>
        /// var projects = DotNetSlnList("./app/app.sln");
        /// foreach (var project in projects)
        /// {
        /// Information(project);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DotNetSlnList(global::Cake.Core.IO.FilePath solution)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnList(Context, solution);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnList(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.DotNet.Sln.List.DotNetSlnListSettings)">
        /// <summary>
        /// Lists all projects in a solution file.
        /// </summary>
        /// <param name="solution">The solution file to use. If this argument is omitted, the command searches the current directory for one. If it finds no solution file or multiple solution files, the command fails.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The list of projects.</returns>
        /// <example>
        /// <code>
        /// var settings = new DotNetSlnListSettings
        /// {
        /// Verbosity = DotNetVerbosity.Diagnostic
        /// };
        /// var projects = DotNetSlnList("./app/app.sln");
        /// foreach (var project in projects)
        /// {
        /// Information(project);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DotNetSlnList(global::Cake.Core.IO.FilePath solution, global::Cake.Common.Tools.DotNet.Sln.List.DotNetSlnListSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnList(Context, solution, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Adds one or more projects to the solution file.
        /// </summary>
        /// <param name="projectPath">The path to the project or projects to add to the solution. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <example>
        /// <code>
        /// DotNetSlnAdd(GetFiles("./*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnAdd(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Context, projectPath);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Adds one or more projects to the solution file.
        /// </summary>
        /// <param name="solution">The solution file to use. If it is unspecified, the command searches the current directory for one and fails if there are multiple solution files.</param>
        /// <param name="projectPath">The path to the project or projects to add to the solution. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <example>
        /// <code>
        /// DotNetSlnAdd("app.sln", GetFiles("./*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnAdd(global::Cake.Core.IO.FilePath solution, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Context, solution, projectPath);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Sln.Add.DotNetSlnAddSettings)">
        /// <summary>
        /// Adds one or more projects to the solution file.
        /// </summary>
        /// <param name="projectPath">The path to the project or projects to add to the solution. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetSlnAddSettings
        /// {
        /// SolutionFolder = "libs/math"
        /// };
        /// DotNetSlnAdd(GetFiles("./*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnAdd(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath, global::Cake.Common.Tools.DotNet.Sln.Add.DotNetSlnAddSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Context, projectPath, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Sln.Add.DotNetSlnAddSettings)">
        /// <summary>
        /// Adds one or more projects to the solution file.
        /// </summary>
        /// <param name="solution">The solution file to use. If it is unspecified, the command searches the current directory for one and fails if there are multiple solution files.</param>
        /// <param name="projectPath">The path to the project or projects to add to the solution. Glob patterns are supported on Unix/Linux-based systems.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetSlnAddSettings
        /// {
        /// SolutionFolder = "libs/math"
        /// };
        /// DotNetSlnAdd("app.sln", GetFiles("./*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnAdd(global::Cake.Core.IO.FilePath solution, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath, global::Cake.Common.Tools.DotNet.Sln.Add.DotNetSlnAddSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnAdd(Context, solution, projectPath, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnRemove(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Removes a project or multiple projects from the solution file.
        /// </summary>
        /// <param name="projectPath">The path to the project or projects to remove from the solution.</param>
        /// <example>
        /// <code>
        /// DotNetSlnRemove(GetFiles("./*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnRemove(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnRemove(Context, projectPath);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnRemove(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Removes a project or multiple projects from the solution file.
        /// </summary>
        /// <param name="solution">The solution file to use. If it is unspecified, the command searches the current directory for one and fails if there are multiple solution files.</param>
        /// <param name="projectPath">The path to the project or projects to remove from the solution.</param>
        /// <example>
        /// <code>
        /// DotNetSlnRemove("app.sln", GetFiles("./*.csproj"));
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnRemove(global::Cake.Core.IO.FilePath solution, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnRemove(Context, solution, projectPath);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnRemove(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.Sln.Remove.DotNetSlnRemoveSettings)">
        /// <summary>
        /// Removes a project or multiple projects from the solution file.
        /// </summary>
        /// <param name="solution">The solution file to use. If it is unspecified, the command searches the current directory for one and fails if there are multiple solution files.</param>
        /// <param name="projectPath">The path to the project or projects to remove from the solution.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetSlnRemoveSettings
        /// {
        /// Verbosity = DotNetVerbosity.Diagnostic
        /// };
        /// DotNetSlnRemove("app.sln", GetFiles("./*.csproj"), settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetSlnRemove(global::Cake.Core.IO.FilePath solution, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> projectPath, global::Cake.Common.Tools.DotNet.Sln.Remove.DotNetSlnRemoveSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetSlnRemove(Context, solution, projectPath, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Cake.Core.ICakeContext)">
        /// <summary>
        /// Test project.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetTest();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTest()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Test project with path.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <example>
        /// <para>Specify the path to the .csproj file in the test project.</para>
        /// <code>
        /// DotNetTest("./test/Project.Tests/Project.Tests.csproj");
        /// </code>
        /// <para>You could also specify a task that runs multiple test projects.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// Task("Test")
        /// .Does(() =&gt;
        /// {
        /// var projectFiles = GetFiles("./test/**/*.csproj");
        /// foreach (var file in projectFiles)
        /// {
        /// DotNetTest(file.FullPath);
        /// }
        /// });
        /// </code>
        /// <para>If your test project is using project.json, the project parameter should just be the directory path.</para>
        /// <code>
        /// DotNetTest("./test/Project.Tests/");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTest(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Test.DotNetTestSettings)">
        /// <summary>
        /// Test project with settings.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetTestSettings
        /// {
        /// Configuration = "Release"
        /// };
        /// DotNetTest("./test/Project.Tests/Project.Tests.csproj", settings);
        /// </code>
        /// <para>You could also specify a task that runs multiple test projects.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// Task("Test")
        /// .Does(() =&gt;
        /// {
        /// var settings = new DotNetTestSettings
        /// {
        /// Configuration = "Release"
        /// };
        /// var projectFiles = GetFiles("./test/**/*.csproj");
        /// foreach (var file in projectFiles)
        /// {
        /// DotNetTest(file.FullPath, settings);
        /// }
        /// });
        /// </code>
        /// <para>If your test project is using project.json, the project parameter should just be the directory path.</para>
        /// <code>
        /// var settings = new DotNetTestSettings
        /// {
        /// Configuration = "Release"
        /// };
        /// DotNetTest("./test/Project.Tests/", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTest(string project, global::Cake.Common.Tools.DotNet.Test.DotNetTestSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder,Cake.Common.Tools.DotNet.Test.DotNetTestSettings)">
        /// <summary>
        /// Test project with settings.
        /// </summary>
        /// <param name="project">The project path.</param>
        /// <param name="arguments">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetTestSettings
        /// {
        /// Configuration = "Release"
        /// };
        /// DotNetTest("./test/Project.Tests/Project.Tests.csproj", settings);
        /// </code>
        /// <para>You could also specify a task that runs multiple test projects.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// Task("Test")
        /// .Does(() =&gt;
        /// {
        /// var settings = new DotNetTestSettings
        /// {
        /// Configuration = "Release"
        /// };
        /// var projectFiles = GetFiles("./test/**/*.csproj");
        /// foreach (var file in projectFiles)
        /// {
        /// DotNetTest(file.FullPath, "MSTest.MapInconclusiveToFailed=true", settings);
        /// }
        /// });
        /// </code>
        /// <para>If your test project is using project.json, the project parameter should just be the directory path.</para>
        /// <code>
        /// var settings = new DotNetTestSettings
        /// {
        /// Configuration = "Release"
        /// };
        /// DotNetTest("./test/Project.Tests/", "MSTest.MapInconclusiveToFailed=true", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTest(string project, global::Cake.Core.IO.ProcessArgumentBuilder arguments, global::Cake.Common.Tools.DotNet.Test.DotNetTestSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTest(Context, project, arguments, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetVSTest(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Test one or more projects specified by a path or glob pattern using the VS Test host runner.
        /// </summary>
        /// <param name="testFile">A path to the test file or glob for one or more test files.</param>
        /// <example>
        /// <para>Specify the path to the .csproj file in the test project.</para>
        /// <code>
        /// DotNetVSTest("./test/Project.Tests/bin/Release/netcoreapp2.1/Project.Tests.dll");
        /// </code>
        /// <para>You could also specify a glob pattern to run multiple test projects.</para>
        /// <code>
        /// DotNetVSTest("./**/bin/Release/netcoreapp2.1/*.Tests.dll");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetVSTest(global::Cake.Core.IO.GlobPattern testFile)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetVSTest(Context, testFile);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetVSTest(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.DotNet.VSTest.DotNetVSTestSettings)">
        /// <summary>
        /// Test one or more projects specified by a path or glob pattern with settings using the VS Test host runner.
        /// </summary>
        /// <param name="testFile">A path to the test file or glob for one or more test files.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>Specify the path to the .csproj file in the test project.</para>
        /// <code>
        /// var settings = new DotNetVSTestSettings
        /// {
        /// Framework = "FrameworkCore10",
        /// Platform = "x64"
        /// };
        /// DotNetTest("./test/Project.Tests/bin/Release/netcoreapp2.1/Project.Tests.dll", settings);
        /// </code>
        /// <para>You could also specify a glob pattern to run multiple test projects.</para>
        /// <code>
        /// var settings = new DotNetVSTestSettings
        /// {
        /// Framework = "FrameworkCore10",
        /// Platform = "x64",
        /// Parallel = true
        /// };
        /// DotNetVSTest("./**/bin/Release/netcoreapp2.1/*.Tests.dll", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetVSTest(global::Cake.Core.IO.GlobPattern testFile, global::Cake.Common.Tools.DotNet.VSTest.DotNetVSTestSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetVSTest(Context, testFile, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetVSTest(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DotNet.VSTest.DotNetVSTestSettings)">
        /// <summary>
        /// Test one or more specified projects with settings using the VS Test host runner.
        /// </summary>
        /// <param name="testFiles">The project paths to test.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetVSTestSettings
        /// {
        /// Framework = "FrameworkCore10",
        /// Platform = "x64"
        /// };
        /// DotNetVSTest(new[] { (FilePath)"./test/Project.Tests/bin/Release/netcoreapp2.1/Project.Tests.dll" }, settings);
        /// </code>
        /// <para>You could also specify a task that runs multiple test projects.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// Task("Test")
        /// .Does(() =&gt;
        /// {
        /// var settings = new DotNetVSTestSettings
        /// {
        /// Framework = "FrameworkCore10",
        /// Platform = "x64",
        /// Parallel = true
        /// };
        /// var testFiles = GetFiles("./test/**/bin/Release/netcoreapp2.1/*.Test.dll");
        /// DotNetVSTest(testFiles, settings);
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetVSTest(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> testFiles, global::Cake.Common.Tools.DotNet.VSTest.DotNetVSTestSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetVSTest(Context, testFiles, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Execute an .NET Core Extensibility Tool.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <example>
        /// <code>
        /// DotNetTool("cake");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTool(string command)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Context, command);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolSettings)">
        /// <summary>
        /// Execute an .NET Core Extensibility Tool.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetToolSettings
        /// {
        /// DiagnosticOutput = true
        /// };
        /// DotNetTool("cake", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTool(string command, global::Cake.Common.Tools.DotNet.Tool.DotNetToolSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Context, command, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String)">
        /// <summary>
        /// Execute an .NET Core Extensibility Tool.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <param name="command">The command to execute.</param>
        /// <example>
        /// <code>
        /// DotNetTool("./src/project", "xunit", "-xml report.xml");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTool(global::Cake.Core.IO.FilePath projectPath, string command)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Context, projectPath, command);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <summary>
        /// Execute an .NET Core Extensibility Tool.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="arguments">The arguments.</param>
        /// <example>
        /// <code>
        /// DotNetTool("./src/project", "xunit", "-xml report.xml");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTool(global::Cake.Core.IO.FilePath projectPath, string command, global::Cake.Core.IO.ProcessArgumentBuilder arguments)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Context, projectPath, command, arguments);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String,Cake.Core.IO.ProcessArgumentBuilder,Cake.Common.Tools.DotNet.Tool.DotNetToolSettings)">
        /// <summary>
        /// Execute an .NET Core Extensibility Tool.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="arguments">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetTool("./src/project", "xunit", "-xml report.xml");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetTool(global::Cake.Core.IO.FilePath projectPath, string command, global::Cake.Core.IO.ProcessArgumentBuilder arguments, global::Cake.Common.Tools.DotNet.Tool.DotNetToolSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetTool(Context, projectPath, command, arguments, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Executes a .NET tool package with <c>dotnet tool exec</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-exec">dotnet tool exec</see>.</remarks>
        /// <param name="packageId">The package ID to execute. Use the <c>package@version</c> syntax to request a specific version.</param>
        /// <example>
        /// <code>
        /// DotNetToolExecute("DPI");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolExecute(string packageId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Context, packageId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-exec">dotnet tool exec</see>.</remarks>
        /// <param name="packageId">The package ID to execute. Use the <c>package@version</c> syntax to request a specific version.</param>
        /// <param name="arguments">The arguments forwarded to the tool.</param>
        /// <example>
        /// <code>
        /// var arguments = new ProcessArgumentBuilder().Append("--version");
        /// DotNetToolExecute("DPI", arguments);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolExecute(string packageId, global::Cake.Core.IO.ProcessArgumentBuilder arguments)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Context, packageId, arguments);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder,Cake.Common.Tools.DotNet.Tool.DotNetToolExecuteSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-exec">dotnet tool exec</see>.</remarks>
        /// <param name="packageId">The package ID to execute. Use the <c>package@version</c> syntax to request a specific version.</param>
        /// <param name="arguments">The arguments forwarded to the tool.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var arguments = new ProcessArgumentBuilder().Append("--version");
        /// DotNetToolExecute("DPI", arguments, new DotNetToolExecuteSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolExecute(string packageId, global::Cake.Core.IO.ProcessArgumentBuilder arguments, global::Cake.Common.Tools.DotNet.Tool.DotNetToolExecuteSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Context, packageId, arguments, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolExecuteSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-exec">dotnet tool exec</see>.</remarks>
        /// <param name="packageId">The package ID to execute. Use the <c>package@version</c> syntax to request a specific version.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolExecute("DPI", new DotNetToolExecuteSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolExecute(string packageId, global::Cake.Common.Tools.DotNet.Tool.DotNetToolExecuteSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolExecute(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolInstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Installs a .NET tool package with <c>dotnet tool install</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install">dotnet tool install</see>.</remarks>
        /// <param name="packageId">The package ID to install.</param>
        /// <example>
        /// <code>
        /// DotNetToolInstall("dotnetsay");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolInstall(string packageId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolInstall(Context, packageId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolInstall(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolInstallSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolInstall(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install">dotnet tool install</see>.</remarks>
        /// <param name="packageId">The package ID to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolInstall("DPI", new DotNetToolInstallSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolInstall(string packageId, global::Cake.Common.Tools.DotNet.Tool.DotNetToolInstallSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolInstall(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists .NET tools with <c>dotnet tool list</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-list">dotnet tool list</see>.</remarks>
        /// <example>
        /// <code>
        /// DotNetToolList();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolList()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Tool.DotNetToolListSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Cake.Core.ICakeContext)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-list">dotnet tool list</see>.</remarks>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolList(new DotNetToolListSettings
        /// {
        /// InstallationScope = DotNetToolInstallationScope.Local,
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolList(global::Cake.Common.Tools.DotNet.Tool.DotNetToolListSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Lists a .NET tool package with <c>dotnet tool list</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-list">dotnet tool list</see>.</remarks>
        /// <param name="packageId">The package ID to list.</param>
        /// <example>
        /// <code>
        /// DotNetToolList("dotnetsay");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolList(string packageId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Context, packageId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolListSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-list">dotnet tool list</see>.</remarks>
        /// <param name="packageId">The package ID to list.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolList("DPI", new DotNetToolListSettings
        /// {
        /// InstallationScope = DotNetToolInstallationScope.Local,
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolList(string packageId, global::Cake.Common.Tools.DotNet.Tool.DotNetToolListSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolList(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRestore(Cake.Core.ICakeContext)">
        /// <summary>
        /// Restores .NET tools with <c>dotnet tool restore</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-restore">dotnet tool restore</see>.</remarks>
        /// <example>
        /// <code>
        /// DotNetToolRestore();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolRestore()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRestore(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRestore(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Tool.DotNetToolRestoreSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRestore(Cake.Core.ICakeContext)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-restore">dotnet tool restore</see>.</remarks>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolRestore(new DotNetToolRestoreSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolRestore(global::Cake.Common.Tools.DotNet.Tool.DotNetToolRestoreSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRestore(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Runs a local .NET tool with <c>dotnet tool run</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-run">dotnet tool run</see>.</remarks>
        /// <param name="commandName">The tool command name to run.</param>
        /// <example>
        /// <code>
        /// DotNetToolRun("dotnetsay");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolRun(string commandName)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Context, commandName);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-run">dotnet tool run</see>.</remarks>
        /// <param name="commandName">The tool command name to run.</param>
        /// <param name="arguments">The arguments forwarded to the tool.</param>
        /// <example>
        /// <code>
        /// var arguments = new ProcessArgumentBuilder().Append("--version");
        /// DotNetToolRun("DPI", arguments);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolRun(string commandName, global::Cake.Core.IO.ProcessArgumentBuilder arguments)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Context, commandName, arguments);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String,Cake.Core.IO.ProcessArgumentBuilder,Cake.Common.Tools.DotNet.Tool.DotNetToolRunSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-run">dotnet tool run</see>.</remarks>
        /// <param name="commandName">The tool command name to run.</param>
        /// <param name="arguments">The arguments forwarded to the tool.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolRun("DPI", "--version", new DotNetToolRunSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolRun(string commandName, global::Cake.Core.IO.ProcessArgumentBuilder arguments, global::Cake.Common.Tools.DotNet.Tool.DotNetToolRunSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Context, commandName, arguments, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolRunSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-run">dotnet tool run</see>.</remarks>
        /// <param name="commandName">The tool command name to run.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolRun("DPI", new DotNetToolRunSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolRun(string commandName, global::Cake.Common.Tools.DotNet.Tool.DotNetToolRunSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolRun(Context, commandName, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolSearch(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Searches for .NET tool packages with <c>dotnet tool search</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-search">dotnet tool search</see>.</remarks>
        /// <param name="searchTerm">The search term.</param>
        /// <example>
        /// <code>
        /// DotNetToolSearch("cake");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolSearch(string searchTerm)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolSearch(Context, searchTerm);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolSearch(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolSearchSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolSearch(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-search">dotnet tool search</see>.</remarks>
        /// <param name="searchTerm">The search term.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolSearch("DPI", new DotNetToolSearchSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolSearch(string searchTerm, global::Cake.Common.Tools.DotNet.Tool.DotNetToolSearchSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolSearch(Context, searchTerm, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUninstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Uninstalls a .NET tool package with <c>dotnet tool uninstall</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-uninstall">dotnet tool uninstall</see>.</remarks>
        /// <param name="packageId">The package ID to uninstall.</param>
        /// <example>
        /// <code>
        /// DotNetToolUninstall("dotnetsay");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolUninstall(string packageId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUninstall(Context, packageId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUninstall(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolUninstallSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUninstall(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-uninstall">dotnet tool uninstall</see>.</remarks>
        /// <param name="packageId">The package ID to uninstall.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolUninstall("DPI", new DotNetToolUninstallSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolUninstall(string packageId, global::Cake.Common.Tools.DotNet.Tool.DotNetToolUninstallSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUninstall(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Cake.Core.ICakeContext)">
        /// <summary>
        /// Updates .NET tool packages with <c>dotnet tool update</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-update">dotnet tool update</see>.</remarks>
        /// <example>
        /// <code>
        /// DotNetToolUpdate();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolUpdate()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Tool.DotNetToolUpdateSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Cake.Core.ICakeContext)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-update">dotnet tool update</see>.</remarks>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DotNetToolUpdate(global::Cake.Common.Tools.DotNet.Tool.DotNetToolUpdateSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Updates a .NET tool package with <c>dotnet tool update</c>.
        /// </summary>
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-update">dotnet tool update</see>.</remarks>
        /// <param name="packageId">The package ID to update.</param>
        /// <example>
        /// <code>
        /// DotNetToolUpdate("dotnetsay");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolUpdate(string packageId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Context, packageId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Tool.DotNetToolUpdateSettings)">
        /// <inheritdoc cref="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Cake.Core.ICakeContext,System.String)" />
        /// <remarks>For more information, see <see href="https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-update">dotnet tool update</see>.</remarks>
        /// <param name="packageId">The package ID to update.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// DotNetToolUpdate("DPI", new DotNetToolUpdateSettings
        /// {
        /// WorkingDirectory = "./src"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetToolUpdate(string packageId, global::Cake.Common.Tools.DotNet.Tool.DotNetToolUpdateSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetToolUpdate(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadSearch(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists available workloads.
        /// </summary>
        /// <returns>The list of available workloads.</returns>
        /// <example>
        /// <code>
        /// var workloads = DotNetWorkloadSearch();
        /// foreach (var workload in workloads)
        /// {
        /// Information($"Id: {workload.Id}, Description: {workload.Description}");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Workload.Search.DotNetWorkload> DotNetWorkloadSearch()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadSearch(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadSearch(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Lists available workloads by specifying all or part of the workload ID.
        /// </summary>
        /// <param name="searchString">The workload ID to search for, or part of it.</param>
        /// <returns>The list of available workloads.</returns>
        /// <example>
        /// <code>
        /// var workloads = DotNetWorkloadSearch("maui");
        /// foreach (var workload in workloads)
        /// {
        /// Information($"Id: {workload.Id}, Description: {workload.Description}");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Workload.Search.DotNetWorkload> DotNetWorkloadSearch(string searchString)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadSearch(Context, searchString);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadSearch(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Workload.Search.DotNetWorkloadSearchSettings)">
        /// <summary>
        /// Lists available workloads by specifying all or part of the workload ID.
        /// </summary>
        /// <param name="searchString">The workload ID to search for, or part of it.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The list of available workloads.</returns>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadSearchSettings
        /// {
        /// DotNetVerbosity.Detailed
        /// };
        /// var workloads = DotNetWorkloadSearch("maui", settings);
        /// foreach (var workload in workloads)
        /// {
        /// Information($"Id: {workload.Id}, Description: {workload.Description}");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Workload.Search.DotNetWorkload> DotNetWorkloadSearch(string searchString, global::Cake.Common.Tools.DotNet.Workload.Search.DotNetWorkloadSearchSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadSearch(Context, searchString, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUninstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Uninstalls a specified workload.
        /// </summary>
        /// <param name="workloadId">The workload ID to uninstall.</param>
        /// <example>
        /// <code>
        /// DotNetWorkloadUninstall("maui");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadUninstall(string workloadId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUninstall(Context, workloadId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUninstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Uninstalls one or more workloads.
        /// </summary>
        /// <param name="workloadIds">The workload ID or multiple IDs to uninstall.</param>
        /// <example>
        /// <code>
        /// DotNetWorkloadUninstall(new string[] { "maui", "maui-desktop", "maui-mobile" });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadUninstall(global::System.Collections.Generic.IEnumerable<string> workloadIds)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUninstall(Context, workloadIds);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Installs a specified optional workload.
        /// </summary>
        /// <param name="workloadId">The workload ID to install.</param>
        /// <example>
        /// <code>
        /// DotNetWorkloadInstall("maui");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadInstall(string workloadId)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Context, workloadId);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Workload.Install.DotNetWorkloadInstallSettings)">
        /// <summary>
        /// Installs a specified optional workload.
        /// </summary>
        /// <param name="workloadId">The workload ID to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadInstallSettings
        /// {
        /// IncludePreviews = true,
        /// NoCache = true
        /// };
        /// DotNetWorkloadInstall("maui", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadInstall(string workloadId, global::Cake.Common.Tools.DotNet.Workload.Install.DotNetWorkloadInstallSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Context, workloadId, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Installs one or more optional workloads.
        /// </summary>
        /// <param name="workloadIds">The workload ID or multiple IDs to install.</param>
        /// <example>
        /// <code>
        /// DotNetWorkloadInstall(new string[] { "maui", "maui-desktop", "maui-mobile" });
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadInstall(global::System.Collections.Generic.IEnumerable<string> workloadIds)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Context, workloadIds);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.DotNet.Workload.Install.DotNetWorkloadInstallSettings)">
        /// <summary>
        /// Installs one or more optional workloads.
        /// </summary>
        /// <param name="workloadIds">The workload ID or multiple IDs to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadInstallSettings
        /// {
        /// IncludePreviews = true,
        /// NoCache = true
        /// };
        /// DotNetWorkloadInstall(new string[] { "maui", "maui-desktop", "maui-mobile" }, settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadInstall(global::System.Collections.Generic.IEnumerable<string> workloadIds, global::Cake.Common.Tools.DotNet.Workload.Install.DotNetWorkloadInstallSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadInstall(Context, workloadIds, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadList(Cake.Core.ICakeContext)">
        /// <summary>
        /// Lists all installed workloads.
        /// </summary>
        /// <returns>The list of installed workloads.</returns>
        /// <example>
        /// <code>
        /// var workloadIds = DotNetWorkloadList();
        /// foreach (var workloadId in workloadIds)
        /// {
        /// Information($"Installed Workload Id: {workloadId}");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Workload.List.DotNetWorkloadListItem> DotNetWorkloadList()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadList(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadList(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Workload.List.DotNetWorkloadListSettings)">
        /// <summary>
        /// Lists all installed workloads.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The list of installed workloads.</returns>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadListSettings
        /// {
        /// Verbosity = DotNetVerbosity.Detailed
        /// };
        /// var workloads = DotNetWorkloadList(settings);
        /// foreach (var workload in workloads)
        /// {
        /// Information($"Installed Workload Id: {workload.Id}\t Manifest Version: {workload.ManifestVersion}\t Installation Source: {workload.InstallationSource}");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.DotNet.Workload.List.DotNetWorkloadListItem> DotNetWorkloadList(global::Cake.Common.Tools.DotNet.Workload.List.DotNetWorkloadListSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadList(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRepair(Cake.Core.ICakeContext)">
        /// <summary>
        /// Repairs all workloads installations.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetWorkloadRepair();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadRepair()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRepair(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRepair(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Workload.Repair.DotNetWorkloadRepairSettings)">
        /// <summary>
        /// Repairs all workloads installations.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadRepairSettings
        /// {
        /// IncludePreviews = true,
        /// NoCache = true
        /// };
        /// DotNetWorkloadRepair(settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadRepair(global::Cake.Common.Tools.DotNet.Workload.Repair.DotNetWorkloadRepairSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRepair(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUpdate(Cake.Core.ICakeContext)">
        /// <summary>
        /// Updates all installed workloads to the newest available version.
        /// </summary>
        /// <example>
        /// <code>
        /// DotNetWorkloadUpdate();
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadUpdate()
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUpdate(Context);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUpdate(Cake.Core.ICakeContext,Cake.Common.Tools.DotNet.Workload.Update.DotNetWorkloadUpdateSettings)">
        /// <summary>
        /// Updates all installed workloads to the newest available version.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadUpdateSettings
        /// {
        /// IncludePreviews = true,
        /// NoCache = true
        /// };
        /// DotNetWorkloadUpdate(settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadUpdate(global::Cake.Common.Tools.DotNet.Workload.Update.DotNetWorkloadUpdateSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadUpdate(Context, settings);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRestore(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Installs workloads needed for a project or a solution.
        /// </summary>
        /// <param name="project">The project or solution file to install workloads for.</param>
        /// <example>
        /// <code>
        /// DotNetWorkloadRestore("./src/project");
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadRestore(string project)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRestore(Context, project);

        /// <member name="M:Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRestore(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.DotNet.Workload.Restore.DotNetWorkloadRestoreSettings)">
        /// <summary>
        /// Installs workloads needed for a project or a solution.
        /// </summary>
        /// <param name="project">The project or solution file to install workloads for.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var settings = new DotNetWorkloadRestoreSettings
        /// {
        /// IncludePreviews = true,
        /// NoCache = true
        /// };
        /// DotNetWorkloadRestore("./src/project", settings);
        /// </code>
        /// </example>
        /// </member>
        public static void DotNetWorkloadRestore(string project, global::Cake.Common.Tools.DotNet.Workload.Restore.DotNetWorkloadRestoreSettings settings)
            => global::Cake.Common.Tools.DotNet.DotNetAliases.DotNetWorkloadRestore(Context, project, settings);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Analyses the specified file with ReSharper's DupFinder.
        /// The file can either be a solution/project or a source file.
        /// </summary>
        /// <param name="file">The file to analyze.</param>
        /// <example>
        /// <code>
        /// DupFinder("./src/MySolution.sln");
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinder(global::Cake.Core.IO.FilePath file)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Context, file);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.DupFinder.DupFinderSettings)">
        /// <summary>
        /// Analyses the specified file with ReSharper's DupFinder using the specified settings.
        /// The file can either be a solution/project or a source file.
        /// </summary>
        /// <param name="file">The file to analyze.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var buildOutputDirectory = Directory("./.build");
        /// var resharperReportsDirectory = buildOutputDirectory + Directory("_ReSharperReports");
        /// var rootDirectoryPath = MakeAbsolute(Context.Environment.WorkingDirectory);
        /// DupFinder("./src/MySolution.sln", new DupFinderSettings {
        /// ShowStats = true,
        /// ShowText = true,
        /// ExcludePattern = new String[]
        /// {
        /// rootDirectoryPath + "/**/*Designer.cs",
        /// },
        /// OutputFile = resharperReportsDirectory + File("dupfinder-output.xml"),
        /// ThrowExceptionOnFindingDuplicates = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinder(global::Cake.Core.IO.FilePath file, global::Cake.Common.Tools.DupFinder.DupFinderSettings settings)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Context, file, settings);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Analyses the specified projects with ReSharper's DupFinder.
        /// The files can either be solutions and projects or a source files.
        /// </summary>
        /// <param name="files">The files to analyze.</param>
        /// <example>
        /// <code>
        /// var projects = GetFiles("./src/**/*.csproj");
        /// DupFinder(projects);
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinder(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> files)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Context, files);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.DupFinder.DupFinderSettings)">
        /// <summary>
        /// Analyses the specified projects with ReSharper's DupFinder using the specified settings.
        /// The files can either be solutions and projects or a source files.
        /// </summary>
        /// <param name="files">The files to analyze.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var buildOutputDirectory = Directory("./.build");
        /// var resharperReportsDirectory = buildOutputDirectory + Directory("_ReSharperReports");
        /// var rootDirectoryPath = MakeAbsolute(Context.Environment.WorkingDirectory);
        /// var projects = GetFiles("./src/**/*.csproj");
        /// DupFinder(projects, new DupFinderSettings {
        /// ShowStats = true,
        /// ShowText = true,
        /// ExcludePattern = new String[]
        /// {
        /// rootDirectoryPath + "/**/*Designer.cs",
        /// },
        /// OutputFile = resharperReportsDirectory + File("dupfinder-output.xml"),
        /// ThrowExceptionOnFindingDuplicates = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinder(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> files, global::Cake.Common.Tools.DupFinder.DupFinderSettings settings)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Context, files, settings);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Analyses all files matching the specified pattern with ReSharper's DupFinder.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// DupFinder("*.cs");
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinder(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Context, pattern);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.DupFinder.DupFinderSettings)">
        /// <summary>
        /// Analyses all files matching the specified pattern with ReSharper's DupFinder,
        /// using the specified settings.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var buildOutputDirectory = Directory("./.build");
        /// var resharperReportsDirectory = buildOutputDirectory + Directory("_ReSharperReports");
        /// DupFinder("*.cs", new DupFinderSettings {
        /// OutputFile = resharperReportsDirectory + File("dupfinder-output.xml"),
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinder(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.DupFinder.DupFinderSettings settings)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinder(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinderFromConfig(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Runs ReSharper's DupFinder using the provided config file.
        /// </summary>
        /// <param name="configFile">The config file.</param>
        /// <example>
        /// <code>
        /// DupFinderFromConfig("./src/dupfinder.config");
        /// </code>
        /// </example>
        /// </member>
        public static void DupFinderFromConfig(global::Cake.Core.IO.FilePath configFile)
            => global::Cake.Common.Tools.DupFinder.DupFinderAliases.DupFinderFromConfig(Context, configFile);

        /// <member name="M:Cake.Common.Tools.Fixie.FixieAliases.Fixie(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all Fixie tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// Fixie("./src/UnitTests/*.dll");
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// </member>
        public static void Fixie(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.Fixie.FixieAliases.Fixie(Context, pattern);

        /// <member name="M:Cake.Common.Tools.Fixie.FixieAliases.Fixie(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.Fixie.FixieSettings)">
        /// <summary>
        /// Runs all Fixie tests in the assemblies matching the specified pattern,
        /// using the specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// Fixie("./src/UnitTests/*.dll", new FixieSettings {
        /// NUnitXml = TestResult.xml
        /// });
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void Fixie(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.Fixie.FixieSettings settings)
            => global::Cake.Common.Tools.Fixie.FixieAliases.Fixie(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.Fixie.FixieAliases.Fixie(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Runs all Fixie tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = new [] {
        /// "UnitTests1.dll",
        /// "UnitTests2.dll"
        /// };
        /// Fixie(assemblies);
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// </member>
        public static void Fixie(global::System.Collections.Generic.IEnumerable<string> assemblies)
            => global::Cake.Common.Tools.Fixie.FixieAliases.Fixie(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.Fixie.FixieAliases.Fixie(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all Fixie tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = GetFiles("./src/UnitTests/*.dll");
        /// Fixie(assemblies);
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// </member>
        public static void Fixie(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies)
            => global::Cake.Common.Tools.Fixie.FixieAliases.Fixie(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.Fixie.FixieAliases.Fixie(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.Fixie.FixieSettings)">
        /// <summary>
        /// Runs all Fixie tests in the specified assemblies,
        /// using the specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = new [] {
        /// "UnitTests1.dll",
        /// "UnitTests2.dll"
        /// };
        /// Fixie(assemblies, new FixieSettings {
        /// NUnitXml = TestResult.xml
        /// });
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void Fixie(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.Fixie.FixieSettings settings)
            => global::Cake.Common.Tools.Fixie.FixieAliases.Fixie(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.Fixie.FixieAliases.Fixie(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.Fixie.FixieSettings)">
        /// <summary>
        /// Runs all Fixie tests in the specified assemblies,
        /// using the specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = GetFiles("./src/UnitTests/*.dll");
        /// Fixie(assemblies, new FixieSettings {
        /// NUnitXml = TestResult.xml
        /// });
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void Fixie(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.Fixie.FixieSettings settings)
            => global::Cake.Common.Tools.Fixie.FixieAliases.Fixie(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Update the pdb file to link all sources.
        /// This will allow anyone to step through the source code while debugging without a symbol source server.
        /// </summary>
        /// <param name="pdbFilePath">The PDB File to analyze.</param>
        /// <example>
        /// <code>
        /// GitLink3("C:/temp/solution/bin/my.pdb");
        /// </code>
        /// </example>
        /// </member>
        public static void GitLink3(global::Cake.Core.IO.FilePath pdbFilePath)
            => global::Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Context, pdbFilePath);

        /// <member name="M:Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.GitLink.GitLink3Settings)">
        /// <summary>
        /// Update the pdb file to link all sources.
        /// This will allow anyone to step through the source code while debugging without a symbol source server.
        /// </summary>
        /// <param name="pdbFilePath">The PDB File to analyze.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitLink3("C:/temp/solution/bin/my.pdb", new GitLink3Settings {
        /// RepositoryUrl = "http://mydomain.com",
        /// ShaHash       = "abcdef"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitLink3(global::Cake.Core.IO.FilePath pdbFilePath, global::Cake.Common.Tools.GitLink.GitLink3Settings settings)
            => global::Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Context, pdbFilePath, settings);

        /// <member name="M:Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Update the pdb files to link all sources.
        /// This will allow anyone to step through the source code while debugging without a symbol source server.
        /// </summary>
        /// <param name="pdbFiles">The PDB File collection to analyze.</param>
        /// <example>
        /// <code>
        /// GitLink3("C:/temp/solution/bin/**/*.pdb");
        /// </code>
        /// </example>
        /// </member>
        public static void GitLink3(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> pdbFiles)
            => global::Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Context, pdbFiles);

        /// <member name="M:Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.GitLink.GitLink3Settings)">
        /// <summary>
        /// Update the pdb files to link all sources.
        /// This will allow anyone to step through the source code while debugging without a symbol source server.
        /// </summary>
        /// <param name="pdbFiles">The PDB File collection to analyze.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitLink3("C:/temp/solution/bin/**/*.pdb", new GitLink3Settings {
        /// RepositoryUrl = "http://mydomain.com",
        /// ShaHash       = "abcdef"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitLink3(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> pdbFiles, global::Cake.Common.Tools.GitLink.GitLink3Settings settings)
            => global::Cake.Common.Tools.GitLink.GitLink3Aliases.GitLink3(Context, pdbFiles, settings);

        /// <member name="M:Cake.Common.Tools.GitLink.GitLinkAliases.GitLink(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Update pdb files to link all sources.
        /// This will allow anyone to step through the source code while debugging without a symbol source server.
        /// </summary>
        /// <param name="repositoryRootPath">The Solution File to analyze.</param>
        /// <example>
        /// <code>
        /// GitLink("C:/temp/solution");
        /// </code>
        /// </example>
        /// </member>
        public static void GitLink(global::Cake.Core.IO.DirectoryPath repositoryRootPath)
            => global::Cake.Common.Tools.GitLink.GitLinkAliases.GitLink(Context, repositoryRootPath);

        /// <member name="M:Cake.Common.Tools.GitLink.GitLinkAliases.GitLink(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Common.Tools.GitLink.GitLinkSettings)">
        /// <summary>
        /// Update pdb files to link all sources, using specified settings.
        /// This will allow anyone to step through the source code while debugging without a symbol source server.
        /// </summary>
        /// <param name="repositoryRootPath">The path to the Root of the Repository to analyze.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitLink("C:/temp/solution", new GitLinkSettings {
        /// RepositoryUrl = "http://mydomain.com",
        /// Branch        = "master",
        /// ShaHash       = "abcdef",
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitLink(global::Cake.Core.IO.DirectoryPath repositoryRootPath, global::Cake.Common.Tools.GitLink.GitLinkSettings settings)
            => global::Cake.Common.Tools.GitLink.GitLinkAliases.GitLink(Context, repositoryRootPath, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerCreate(Cake.Core.ICakeContext,System.String,System.String,System.String)">
        /// <summary>
        /// Creates a Package Release.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerCreate("token", "owner", "repo");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerCreate(string token, string owner, string repository)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerCreate(Context, token, owner, repository);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerCreate(Cake.Core.ICakeContext,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.Create.GitReleaseManagerCreateSettings)">
        /// <summary>
        /// Creates a Package Release using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerCreate("token", "owner", "repo", new GitReleaseManagerCreateSettings {
        /// Milestone         = "0.1.0",
        /// Prerelease        = false,
        /// Assets            = "c:/temp/asset1.txt,c:/temp/asset2.txt",
        /// TargetCommitish   = "master",
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// <example>
        /// <code>
        /// GitReleaseManagerCreate("token", "owner", "repo", new GitReleaseManagerCreateSettings {
        /// Name              = "0.1.0",
        /// InputFilePath     = "c:/repo/releasenotes.md",
        /// Prerelease        = false,
        /// Assets            = "c:/temp/asset1.txt,c:/temp/asset2.txt",
        /// TargetCommitish   = "master",
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerCreate(string token, string owner, string repository, global::Cake.Common.Tools.GitReleaseManager.Create.GitReleaseManagerCreateSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerCreate(Context, token, owner, repository, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerAddAssets(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,System.String)">
        /// <summary>
        /// Add Assets to an existing release.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="tagName">The tag name.</param>
        /// <param name="assets">The assets.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerAddAssets("token", "owner", "repo", "0.1.0", "c:/temp/asset1.txt,c:/temp/asset2.txt");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerAddAssets(string token, string owner, string repository, string tagName, string assets)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerAddAssets(Context, token, owner, repository, tagName, assets);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerAddAssets(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.AddAssets.GitReleaseManagerAddAssetsSettings)">
        /// <summary>
        /// Add Assets to an existing release using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="tagName">The tag name.</param>
        /// <param name="assets">The assets.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerAddAssets("token", "owner", "repo", "0.1.0", "c:/temp/asset1.txt,c:/temp/asset2.txt", new GitReleaseManagerAddAssetsSettings {
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerAddAssets(string token, string owner, string repository, string tagName, string assets, global::Cake.Common.Tools.GitReleaseManager.AddAssets.GitReleaseManagerAddAssetsSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerAddAssets(Context, token, owner, repository, tagName, assets, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerClose(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String)">
        /// <summary>
        /// Closes the milestone associated with a release.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="milestone">The milestone.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerClose("token", "owner", "repo", "0.1.0");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerClose(string token, string owner, string repository, string milestone)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerClose(Context, token, owner, repository, milestone);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerClose(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.Close.GitReleaseManagerCloseMilestoneSettings)">
        /// <summary>
        /// Closes the milestone associated with a release using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="milestone">The milestone.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerClose("token", "owner", "repo", "0.1.0", new GitReleaseManagerCloseMilestoneSettings {
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerClose(string token, string owner, string repository, string milestone, global::Cake.Common.Tools.GitReleaseManager.Close.GitReleaseManagerCloseMilestoneSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerClose(Context, token, owner, repository, milestone, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerPublish(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String)">
        /// <summary>
        /// Publishes the release.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="tagName">The tag name.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerPublish("token", "owner", "repo", "0.1.0");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerPublish(string token, string owner, string repository, string tagName)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerPublish(Context, token, owner, repository, tagName);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerPublish(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.Publish.GitReleaseManagerPublishSettings)">
        /// <summary>
        /// Publishes the release using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="tagName">The tag name.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerPublish("token", "owner", "repo", "0.1.0", new GitReleaseManagerPublishSettings {
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerPublish(string token, string owner, string repository, string tagName, global::Cake.Common.Tools.GitReleaseManager.Publish.GitReleaseManagerPublishSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerPublish(Context, token, owner, repository, tagName, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerExport(Cake.Core.ICakeContext,System.String,System.String,System.String,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Exports the release notes.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="fileOutputPath">The output file path.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerExport("token", "owner", "repo", "c:/temp/releasenotes.md")
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerExport(string token, string owner, string repository, global::Cake.Core.IO.FilePath fileOutputPath)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerExport(Context, token, owner, repository, fileOutputPath);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerExport(Cake.Core.ICakeContext,System.String,System.String,System.String,Cake.Core.IO.FilePath,Cake.Common.Tools.GitReleaseManager.Export.GitReleaseManagerExportSettings)">
        /// <summary>
        /// Exports the release notes using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="fileOutputPath">The output file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerExport("token", "owner", "repo", "c:/temp/releasenotes.md", new GitReleaseManagerExportSettings {
        /// TagName           = "0.1.0",
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerExport(string token, string owner, string repository, global::Cake.Core.IO.FilePath fileOutputPath, global::Cake.Common.Tools.GitReleaseManager.Export.GitReleaseManagerExportSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerExport(Context, token, owner, repository, fileOutputPath, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerLabel(Cake.Core.ICakeContext,System.String,System.String,System.String)">
        /// <summary>
        /// Deletes and creates labels.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerLabel("token", "owner", "repo");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerLabel(string token, string owner, string repository)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerLabel(Context, token, owner, repository);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerLabel(Cake.Core.ICakeContext,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.Label.GitReleaseManagerLabelSettings)">
        /// <summary>
        /// Deletes and creates labels using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerLabel("token", "owner", "repo", new GitReleaseManagerLabelSettings {
        /// LogFilePath = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerLabel(string token, string owner, string repository, global::Cake.Common.Tools.GitReleaseManager.Label.GitReleaseManagerLabelSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerLabel(Context, token, owner, repository, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerOpen(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String)">
        /// <summary>
        /// Opens the milestone associated with a release.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="milestone">The milestone.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerOpen("token", "owner", "repo", "0.1.0");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerOpen(string token, string owner, string repository, string milestone)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerOpen(Context, token, owner, repository, milestone);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerOpen(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.Open.GitReleaseManagerOpenMilestoneSettings)">
        /// <summary>
        /// Opens the milestone associated with a release using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="milestone">The milestone.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerOpen("token", "owner", "repo", "0.1.0", new GitReleaseManagerOpenMilestoneSettings {
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerOpen(string token, string owner, string repository, string milestone, global::Cake.Common.Tools.GitReleaseManager.Open.GitReleaseManagerOpenMilestoneSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerOpen(Context, token, owner, repository, milestone, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerDiscard(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String)">
        /// <summary>
        /// Discards a Release.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="milestone">The milestone.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerDiscard("token", "owner", "repo", "0.1.0");
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerDiscard(string token, string owner, string repository, string milestone)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerDiscard(Context, token, owner, repository, milestone);

        /// <member name="M:Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerDiscard(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,Cake.Common.Tools.GitReleaseManager.Discard.GitReleaseManagerDiscardSettings)">
        /// <summary>
        /// Discards a Release using the specified settings.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="repository">The repository.</param>
        /// <param name="milestone">The milestone.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseManagerDiscard("token", "owner", "repo", "0.1.0", new GitReleaseManagerDiscardSettings {
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// <example>
        /// <code>
        /// GitReleaseManagerDiscard("token", "owner", "repo", "0.1.0", new GitReleaseManagerDiscardSettings {
        /// TargetDirectory   = "c:/repo",
        /// LogFilePath       = "c:/temp/grm.log"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseManagerDiscard(string token, string owner, string repository, string milestone, global::Cake.Common.Tools.GitReleaseManager.Discard.GitReleaseManagerDiscardSettings settings)
            => global::Cake.Common.Tools.GitReleaseManager.GitReleaseManagerAliases.GitReleaseManagerDiscard(Context, token, owner, repository, milestone, settings);

        /// <member name="M:Cake.Common.Tools.GitReleaseNotes.GitReleaseNotesAliases.GitReleaseNotes(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.GitReleaseNotes.GitReleaseNotesSettings)">
        /// <summary>
        /// Generates a set of release notes based on the commit history of the repository and specified settings.
        /// </summary>
        /// <param name="outputFile">The output file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// GitReleaseNotes("c:/temp/releasenotes.md", new GitReleaseNotesSettings {
        /// WorkingDirectory         = "c:/temp",
        /// Verbose                  = true,
        /// IssueTracker             = IssueTracker.GitHub,
        /// AllTags                  = true,
        /// RepoUserName             = "bob",
        /// RepoPassword             = "password",
        /// RepoUrl                  = "http://myrepo.co.uk",
        /// RepoBranch               = "master",
        /// IssueTrackerUrl          = "http://myissuetracker.co.uk",
        /// IssueTrackerUserName     = "bob",
        /// IssueTrackerPassword     = "password",
        /// IssueTrackerProjectId    = "1234",
        /// Categories               = "Category1",
        /// Version                  = "1.2.3.4",
        /// AllLabels                = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void GitReleaseNotes(global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.GitReleaseNotes.GitReleaseNotesSettings settings)
            => global::Cake.Common.Tools.GitReleaseNotes.GitReleaseNotesAliases.GitReleaseNotes(Context, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.GitVersion.GitVersionAliases.GitVersion(Cake.Core.ICakeContext)">
        /// <summary>
        /// Retrieves the GitVersion output.
        /// </summary>
        /// <returns>The Git version info.</returns>
        /// <example>
        /// <para>Update the assembly info files for the project.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("UpdateAssemblyInfo")
        /// .Does(() =>
        /// {
        /// GitVersion(new GitVersionSettings {
        /// UpdateAssemblyInfo = true
        /// });
        /// });
        /// ]]>
        /// </code>
        /// <para>Get the Git version info for the project using a dynamic repository.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("GetVersionInfo")
        /// .Does(() =>
        /// {
        /// var result = GitVersion(new GitVersionSettings {
        /// UserName = "MyUser",
        /// Password = "MyPassword,
        /// Url = "http://git.myhost.com/myproject.git"
        /// Branch = "develop"
        /// Commit = EnvironmentVariable("MY_COMMIT")
        /// });
        /// // Use result for building NuGet packages, setting build server version, etc...
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Tools.GitVersion.GitVersion GitVersion()
            => global::Cake.Common.Tools.GitVersion.GitVersionAliases.GitVersion(Context);

        /// <member name="M:Cake.Common.Tools.GitVersion.GitVersionAliases.GitVersion(Cake.Core.ICakeContext,Cake.Common.Tools.GitVersion.GitVersionSettings)">
        /// <summary>
        /// Retrieves the GitVersion output.
        /// </summary>
        /// <param name="settings">The GitVersion settings.</param>
        /// <returns>The Git version info.</returns>
        /// <example>
        /// <para>Update the assembly info files for the project.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("UpdateAssemblyInfo")
        /// .Does(() =>
        /// {
        /// GitVersion(new GitVersionSettings {
        /// UpdateAssemblyInfo = true
        /// });
        /// });
        /// ]]>
        /// </code>
        /// <para>Get the Git version info for the project using a dynamic repository.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("GetVersionInfo")
        /// .Does(() =>
        /// {
        /// var result = GitVersion(new GitVersionSettings {
        /// UserName = "MyUser",
        /// Password = "MyPassword,
        /// Url = "http://git.myhost.com/myproject.git"
        /// Branch = "develop"
        /// Commit = EnvironmentVariable("MY_COMMIT")
        /// });
        /// // Use result for building NuGet packages, setting build server version, etc...
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Common.Tools.GitVersion.GitVersion GitVersion(global::Cake.Common.Tools.GitVersion.GitVersionSettings settings)
            => global::Cake.Common.Tools.GitVersion.GitVersionAliases.GitVersion(Context, settings);

        /// <member name="M:Cake.Common.Tools.ILMerge.ILMergeAliases.ILMerge(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Merges the specified assemblies.
        /// </summary>
        /// <param name="outputFile">The output file.</param>
        /// <param name="primaryAssembly">The primary assembly.</param>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// <example>
        /// <code>
        /// var assemblyPaths = GetFiles("./**/Cake.*.dll");
        /// ILMerge("./MergedCake.exe", "./Cake.exe", assemblyPaths);
        /// </code>
        /// </example>
        /// </member>
        public static void ILMerge(global::Cake.Core.IO.FilePath outputFile, global::Cake.Core.IO.FilePath primaryAssembly, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths)
            => global::Cake.Common.Tools.ILMerge.ILMergeAliases.ILMerge(Context, outputFile, primaryAssembly, assemblyPaths);

        /// <member name="M:Cake.Common.Tools.ILMerge.ILMergeAliases.ILMerge(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.ILMerge.ILMergeSettings)">
        /// <summary>
        /// Merges the specified assemblies.
        /// </summary>
        /// <param name="outputFile">The output file.</param>
        /// <param name="primaryAssembly">The primary assembly.</param>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var assemblyPaths = GetFiles("./**/Cake.*.dll");
        /// ILMerge(
        /// "./MergedCake.exe",
        /// "./Cake.exe",
        /// assemblyPaths,
        /// new ILMergeSettings { Internalize = true });
        /// </code>
        /// </example>
        /// </member>
        public static void ILMerge(global::Cake.Core.IO.FilePath outputFile, global::Cake.Core.IO.FilePath primaryAssembly, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths, global::Cake.Common.Tools.ILMerge.ILMergeSettings settings)
            => global::Cake.Common.Tools.ILMerge.ILMergeAliases.ILMerge(Context, outputFile, primaryAssembly, assemblyPaths, settings);

        /// <member name="M:Cake.Common.Tools.ILRepack.ILRepackAliases.ILRepack(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Merges the specified assemblies.
        /// </summary>
        /// <param name="outputFile">The output file.</param>
        /// <param name="primaryAssembly">The primary assembly.</param>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// <example>
        /// <code>
        /// var assemblyPaths = GetFiles("./**/Cake.*.dll");
        /// ILRepack("./MergedCake.exe", "./Cake.exe", assemblyPaths);
        /// </code>
        /// </example>
        /// </member>
        public static void ILRepack(global::Cake.Core.IO.FilePath outputFile, global::Cake.Core.IO.FilePath primaryAssembly, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths)
            => global::Cake.Common.Tools.ILRepack.ILRepackAliases.ILRepack(Context, outputFile, primaryAssembly, assemblyPaths);

        /// <member name="M:Cake.Common.Tools.ILRepack.ILRepackAliases.ILRepack(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.ILRepack.ILRepackSettings)">
        /// <summary>
        /// Merges the specified assemblies.
        /// </summary>
        /// <param name="outputFile">The output file.</param>
        /// <param name="primaryAssembly">The primary assembly.</param>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var assemblyPaths = GetFiles("./**/Cake.*.dll");
        /// ILRepack(
        /// "./MergedCake.exe",
        /// "./Cake.exe",
        /// assemblyPaths,
        /// new ILRepackSettings { Internalize = true });
        /// </code>
        /// </example>
        /// </member>
        public static void ILRepack(global::Cake.Core.IO.FilePath outputFile, global::Cake.Core.IO.FilePath primaryAssembly, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths, global::Cake.Common.Tools.ILRepack.ILRepackSettings settings)
            => global::Cake.Common.Tools.ILRepack.ILRepackAliases.ILRepack(Context, outputFile, primaryAssembly, assemblyPaths, settings);

        /// <member name="M:Cake.Common.Tools.InnoSetup.InnoSetupAliases.InnoSetup(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Compiles the given Inno Setup script using the default settings.
        /// </summary>
        /// <param name="scriptFile">The path to the <c>.iss</c> script file to compile.</param>
        /// <example>
        /// <code>
        /// InnoSetup("./src/Cake.iss");
        /// </code>
        /// </example>
        /// </member>
        public static void InnoSetup(global::Cake.Core.IO.FilePath scriptFile)
            => global::Cake.Common.Tools.InnoSetup.InnoSetupAliases.InnoSetup(Context, scriptFile);

        /// <member name="M:Cake.Common.Tools.InnoSetup.InnoSetupAliases.InnoSetup(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.InnoSetup.InnoSetupSettings)">
        /// <summary>
        /// Compiles the given Inno Setup script using the given <paramref name="settings" />.
        /// </summary>
        /// <param name="scriptFile">The path to the <c>.iss</c> script file to compile.</param>
        /// <param name="settings">The <see cref="T:Cake.Common.Tools.InnoSetup.InnoSetupSettings" /> to use.</param>
        /// <example>
        /// <code>
        /// InnoSetup("./src/Cake.iss", new InnoSetupSettings {
        /// OutputDirectory = outputDirectory
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void InnoSetup(global::Cake.Core.IO.FilePath scriptFile, global::Cake.Common.Tools.InnoSetup.InnoSetupSettings settings)
            => global::Cake.Common.Tools.InnoSetup.InnoSetupAliases.InnoSetup(Context, scriptFile, settings);

        /// <member name="M:Cake.Common.Tools.InspectCode.InspectCodeAliases.InspectCode(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Analyses the specified solution with ReSharper's InspectCode.
        /// </summary>
        /// <param name="solution">The solution.</param>
        /// <example>
        /// <code>
        /// InspectCode("./src/MySolution.sln");
        /// </code>
        /// </example>
        /// </member>
        public static void InspectCode(global::Cake.Core.IO.FilePath solution)
            => global::Cake.Common.Tools.InspectCode.InspectCodeAliases.InspectCode(Context, solution);

        /// <member name="M:Cake.Common.Tools.InspectCode.InspectCodeAliases.InspectCode(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.InspectCode.InspectCodeSettings)">
        /// <summary>
        /// Analyses the specified solution with ReSharper's InspectCode,
        /// using the specified settings.
        /// </summary>
        /// <param name="solution">The solution.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var buildOutputDirectory = Directory("./.build");
        /// var resharperReportsDirectory = buildOutputDirectory + Directory("_ReSharperReports");
        /// var msBuildProperties = new Dictionary&lt;string, string&gt;();
        /// msBuildProperties.Add("configuration", configuration);
        /// msBuildProperties.Add("platform", "AnyCPU");
        /// InspectCode("./MySolution.sln", new InspectCodeSettings {
        /// SolutionWideAnalysis = true,
        /// Profile = "./MySolution.sln.DotSettings",
        /// MsBuildProperties = msBuildProperties,
        /// OutputFile = resharperReportsDirectory + File("inspectcode-output.xml"),
        /// ThrowExceptionOnFindingViolations = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void InspectCode(global::Cake.Core.IO.FilePath solution, global::Cake.Common.Tools.InspectCode.InspectCodeSettings settings)
            => global::Cake.Common.Tools.InspectCode.InspectCodeAliases.InspectCode(Context, solution, settings);

        /// <member name="M:Cake.Common.Tools.InspectCode.InspectCodeAliases.InspectCodeFromConfig(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Runs ReSharper's InspectCode using the specified config file.
        /// </summary>
        /// <param name="configFile">The config file.</param>
        /// <example>
        /// <code>
        /// InspectCodeFromConfig("./src/inspectcode.config");
        /// </code>
        /// </example>
        /// </member>
        public static void InspectCodeFromConfig(global::Cake.Core.IO.FilePath configFile)
            => global::Cake.Common.Tools.InspectCode.InspectCodeAliases.InspectCodeFromConfig(Context, configFile);

        /// <member name="M:Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Builds the specified solution or MsBuild project file using MSBuild.
        /// </summary>
        /// <param name="solution">The solution or MsBuild project file to build.</param>
        /// <example>
        /// <code>
        /// MSBuild("./src/Cake.sln");
        /// </code>
        /// </example>
        /// </member>
        public static void MSBuild(global::Cake.Core.IO.FilePath solution)
            => global::Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Context, solution);

        /// <member name="M:Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Action{System.Collections.Generic.IEnumerable{System.String}})">
        /// <summary>
        /// Builds the specified solution or MsBuild project file using MSBuild.
        /// </summary>
        /// <param name="solution">The solution or MsBuild project file to build.</param>
        /// <param name="standardOutputAction">The action to invoke with the standard output.</param>
        /// <example>
        /// <code>
        /// MSBuild("./src/Cake.sln",
        /// output =&gt; foreach (var line in output) outputBuilder.AppendLine(line));
        /// </code>
        /// </example>
        /// </member>
        public static void MSBuild(global::Cake.Core.IO.FilePath solution, global::System.Action<global::System.Collections.Generic.IEnumerable<string>> standardOutputAction)
            => global::Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Context, solution, standardOutputAction);

        /// <member name="M:Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Action{Cake.Common.Tools.MSBuild.MSBuildSettings})">
        /// <summary>
        /// Builds the specified solution or MsBuild project file using MSBuild.
        /// </summary>
        /// <param name="solution">The solution or MsBuild project file to build.</param>
        /// <param name="configurator">The settings configurator.</param>
        /// <example>
        /// <code>
        /// MSBuild("./src/Cake.sln", configurator =&gt;
        /// configurator.SetConfiguration("Debug")
        /// .SetVerbosity(Verbosity.Minimal)
        /// .UseToolVersion(MSBuildToolVersion.VS2015)
        /// .SetMSBuildPlatform(MSBuildPlatform.x86)
        /// .SetPlatformTarget(PlatformTarget.MSIL));
        /// </code>
        /// </example>
        /// </member>
        public static void MSBuild(global::Cake.Core.IO.FilePath solution, global::System.Action<global::Cake.Common.Tools.MSBuild.MSBuildSettings> configurator)
            => global::Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Context, solution, configurator);

        /// <member name="M:Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Action{Cake.Common.Tools.MSBuild.MSBuildSettings},System.Action{System.Collections.Generic.IEnumerable{System.String}})">
        /// <summary>
        /// Builds the specified solution or MsBuild project file using MSBuild.
        /// </summary>
        /// <param name="solution">The solution or MsBuild project file to build.</param>
        /// <param name="configurator">The settings configurator.</param>
        /// <param name="standardOutputAction">The action to invoke with the standard output.</param>
        /// <example>
        /// <code>
        /// var outputBuilder = new StringBuilder();
        /// MSBuild("./src/Cake.sln", configurator =&gt;
        /// configurator.SetConfiguration("Debug")
        /// .SetVerbosity(Verbosity.Minimal)
        /// .UseToolVersion(MSBuildToolVersion.VS2015)
        /// .SetMSBuildPlatform(MSBuildPlatform.x86)
        /// .SetPlatformTarget(PlatformTarget.MSIL),
        /// output =&gt; foreach (var line in output) outputBuilder.AppendLine(line));
        /// </code>
        /// </example>
        /// </member>
        public static void MSBuild(global::Cake.Core.IO.FilePath solution, global::System.Action<global::Cake.Common.Tools.MSBuild.MSBuildSettings> configurator, global::System.Action<global::System.Collections.Generic.IEnumerable<string>> standardOutputAction)
            => global::Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Context, solution, configurator, standardOutputAction);

        /// <member name="M:Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.MSBuild.MSBuildSettings)">
        /// <summary>
        /// Builds the specified solution using MSBuild.
        /// </summary>
        /// <param name="solution">The solution or MsBuild project file to build.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// MSBuild("./src/Cake.sln", new MSBuildSettings {
        /// Verbosity = Verbosity.Minimal,
        /// ToolVersion = MSBuildToolVersion.VS2015,
        /// Configuration = "Release",
        /// PlatformTarget = PlatformTarget.MSIL
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void MSBuild(global::Cake.Core.IO.FilePath solution, global::Cake.Common.Tools.MSBuild.MSBuildSettings settings)
            => global::Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Context, solution, settings);

        /// <member name="M:Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.MSBuild.MSBuildSettings,System.Action{System.Collections.Generic.IEnumerable{System.String}})">
        /// <summary>
        /// Builds the specified solution or MsBuild project file using MSBuild.
        /// </summary>
        /// <param name="solution">The solution to build.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="standardOutputAction">The action to invoke with the standard output.</param>
        /// <example>
        /// <code>
        /// var outputBuilder = new StringBuilder();
        /// MSBuild("./src/Cake.sln", new MSBuildSettings {
        /// Verbosity = Verbosity.Minimal,
        /// ToolVersion = MSBuildToolVersion.VS2015,
        /// Configuration = "Release",
        /// PlatformTarget = PlatformTarget.MSIL
        /// },
        /// output =&gt; foreach (var line in output) outputBuilder.AppendLine(line));
        /// </code>
        /// </example>
        /// </member>
        public static void MSBuild(global::Cake.Core.IO.FilePath solution, global::Cake.Common.Tools.MSBuild.MSBuildSettings settings, global::System.Action<global::System.Collections.Generic.IEnumerable<string>> standardOutputAction)
            => global::Cake.Common.Tools.MSBuild.MSBuildAliases.MSBuild(Context, solution, settings, standardOutputAction);

        /// <member name="M:Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all MSTest unit tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// MSTest("./Tests/*.UnitTests.dll");
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// </member>
        public static void MSTest(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Context, pattern);

        /// <member name="M:Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.MSTest.MSTestSettings)">
        /// <summary>
        /// Runs all MSTest unit tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// MSTest("./Tests/*.UnitTests.dll", new MSTestSettings() { NoIsolation = false });
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void MSTest(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.MSTest.MSTestSettings settings)
            => global::Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all MSTest unit tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var paths = new List&lt;FilePath&gt;() { "./assemblydir1", "./assemblydir2" };
        /// MSTest(paths);
        /// </code>
        /// </example>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// </member>
        public static void MSTest(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths)
            => global::Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Context, assemblyPaths);

        /// <member name="M:Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.MSTest.MSTestSettings)">
        /// <summary>
        /// Runs all MSTest unit tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var paths = new List&lt;FilePath&gt;() { "./assemblydir1", "./assemblydir2" };
        /// MSTest(paths, new MSTestSettings() { NoIsolation = false });
        /// </code>
        /// </example>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void MSTest(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths, global::Cake.Common.Tools.MSTest.MSTestSettings settings)
            => global::Cake.Common.Tools.MSTest.MSTestAliases.MSTest(Context, assemblyPaths, settings);

        /// <member name="M:Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all MSpec tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// MSpec("./src/**/bin/Release/*.Tests.dll");
        /// </code>
        /// </example>
        /// </member>
        public static void MSpec(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Context, pattern);

        /// <member name="M:Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.MSpec.MSpecSettings)">
        /// <summary>
        /// Runs all MSpec tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// MSpec("./src/**/bin/Release/*.Tests.dll",
        /// new MSpecSettings {
        /// Parallelism = ParallelismOption.All,
        /// HtmlReport = true,
        /// NoAppDomain = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void MSpec(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.MSpec.MSpecSettings settings)
            => global::Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Runs all MSpec tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// MSpec(new []{
        /// "./src/Cake.Common.Tests/bin/Release/Cake.Common.Tests.dll",
        /// "./src/Cake.Core.Tests/bin/Release/Cake.Core.Tests.dll",
        /// "./src/Cake.NuGet.Tests/bin/Release/Cake.NuGet.Tests.dll",
        /// "./src/Cake.Tests/bin/Release/Cake.Tests.dll"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void MSpec(global::System.Collections.Generic.IEnumerable<string> assemblies)
            => global::Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all MSpec tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// MSpec(testAssemblies);
        /// </code>
        /// </example>
        /// </member>
        public static void MSpec(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies)
            => global::Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.MSpec.MSpecSettings)">
        /// <summary>
        /// Runs all MSpec tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// MSpec(new []{
        /// "./src/Cake.Common.Tests/bin/Release/Cake.Common.Tests.dll",
        /// "./src/Cake.Core.Tests/bin/Release/Cake.Core.Tests.dll",
        /// "./src/Cake.NuGet.Tests/bin/Release/Cake.NuGet.Tests.dll",
        /// "./src/Cake.Tests/bin/Release/Cake.Tests.dll"
        /// },
        /// new MSpecSettings {
        /// Parallelism = ParallelismOption.All,
        /// HtmlReport = true,
        /// NoAppDomain = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void MSpec(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.MSpec.MSpecSettings settings)
            => global::Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.MSpec.MSpecSettings)">
        /// <summary>
        /// Runs all MSpec tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// MSpec(testAssemblies,
        /// new MSpecSettings {
        /// Parallelism = ParallelismOption.All,
        /// HtmlReport = true,
        /// NoAppDomain = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void MSpec(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.MSpec.MSpecSettings settings)
            => global::Cake.Common.Tools.MSpec.MSpecAliases.MSpec(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.NSIS.NSISAliases.MakeNSIS(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Compiles the given NSIS script using the default settings.
        /// </summary>
        /// <param name="scriptFile">The path to the <c>.nsi</c> script file to compile.</param>
        /// <example>
        /// <code>
        /// MakeNSIS("./src/Cake.nsi");
        /// </code>
        /// </example>
        /// </member>
        public static void MakeNSIS(global::Cake.Core.IO.FilePath scriptFile)
            => global::Cake.Common.Tools.NSIS.NSISAliases.MakeNSIS(Context, scriptFile);

        /// <member name="M:Cake.Common.Tools.NSIS.NSISAliases.MakeNSIS(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.NSIS.MakeNSISSettings)">
        /// <summary>
        /// Compiles the given NSIS script using the given <paramref name="settings" />.
        /// </summary>
        /// <param name="scriptFile">The path to the <c>.nsi</c> script file to compile.</param>
        /// <param name="settings">The <see cref="T:Cake.Common.Tools.NSIS.MakeNSISSettings" /> to use.</param>
        /// <example>
        /// <code>
        /// MakeNSIS("./src/Cake.nsi", new MakeNSISSettings {
        /// NoConfig = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void MakeNSIS(global::Cake.Core.IO.FilePath scriptFile, global::Cake.Common.Tools.NSIS.MakeNSISSettings settings)
            => global::Cake.Common.Tools.NSIS.NSISAliases.MakeNSIS(Context, scriptFile, settings);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all NUnit unit tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// NUnit3("./src/**/bin/Release/*.Tests.dll");
        /// </code>
        /// </example>
        /// </member>
        public static void NUnit3(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Context, pattern);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.NUnit.NUnit3Settings)">
        /// <summary>
        /// Runs all NUnit unit tests in the assemblies matching the specified pattern,
        /// using the specified settings.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NUnit3("./src/**/bin/Release/*.Tests.dll", new NUnit3Settings {
        /// NoResults = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NUnit3(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.NUnit.NUnit3Settings settings)
            => global::Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// NUnit3(new [] { "./src/Example.Tests/bin/Release/Example.Tests.dll" });
        /// </code>
        /// </example>
        /// </member>
        public static void NUnit3(global::System.Collections.Generic.IEnumerable<string> assemblies)
            => global::Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// NUnit3(testAssemblies);
        /// </code>
        /// </example>
        /// </member>
        public static void NUnit3(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies)
            => global::Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.NUnit.NUnit3Settings)">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies,
        /// using the specified settings.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NUnit3(new [] { "./src/Example.Tests/bin/Release/Example.Tests.dll" }, new NUnit3Settings {
        /// NoResults = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NUnit3(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.NUnit.NUnit3Settings settings)
            => global::Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NUnit.NUnit3Settings)">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies,
        /// using the specified settings.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// NUnit3(testAssemblies, new NUnit3Settings {
        /// NoResults = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NUnit3(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.NUnit.NUnit3Settings settings)
            => global::Cake.Common.Tools.NUnit.NUnit3Aliases.NUnit3(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all NUnit unit tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// NUnit("./src/UnitTests/*.dll");
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// </member>
        public static void NUnit(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Context, pattern);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.NUnit.NUnitSettings)">
        /// <summary>
        /// Runs all NUnit unit tests in the assemblies matching the specified pattern,
        /// using the specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// NUnit("./src/UnitTests/*.dll", new NUnitSettings {
        /// Timeout = 4000,
        /// StopOnError = true
        /// });
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void NUnit(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.NUnit.NUnitSettings settings)
            => global::Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = new [] {
        /// "UnitTests1.dll",
        /// "UnitTests2.dll"
        /// };
        /// NUnit(assemblies);
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// </member>
        public static void NUnit(global::System.Collections.Generic.IEnumerable<string> assemblies)
            => global::Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = GetFiles("./src/UnitTests/*.dll");
        /// NUnit(assemblies);
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// </member>
        public static void NUnit(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies)
            => global::Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.NUnit.NUnitSettings)">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies,
        /// using the specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = new [] {
        /// "UnitTests1.dll",
        /// "UnitTests2.dll"
        /// };
        /// NUnit(assemblies, new NUnitSettings {
        /// Timeout = 4000,
        /// StopOnError = true
        /// });
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void NUnit(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.NUnit.NUnitSettings settings)
            => global::Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NUnit.NUnitSettings)">
        /// <summary>
        /// Runs all NUnit unit tests in the specified assemblies,
        /// using the specified settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var assemblies = GetFiles(""./src/UnitTests/*.dll"");
        /// NUnit(assemblies, new NUnitSettings {
        /// Timeout = 4000,
        /// StopOnError = true
        /// });
        /// </code>
        /// </example>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void NUnit(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.NUnit.NUnitSettings settings)
            => global::Cake.Common.Tools.NUnit.NUnitAliases.NUnit(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetPack(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.NuGet.Pack.NuGetPackSettings)">
        /// <summary>
        /// Creates a NuGet package using the specified nuspec or project file.
        /// </summary>
        /// <param name="filePath">The nuspec or project file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var nuGetPackSettings   = new NuGetPackSettings {
        /// Id                      = "TestNuGet",
        /// Version                 = "0.0.0.1",
        /// Title                   = "The tile of the package",
        /// Authors                 = new[] {"John Doe"},
        /// Owners                  = new[] {"Contoso"},
        /// Description             = "The description of the package",
        /// Summary                 = "Excellent summary of what the package does",
        /// ProjectUrl              = new Uri("https://github.com/SomeUser/TestNuGet/"),
        /// IconUrl                 = new Uri("http://cdn.rawgit.com/SomeUser/TestNuGet/master/icons/testNuGet.png"),
        /// LicenseUrl              = new Uri("https://github.com/SomeUser/TestNuGet/blob/master/LICENSE.md"),
        /// Copyright               = "Some company 2015",
        /// ReleaseNotes            = new [] {"Bug fixes", "Issue fixes", "Typos"},
        /// Tags                    = new [] {"Cake", "Script", "Build"},
        /// RequireLicenseAcceptance= false,
        /// Symbols                 = false,
        /// NoPackageAnalysis       = true,
        /// Files                   = new [] {
        /// new NuSpecContent {Source = "bin/TestNuGet.dll", Target = "bin"},
        /// },
        /// BasePath                = "./src/TestNuGet/bin/release",
        /// OutputDirectory         = "./NuGet"
        /// };
        /// NuGetPack("./nuspec/TestNuGet.nuspec", nuGetPackSettings);
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetPack(global::Cake.Core.IO.FilePath filePath, global::Cake.Common.Tools.NuGet.Pack.NuGetPackSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetPack(Context, filePath, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetPack(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NuGet.Pack.NuGetPackSettings)">
        /// <summary>
        /// Creates NuGet packages using the specified nuspec or project files.
        /// </summary>
        /// <param name="filePaths">The nuspec or project file paths.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var nuGetPackSettings   = new NuGetPackSettings {
        /// Id                      = "TestNuGet",
        /// Version                 = "0.0.0.1",
        /// Title                   = "The tile of the package",
        /// Authors                 = new[] {"John Doe"},
        /// Owners                  = new[] {"Contoso"},
        /// Description             = "The description of the package",
        /// Summary                 = "Excellent summary of what the package does",
        /// ProjectUrl              = new Uri("https://github.com/SomeUser/TestNuGet/"),
        /// IconUrl                 = new Uri("http://cdn.rawgit.com/SomeUser/TestNuGet/master/icons/testNuGet.png"),
        /// LicenseUrl              = new Uri("https://github.com/SomeUser/TestNuGet/blob/master/LICENSE.md"),
        /// Copyright               = "Some company 2015",
        /// ReleaseNotes            = new [] {"Bug fixes", "Issue fixes", "Typos"},
        /// Tags                    = new [] {"Cake", "Script", "Build"},
        /// RequireLicenseAcceptance= false,
        /// Symbols                 = false,
        /// NoPackageAnalysis       = true,
        /// Files                   = new [] {
        /// new NuSpecContent {Source = "bin/TestNuGet.dll", Target = "bin"},
        /// },
        /// BasePath                = "./src/TestNuGet/bin/release",
        /// OutputDirectory         = "./NuGet"
        /// };
        /// var nuspecFiles = GetFiles("./**/*.nuspec");
        /// NuGetPack(nuspecFiles, nuGetPackSettings);
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetPack(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> filePaths, global::Cake.Common.Tools.NuGet.Pack.NuGetPackSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetPack(Context, filePaths, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetPack(Cake.Core.ICakeContext,Cake.Common.Tools.NuGet.Pack.NuGetPackSettings)">
        /// <summary>
        /// Creates a NuGet package using the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var nuGetPackSettings   = new NuGetPackSettings {
        /// Id                      = "TestNuGet",
        /// Version                 = "0.0.0.1",
        /// Title                   = "The tile of the package",
        /// Authors                 = new[] {"John Doe"},
        /// Owners                  = new[] {"Contoso"},
        /// Description             = "The description of the package",
        /// Summary                 = "Excellent summary of what the package does",
        /// ProjectUrl              = new Uri("https://github.com/SomeUser/TestNuGet/"),
        /// IconUrl                 = new Uri("http://cdn.rawgit.com/SomeUser/TestNuGet/master/icons/testNuGet.png"),
        /// LicenseUrl              = new Uri("https://github.com/SomeUser/TestNuGet/blob/master/LICENSE.md"),
        /// Copyright               = "Some company 2015",
        /// ReleaseNotes            = new [] {"Bug fixes", "Issue fixes", "Typos"},
        /// Tags                    = new [] {"Cake", "Script", "Build"},
        /// RequireLicenseAcceptance= false,
        /// Symbols                 = false,
        /// NoPackageAnalysis       = true,
        /// Files                   = new [] {
        /// new NuSpecContent {Source = "bin/TestNuGet.dll", Target = "bin"},
        /// },
        /// BasePath                = "./src/TestNuGet/bin/release",
        /// OutputDirectory         = "./NuGet"
        /// };
        /// NuGetPack(nuGetPackSettings);
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetPack(global::Cake.Common.Tools.NuGet.Pack.NuGetPackSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetPack(Context, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Restores NuGet packages for the specified target.
        /// </summary>
        /// <param name="targetFilePath">The target to restore.</param>
        /// <example>
        /// <code>
        /// var solutions = GetFiles("./**/*.sln");
        /// // Restore all NuGet packages.
        /// foreach (var solution in solutions)
        /// {
        /// Information("Restoring {0}", solution);
        /// NuGetRestore(solution);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetRestore(global::Cake.Core.IO.FilePath targetFilePath)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Context, targetFilePath);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Restores NuGet packages for the specified targets.
        /// </summary>
        /// <param name="targetFilePaths">The targets to restore.</param>
        /// <example>
        /// <code>
        /// var solutions = GetFiles("./**/*.sln");
        /// NuGetRestore(solutions);
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetRestore(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> targetFilePaths)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Context, targetFilePaths);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.NuGet.Restore.NuGetRestoreSettings)">
        /// <summary>
        /// Restores NuGet packages using the specified settings.
        /// </summary>
        /// <param name="targetFilePath">The target to restore.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var solutions = GetFiles("./**/*.sln");
        /// // Restore all NuGet packages.
        /// foreach (var solution in solutions)
        /// {
        /// Information("Restoring {0}", solution);
        /// NuGetRestore(solution, new NuGetRestoreSettings { NoCache = true });
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetRestore(global::Cake.Core.IO.FilePath targetFilePath, global::Cake.Common.Tools.NuGet.Restore.NuGetRestoreSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Context, targetFilePath, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NuGet.Restore.NuGetRestoreSettings)">
        /// <summary>
        /// Restores NuGet packages using the specified settings.
        /// </summary>
        /// <param name="targetFilePaths">The targets to restore.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var solutions = GetFiles("./**/*.sln");
        /// NuGetRestore(solutions, new NuGetRestoreSettings { NoCache = true });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetRestore(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> targetFilePaths, global::Cake.Common.Tools.NuGet.Restore.NuGetRestoreSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetRestore(Context, targetFilePaths, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetPush(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.NuGet.Push.NuGetPushSettings)">
        /// <summary>
        /// Pushes a NuGet package to a NuGet server and publishes it.
        /// </summary>
        /// <param name="packageFilePath">The <c>.nupkg</c> file path.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>NOTE: Starting with NuGet 3.4.2, the Source parameter is a mandatory parameter.</para>
        /// <para>It is strongly recommended that you ALWAYS set the Source property within the <see cref="T:Cake.Common.Tools.NuGet.Push.NuGetPushSettings" /> instance.</para>
        /// <code>
        /// // Get the path to the package.
        /// var package = "./nuget/SlackPRTGCommander.0.0.1.nupkg";
        /// // Push the package.
        /// NuGetPush(package, new NuGetPushSettings {
        /// Source = "http://example.com/nugetfeed",
        /// ApiKey = "4003d786-cc37-4004-bfdf-c4f3e8ef9b3a"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetPush(global::Cake.Core.IO.FilePath packageFilePath, global::Cake.Common.Tools.NuGet.Push.NuGetPushSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetPush(Context, packageFilePath, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetPush(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NuGet.Push.NuGetPushSettings)">
        /// <summary>
        /// Pushes NuGet packages to a NuGet server and publishes them.
        /// </summary>
        /// <param name="packageFilePaths">The <c>.nupkg</c> file paths.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>NOTE: Starting with NuGet 3.4.2, the Source parameter is a mandatory parameter.</para>
        /// <para>It is strongly recommended that you ALWAYS set the Source property within the <see cref="T:Cake.Common.Tools.NuGet.Push.NuGetPushSettings" /> instance.</para>
        /// <code>
        /// // Get the paths to the packages.
        /// var packages = GetFiles("./**/*.nupkg");
        /// // Push the package.
        /// NuGetPush(packages, new NuGetPushSettings {
        /// Source = "http://example.com/nugetfeed",
        /// ApiKey = "4003d786-cc37-4004-bfdf-c4f3e8ef9b3a"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetPush(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> packageFilePaths, global::Cake.Common.Tools.NuGet.Push.NuGetPushSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetPush(Context, packageFilePaths, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetAddSource(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Adds NuGet package source using the specified name &amp;source to global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="source">Path to the package(s) source.</param>
        /// <example>
        /// <code>
        /// var feed = new
        /// {
        /// Name = EnvironmentVariable("PUBLIC_FEED_NAME"),
        /// Source = EnvironmentVariable("PUBLIC_FEED_SOURCE")
        /// };
        /// NuGetAddSource(
        /// name:feed.Name,
        /// source:feed.Source
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetAddSource(string name, string source)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetAddSource(Context, name, source);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetAddSource(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.NuGet.Sources.NuGetSourcesSettings)">
        /// <summary>
        /// Adds NuGet package source using the specified name, source &amp; settings to global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="source">Path to the package(s) source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var nugetSourceSettings = new NuGetSourcesSettings
        /// {
        /// UserName = EnvironmentVariable("PRIVATE_FEED_USERNAME"),
        /// Password = EnvironmentVariable("PRIVATE_FEED_PASSWORD"),
        /// IsSensitiveSource = true,
        /// Verbosity = NuGetVerbosity.Detailed
        /// };
        /// var feed = new
        /// {
        /// Name = EnvironmentVariable("PRIVATE_FEED_NAME"),
        /// Source = EnvironmentVariable("PRIVATE_FEED_SOURCE")
        /// };
        /// NuGetAddSource(
        /// name:feed.Name,
        /// source:feed.Source,
        /// settings:nugetSourceSettings
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetAddSource(string name, string source, global::Cake.Common.Tools.NuGet.Sources.NuGetSourcesSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetAddSource(Context, name, source, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetRemoveSource(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Removes NuGet package source using the specified name &amp; source from global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="source">Path to the package(s) source.</param>
        /// <example>
        /// <code>
        /// var feed = new
        /// {
        /// Name = EnvironmentVariable("PRIVATE_FEED_NAME"),
        /// Source = EnvironmentVariable("PRIVATE_FEED_SOURCE")
        /// };
        /// NuGetRemoveSource(
        /// name:feed.Name,
        /// source:feed.Source
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetRemoveSource(string name, string source)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetRemoveSource(Context, name, source);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetRemoveSource(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.NuGet.Sources.NuGetSourcesSettings)">
        /// <summary>
        /// Removes NuGet package source using the specified name, source &amp; settings from global user config.
        /// </summary>
        /// <param name="name">Name of the source.</param>
        /// <param name="source">Path to the package(s) source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var nugetSourceSettings = new NuGetSourcesSettings
        /// {
        /// UserName = EnvironmentVariable("PRIVATE_FEED_USERNAME"),
        /// Password = EnvironmentVariable("PRIVATE_FEED_PASSWORD"),
        /// IsSensitiveSource = true,
        /// Verbosity = NuGetVerbosity.Detailed
        /// };
        /// var feed = new
        /// {
        /// Name = EnvironmentVariable("PRIVATE_FEED_NAME"),
        /// Source = EnvironmentVariable("PRIVATE_FEED_SOURCE")
        /// };
        /// NuGetRemoveSource(
        /// name:feed.Name,
        /// source:feed.Source,
        /// settings:nugetSourceSettings
        /// );
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetRemoveSource(string name, string source, global::Cake.Common.Tools.NuGet.Sources.NuGetSourcesSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetRemoveSource(Context, name, source, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetHasSource(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Checks whether or not a NuGet package source exists in the global user configuration, using the specified source.
        /// </summary>
        /// <param name="source">Path to the package(s) source.</param>
        /// <returns>Whether or not the NuGet package source exists in the global user configuration.</returns>
        /// <example>
        /// <code>
        /// var feed = new
        /// {
        /// Name = EnvironmentVariable("PRIVATE_FEED_NAME"),
        /// Source = EnvironmentVariable("PRIVATE_FEED_SOURCE")
        /// };
        /// if (!NuGetHasSource(source:feed.Source))
        /// {
        /// Information("Source missing");
        /// }
        /// else
        /// {
        /// Information("Source already exists");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static bool NuGetHasSource(string source)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetHasSource(Context, source);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetHasSource(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.NuGet.Sources.NuGetSourcesSettings)">
        /// <summary>
        /// Checks whether or not a NuGet package source exists in the global user configuration, using the specified source and settings.
        /// </summary>
        /// <param name="source">Path to the package(s) source.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>Whether the specified NuGet package source exist.</returns>
        /// <example>
        /// <code>
        /// var nugetSourceSettings = new NuGetSourcesSettings
        /// {
        /// UserName = EnvironmentVariable("PRIVATE_FEED_USERNAME"),
        /// Password = EnvironmentVariable("PRIVATE_FEED_PASSWORD"),
        /// IsSensitiveSource = true,
        /// Verbosity = NuGetVerbosity.Detailed
        /// };
        /// var feed = new
        /// {
        /// Name = EnvironmentVariable("PRIVATE_FEED_NAME"),
        /// Source = EnvironmentVariable("PRIVATE_FEED_SOURCE")
        /// };
        /// if (!NuGetHasSource(
        /// source:feed.Source,
        /// settings:nugetSourceSettings))
        /// {
        /// Information("Source missing");
        /// }
        /// else
        /// {
        /// Information("Source already exists");
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static bool NuGetHasSource(string source, global::Cake.Common.Tools.NuGet.Sources.NuGetSourcesSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetHasSource(Context, source, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Installs a NuGet package.
        /// </summary>
        /// <param name="packageId">The id of the package to install.</param>
        /// <example>
        /// <code>
        /// NuGetInstall("MyNuGetPackage");
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstall(string packageId)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Context, packageId);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Installs NuGet packages.
        /// </summary>
        /// <param name="packageIds">The id's of the package to install.</param>
        /// <example>
        /// <code>
        /// NuGetInstall(new[] { "MyNuGetPackage", "OtherNuGetPackage" });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstall(global::System.Collections.Generic.IEnumerable<string> packageIds)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Context, packageIds);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.NuGet.Install.NuGetInstallSettings)">
        /// <summary>
        /// Installs a NuGet package using the specified settings.
        /// </summary>
        /// <param name="packageId">The id of the package to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NuGetInstall("MyNuGetPackage", new NuGetInstallSettings {
        /// ExcludeVersion  = true,
        /// OutputDirectory = "./tools"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstall(string packageId, global::Cake.Common.Tools.NuGet.Install.NuGetInstallSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.NuGet.Install.NuGetInstallSettings)">
        /// <summary>
        /// Installs NuGet packages using the specified settings.
        /// </summary>
        /// <param name="packageIds">The id's of the package to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NuGetInstall(new[] { "MyNuGetPackage", "OtherNuGetPackage" }, new NuGetInstallSettings {
        /// ExcludeVersion  = true,
        /// OutputDirectory = "./tools"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstall(global::System.Collections.Generic.IEnumerable<string> packageIds, global::Cake.Common.Tools.NuGet.Install.NuGetInstallSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstall(Context, packageIds, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Installs NuGet packages using the specified package configuration.
        /// </summary>
        /// <param name="packageConfigPath">The package configuration to install.</param>
        /// <example>
        /// <code>
        /// NuGetInstallFromConfig("./tools/packages.config");
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstallFromConfig(global::Cake.Core.IO.FilePath packageConfigPath)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Context, packageConfigPath);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Installs NuGet packages using the specified package configurations.
        /// </summary>
        /// <param name="packageConfigPaths">The package configurations to install.</param>
        /// <example>
        /// <code>
        /// var packageConfigs = GetFiles("./**/packages.config");
        /// NuGetInstallFromConfig(packageConfigs);
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstallFromConfig(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> packageConfigPaths)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Context, packageConfigPaths);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.NuGet.Install.NuGetInstallSettings)">
        /// <summary>
        /// Installs NuGet packages using the specified package configuration and settings.
        /// </summary>
        /// <param name="packageConfigPath">The package configuration to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NuGetInstallFromConfig("./tools/packages.config", new NuGetInstallSettings {
        /// ExcludeVersion  = true,
        /// OutputDirectory = "./tools"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstallFromConfig(global::Cake.Core.IO.FilePath packageConfigPath, global::Cake.Common.Tools.NuGet.Install.NuGetInstallSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Context, packageConfigPath, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NuGet.Install.NuGetInstallSettings)">
        /// <summary>
        /// Installs NuGet packages using the specified package configurations and settings.
        /// </summary>
        /// <param name="packageConfigPaths">The package configurations to install.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var packageConfigs = GetFiles("./**/packages.config");
        /// NuGetInstallFromConfig(packageConfigs, new NuGetInstallSettings {
        /// ExcludeVersion  = true,
        /// OutputDirectory = "./tools"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInstallFromConfig(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> packageConfigPaths, global::Cake.Common.Tools.NuGet.Install.NuGetInstallSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInstallFromConfig(Context, packageConfigPaths, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetApiKey(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.NuGet.SetApiKey.NuGetSetApiKeySettings)">
        /// <summary>
        /// Installs NuGet packages using the specified API key, source and settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var setting = new NuGetSetApiKeySettings {
        /// Verbosity = NuGetVerbosity.Detailed
        /// };
        /// NuGetSetApiKey("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "https://nuget.org/api/v2/", setting);
        /// </code>
        /// </example>
        /// <param name="apiKey">The API key.</param>
        /// <param name="source">Server URL where the API key is valid.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void NuGetSetApiKey(string apiKey, string source, global::Cake.Common.Tools.NuGet.SetApiKey.NuGetSetApiKeySettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetApiKey(Context, apiKey, source, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetApiKey(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Installs NuGet packages using the specified API key and source.
        /// </summary>
        /// <example>
        /// <code>
        /// NuGetSetApiKey("xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "https://nuget.org/api/v2/");
        /// </code>
        /// </example>
        /// <param name="apiKey">The API key.</param>
        /// <param name="source">Server URL where the API key is valid.</param>
        /// </member>
        public static void NuGetSetApiKey(string apiKey, string source)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetApiKey(Context, apiKey, source);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetProxy(Cake.Core.ICakeContext,System.String,System.String,System.String,Cake.Common.Tools.NuGet.SetProxy.NuGetSetProxySettings)">
        /// <summary>
        /// Set the proxy settings to be used while connecting to your NuGet feed, including settings.
        /// </summary>
        /// <example>
        /// <code>
        /// var setting = new NuGetSetProxySettings {
        /// Verbosity = NuGetVerbosity.Detailed
        /// };
        /// NuGetSetProxy("127.0.0.1:8080", "proxyuser","Pa$$w0rd1", setting);
        /// </code>
        /// </example>
        /// <param name="proxy">The url of the proxy.</param>
        /// <param name="username">The username used to access the proxy.</param>
        /// <param name="password">The password used to access the proxy.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void NuGetSetProxy(string proxy, string username, string password, global::Cake.Common.Tools.NuGet.SetProxy.NuGetSetProxySettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetProxy(Context, proxy, username, password, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetProxy(Cake.Core.ICakeContext,System.String,System.String,System.String)">
        /// <summary>
        /// Set the proxy settings to be used while connecting to your NuGet feed.
        /// </summary>
        /// <example>
        /// <code>
        /// NuGetSetProxy("127.0.0.1:8080", "proxyuser","Pa$$w0rd1");
        /// </code>
        /// </example>
        /// <param name="proxy">The url of the proxy.</param>
        /// <param name="username">The username used to access the proxy.</param>
        /// <param name="password">The password used to access the proxy.</param>
        /// </member>
        public static void NuGetSetProxy(string proxy, string username, string password)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetSetProxy(Context, proxy, username, password);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Updates NuGet packages.
        /// </summary>
        /// <param name="targetFile">The target to update.</param>
        /// <example>
        /// <code>
        /// NuGetUpdate("./tools/packages.config");
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetUpdate(global::Cake.Core.IO.FilePath targetFile)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Context, targetFile);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Updates NuGet packages.
        /// </summary>
        /// <param name="targetFiles">The targets to update.</param>
        /// <example>
        /// <code>
        /// var targets = GetFiles("./**/packages.config");
        /// NuGetUpdate(targets);
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetUpdate(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> targetFiles)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Context, targetFiles);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.NuGet.Update.NuGetUpdateSettings)">
        /// <summary>
        /// Updates NuGet packages using the specified settings.
        /// </summary>
        /// <param name="targetFile">The target to update.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NuGetUpdate("./tools/packages.config", new NuGetUpdateSettings {
        /// Prerelease = true,
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetUpdate(global::Cake.Core.IO.FilePath targetFile, global::Cake.Common.Tools.NuGet.Update.NuGetUpdateSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Context, targetFile, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.NuGet.Update.NuGetUpdateSettings)">
        /// <summary>
        /// Updates NuGet packages using the specified settings.
        /// </summary>
        /// <param name="targetFiles">The targets to update.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var targets = GetFiles("./**/packages.config");
        /// NuGetUpdate(targets, new NuGetUpdateSettings {
        /// Prerelease = true,
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetUpdate(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> targetFiles, global::Cake.Common.Tools.NuGet.Update.NuGetUpdateSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetUpdate(Context, targetFiles, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetAdd(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Adds a NuGet package using package id and source.
        /// </summary>
        /// <param name="packageId">The id of the package to add.</param>
        /// <param name="source">Path to the local feed source.</param>
        /// <example>
        /// <code>
        /// NuGetAdd("MyNuGetPackage", "//bar/packages/");
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetAdd(string packageId, string source)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetAdd(Context, packageId, source);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetAdd(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.NuGet.Add.NuGetAddSettings)">
        /// <summary>
        /// Adds a NuGet package using package id and source.
        /// </summary>
        /// <param name="packageId">The id of the package to add.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NuGetAdd("MyNuGetPackage", new NuGetAddSettings {
        /// Source = "//bar/packages/"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetAdd(string packageId, global::Cake.Common.Tools.NuGet.Add.NuGetAddSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetAdd(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInit(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Adds all packages from source to destination.
        /// </summary>
        /// <param name="source">The local feed package source.</param>
        /// <param name="destination">The local feed destination source.</param>
        /// <example>
        /// <code>
        /// NuGetInit("//foo/packages", "//bar/packages/");
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInit(string source, string destination)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInit(Context, source, destination);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetInit(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.NuGet.Init.NuGetInitSettings)">
        /// <summary>
        /// Adds all packages from source to destination using specified settings.
        /// </summary>
        /// <param name="source">The local feed package source.</param>
        /// <param name="destination">The local feed destination source.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// NuGetInit("//foo/packages", "//bar/packages/", new NuGetInitSettings {
        /// Expand = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetInit(string source, string destination, global::Cake.Common.Tools.NuGet.Init.NuGetInitSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetInit(Context, source, destination, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetList(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.NuGet.List.NuGetListSettings)">
        /// <summary>
        /// List packages on available from source using specified settings.
        /// </summary>
        /// <param name="packageId">The package Id.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>List of packages with their version.</returns>
        /// <example>
        /// <code>
        /// var packageList = NuGetList("Cake", new NuGetListSettings {
        /// AllVersions = false,
        /// Prerelease = false
        /// });
        /// foreach (var package in packageList)
        /// {
        /// Information("Found package {0}, version {1}", package.Name, package.Version);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.NuGet.List.NuGetListItem> NuGetList(string packageId, global::Cake.Common.Tools.NuGet.List.NuGetListSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetList(Context, packageId, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetList(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// List packages on available from source using specified settings.
        /// </summary>
        /// <param name="packageId">The package Id.</param>
        /// <returns>List of packages with their version.</returns>
        /// <example>
        /// <code>
        /// var packageList = NuGetList("Cake");
        /// foreach (var package in packageList)
        /// {
        /// Information("Found package {0}, version {1}", package.Name, package.Version);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.NuGet.List.NuGetListItem> NuGetList(string packageId)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetList(Context, packageId);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetList(Cake.Core.ICakeContext,Cake.Common.Tools.NuGet.List.NuGetListSettings)">
        /// <summary>
        /// List packages on available from source using specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>List of packages with their version.</returns>
        /// <example>
        /// <code>
        /// var packageList = NuGetList(new NuGetListSettings {
        /// AllVersions = false,
        /// Prerelease = false
        /// });
        /// foreach (var package in packageList)
        /// {
        /// Information("Found package {0}, version {1}", package.Name, package.Version);
        /// }
        /// </code>
        /// </example>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<global::Cake.Common.Tools.NuGet.List.NuGetListItem> NuGetList(global::Cake.Common.Tools.NuGet.List.NuGetListSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetList(Context, settings);

        /// <member name="M:Cake.Common.Tools.NuGet.NuGetAliases.NuGetDelete(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Tools.NuGet.Delete.NuGetDeleteSettings)">
        /// <summary>
        /// Deletes or unlists a package from a package source.
        /// </summary>
        /// <param name="packageID">The package ID (name).</param>
        /// <param name="packageVersion">The package version.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>NOTE: Starting with NuGet 3.4.2, the Source parameter is a mandatory parameter.</para>
        /// <para>It is strongly recommended that you ALWAYS set the Source property within the <see cref="T:Cake.Common.Tools.NuGet.Delete.NuGetDeleteSettings" /> instance.</para>
        /// <code>
        /// // Delete the package.
        /// NuGetDelete("PackageName", "PackageVersion", new NuGetPushSettings {
        /// Source = "http://example.com/nugetfeed",
        /// ApiKey = "4003d786-cc37-4004-bfdf-c4f3e8ef9b3a"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void NuGetDelete(string packageID, string packageVersion, global::Cake.Common.Tools.NuGet.Delete.NuGetDeleteSettings settings)
            => global::Cake.Common.Tools.NuGet.NuGetAliases.NuGetDelete(Context, packageID, packageVersion, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoCreateRelease(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.OctopusDeploy.CreateReleaseSettings)">
        /// <summary>
        /// Creates a release for the specified Octopus Deploy Project.
        /// </summary>
        /// <param name="projectName">The name of the project.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// // Minimum required
        /// OctoCreateRelease(projectNameOnServer, new CreateReleaseSettings {
        /// Server = "http://octopus-deploy.example",
        /// ApiKey = "API-XXXXXXXXXXXXXXXXXXXX"
        /// });
        /// OctoCreateRelease(projectNameOnServer, new CreateReleaseSettings {
        /// Server = "http://octopus-deploy.example",
        /// Username = "DeployUser",
        /// Password = "a-very-secure-password"
        /// });
        /// OctoCreateRelease(projectNameOnServer, new CreateReleaseSettings {
        /// ConfigurationFile = @"C:\OctopusDeploy.config"
        /// });
        /// // Additional Options
        /// OctoCreateRelease(projectNameOnServer, new CreateReleaseSettings {
        /// ToolPath = "./tools/OctopusTools/Octo.exe"
        /// EnableDebugLogging = true,
        /// IgnoreSslErrors = true,
        /// EnableServiceMessages = true, // Enables teamcity services messages when logging
        /// ReleaseNumber = "1.8.2",
        /// DefaultPackageVersion = "1.0.0.0", // All packages in the release should be 1.0.0.0
        /// Packages = new Dictionary&lt;string, string&gt;
        /// {
        /// { "PackageOne", "1.0.2.3" },
        /// { "PackageTwo", "5.2.3" }
        /// },
        /// PackagesFolder = @"C:\MyOtherNuGetFeed",
        /// // One or the other
        /// ReleaseNotes = "Version 2.0 \n What a milestone we have ...",
        /// ReleaseNotesFile = "./ReleaseNotes.md",
        /// IgnoreExisting = true // if this release number already exists, ignore it
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void OctoCreateRelease(string projectName, global::Cake.Common.Tools.OctopusDeploy.CreateReleaseSettings settings)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoCreateRelease(Context, projectName, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPush(Cake.Core.ICakeContext,System.String,System.String,Cake.Core.IO.FilePath,Cake.Common.Tools.OctopusDeploy.OctopusPushSettings)">
        /// <summary>
        /// Pushes the specified package to the Octopus Deploy repository.
        /// </summary>
        /// <param name="server">The Octopus server URL.</param>
        /// <param name="apiKey">The user's API key.</param>
        /// <param name="packagePath">Path to the package.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void OctoPush(string server, string apiKey, global::Cake.Core.IO.FilePath packagePath, global::Cake.Common.Tools.OctopusDeploy.OctopusPushSettings settings)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPush(Context, server, apiKey, packagePath, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPush(Cake.Core.ICakeContext,System.String,System.String,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.OctopusDeploy.OctopusPushSettings)">
        /// <summary>
        /// Pushes the specified packages to the Octopus Deploy repository.
        /// </summary>
        /// <param name="server">The Octopus server URL.</param>
        /// <param name="apiKey">The user's API key.</param>
        /// <param name="packagePaths">Paths to the packages.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void OctoPush(string server, string apiKey, global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> packagePaths, global::Cake.Common.Tools.OctopusDeploy.OctopusPushSettings settings)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPush(Context, server, apiKey, packagePaths, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPack(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Packs the specified folder into an Octopus Deploy package.
        /// </summary>
        /// <param name="id">The package ID.</param>
        /// </member>
        public static void OctoPack(string id)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPack(Context, id);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPack(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.OctopusDeploy.OctopusPackSettings)">
        /// <summary>
        /// Packs the specified folder into an Octopus Deploy package.
        /// </summary>
        /// <param name="id">The package ID.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void OctoPack(string id, global::Cake.Common.Tools.OctopusDeploy.OctopusPackSettings? settings = null)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPack(Context, id, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoDeployRelease(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,System.String,Cake.Common.Tools.OctopusDeploy.OctopusDeployReleaseDeploymentSettings)">
        /// <summary>
        /// Deploys the specified already existing release into a specified environment
        /// See <see href="http://docs.octopusdeploy.com/display/OD/Deploying+releases">Octopus Documentation</see> for more details.
        /// </summary>
        /// <param name="server">The Octopus server URL.</param>
        /// <param name="apiKey">The user's API key.</param>
        /// <param name="projectName">Name of the target project.</param>
        /// <param name="deployTo">Target environment name.</param>
        /// <param name="releaseNumber">Version number of the release to deploy. Specify "latest" for the latest release.</param>
        /// <param name="settings">Deployment settings.</param>
        /// <example>
        /// <code>
        /// // bare minimum
        /// OctoDeployRelease("http://octopus-deploy.example", "API-XXXXXXXXXXXXXXXXXXXX", "MyGreatProject", "Testing", "2.1.15-RC" new OctopusDeployReleaseDeploymentSettings());
        /// // All of deployment arguments
        /// OctoDeployRelease("http://octopus-deploy.example", "API-XXXXXXXXXXXXXXXXXXXX", "MyGreatProject", "Testing", "2.1.15-RC" new OctopusDeployReleaseDeploymentSettings {
        /// ShowProgress = true,
        /// ForcePackageDownload = true,
        /// WaitForDeployment = true,
        /// DeploymentTimeout = TimeSpan.FromMinutes(1),
        /// CancelOnTimeout = true,
        /// DeploymentChecksLeapCycle = TimeSpan.FromMinutes(77),
        /// GuidedFailure = true,
        /// SpecificMachines = new string[] { "Machine1", "Machine2" },
        /// Force = true,
        /// SkipSteps = new[] { "Step1", "Step2" },
        /// NoRawLog = true,
        /// RawLogFile = "someFile.txt",
        /// DeployAt = new DateTime(2010, 6, 15).AddMinutes(1),
        /// Tenant = new[] { "Tenant1", "Tenant2" },
        /// TenantTags = new[] { "Tag1", "Tag2" },
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void OctoDeployRelease(string server, string apiKey, string projectName, string deployTo, string releaseNumber, global::Cake.Common.Tools.OctopusDeploy.OctopusDeployReleaseDeploymentSettings settings)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoDeployRelease(Context, server, apiKey, projectName, deployTo, releaseNumber, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoDeployRelease(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String[],System.String,Cake.Common.Tools.OctopusDeploy.OctopusDeployReleaseDeploymentSettings)">
        /// <summary>
        /// Deploys the specified already existing release into a specified environment
        /// See <see href="http://docs.octopusdeploy.com/display/OD/Deploying+releases">Octopus Documentation</see> for more details.
        /// </summary>
        /// <param name="server">The Octopus server URL.</param>
        /// <param name="apiKey">The user's API key.</param>
        /// <param name="projectName">Name of the target project.</param>
        /// <param name="deployToMultiple">Multiple target environment names.</param>
        /// <param name="releaseNumber">Version number of the release to deploy. Specify "latest" for the latest release.</param>
        /// <param name="settings">Deployment settings.</param>
        /// <example>
        /// <code>
        /// // bare minimum
        /// OctoDeployRelease("http://octopus-deploy.example", "API-XXXXXXXXXXXXXXXXXXXX", "MyGreatProject", "Testing", "2.1.15-RC" new OctopusDeployReleaseDeploymentSettings());
        /// // All of deployment arguments
        /// OctoDeployRelease("http://octopus-deploy.example", "API-XXXXXXXXXXXXXXXXXXXX", "MyGreatProject", new string[] {"Testing", "Testing2"}, "2.1.15-RC" new OctopusDeployReleaseDeploymentSettings {
        /// ShowProgress = true,
        /// ForcePackageDownload = true,
        /// WaitForDeployment = true,
        /// DeploymentTimeout = TimeSpan.FromMinutes(1),
        /// CancelOnTimeout = true,
        /// DeploymentChecksLeapCycle = TimeSpan.FromMinutes(77),
        /// GuidedFailure = true,
        /// SpecificMachines = new string[] { "Machine1", "Machine2" },
        /// Force = true,
        /// SkipSteps = new[] { "Step1", "Step2" },
        /// NoRawLog = true,
        /// RawLogFile = "someFile.txt",
        /// DeployAt = new DateTime(2010, 6, 15).AddMinutes(1),
        /// Tenant = new[] { "Tenant1", "Tenant2" },
        /// TenantTags = new[] { "Tag1", "Tag2" },
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void OctoDeployRelease(string server, string apiKey, string projectName, string[] deployToMultiple, string releaseNumber, global::Cake.Common.Tools.OctopusDeploy.OctopusDeployReleaseDeploymentSettings settings)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoDeployRelease(Context, server, apiKey, projectName, deployToMultiple, releaseNumber, settings);

        /// <member name="M:Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPromoteRelease(Cake.Core.ICakeContext,System.String,System.String,System.String,System.String,System.String,Cake.Common.Tools.OctopusDeploy.OctopusDeployPromoteReleaseSettings)">
        /// <summary>
        /// Promotes the specified already existing release into a specified environment
        /// See <see href="https://octopus.com/docs/api-and-integration/octo.exe-command-line/promoting-releases">Octopus Documentation</see> for more details.
        /// </summary>
        /// <param name="server">The Octopus server URL.</param>
        /// <param name="apiKey">The user's API key.</param>
        /// <param name="projectName">Name of the target project.</param>
        /// <param name="deployFrom">Source environment name.</param>
        /// <param name="deployTo">Target environment name.</param>
        /// <param name="settings">Deployment settings.</param>
        /// <example>
        /// <code>
        /// // bare minimum
        /// OctoPromoteRelease("http://octopus-deploy.example", "API-XXXXXXXXXXXXXXXXXXXX", "MyGreatProject", "Testing", "Staging", new OctopusDeployPromoteReleaseSettings());
        /// // All of deployment arguments
        /// OctoPromoteRelease("http://octopus-deploy.example", "API-XXXXXXXXXXXXXXXXXXXX", "MyGreatProject", "Testing", "Staging", new OctopusDeployPromoteReleaseSettings {
        /// ShowProgress = true,
        /// ForcePackageDownload = true,
        /// WaitForDeployment = true,
        /// DeploymentTimeout = TimeSpan.FromMinutes(1),
        /// CancelOnTimeout = true,
        /// DeploymentChecksLeapCycle = TimeSpan.FromMinutes(77),
        /// GuidedFailure = true,
        /// SpecificMachines = new string[] { "Machine1", "Machine2" },
        /// Force = true,
        /// SkipSteps = new[] { "Step1", "Step2" },
        /// NoRawLog = true,
        /// RawLogFile = "someFile.txt",
        /// DeployAt = new DateTime(2010, 6, 15).AddMinutes(1),
        /// Tenant = new[] { "Tenant1", "Tenant2" },
        /// TenantTags = new[] { "Tag1", "Tag2" },
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void OctoPromoteRelease(string server, string apiKey, string projectName, string deployFrom, string deployTo, global::Cake.Common.Tools.OctopusDeploy.OctopusDeployPromoteReleaseSettings settings)
            => global::Cake.Common.Tools.OctopusDeploy.OctopusDeployAliases.OctoPromoteRelease(Context, server, apiKey, projectName, deployFrom, deployTo, settings);

        /// <member name="M:Cake.Common.Tools.OpenCover.OpenCoverAliases.OpenCover(Cake.Core.ICakeContext,System.Action{Cake.Core.ICakeContext},Cake.Core.IO.FilePath,Cake.Common.Tools.OpenCover.OpenCoverSettings)">
        /// <summary>
        /// Runs <see href="https://github.com/OpenCover/opencover">OpenCover</see>
        /// for the specified action and settings.
        /// </summary>
        /// <param name="action">The action to run OpenCover for.</param>
        /// <param name="outputFile">The OpenCover output file.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// OpenCover(tool =&gt; {
        /// tool.XUnit2("./**/App.Tests.dll",
        /// new XUnit2Settings {
        /// ShadowCopy = false
        /// });
        /// },
        /// new FilePath("./result.xml"),
        /// new OpenCoverSettings()
        /// .WithFilter("+[App]*")
        /// .WithFilter("-[App.Tests]*"));
        /// </code>
        /// </example>
        /// </member>
        public static void OpenCover(global::System.Action<global::Cake.Core.ICakeContext> action, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.OpenCover.OpenCoverSettings settings)
            => global::Cake.Common.Tools.OpenCover.OpenCoverAliases.OpenCover(Context, action, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Converts the coverage report specified by the glob pattern into human readable form.
        /// </summary>
        /// <param name="pattern">The glob pattern.</param>
        /// <param name="targetDir">The output directory.</param>
        /// <example>
        /// <code>
        /// ReportGenerator("c:/temp/coverage/*.xml", "c:/temp/output");
        /// </code>
        /// </example>
        /// </member>
        public static void ReportGenerator(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.DirectoryPath targetDir)
            => global::Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Context, pattern, targetDir);

        /// <member name="M:Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Core.IO.DirectoryPath,Cake.Common.Tools.ReportGenerator.ReportGeneratorSettings)">
        /// <summary>
        /// Converts the coverage report specified by the glob pattern into human readable form using the specified settings.
        /// </summary>
        /// <param name="pattern">The glob pattern.</param>
        /// <param name="targetDir">The output directory.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ReportGenerator("c:/temp/coverage/*.xml", "c:/temp/output", new ReportGeneratorSettings(){
        /// ToolPath = "c:/tools/reportgenerator.exe"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ReportGenerator(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Core.IO.DirectoryPath targetDir, global::Cake.Common.Tools.ReportGenerator.ReportGeneratorSettings settings)
            => global::Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Context, pattern, targetDir, settings);

        /// <member name="M:Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Converts the specified coverage report into human readable form.
        /// </summary>
        /// <param name="report">The coverage report.</param>
        /// <param name="targetDir">The output directory.</param>
        /// <example>
        /// <code>
        /// ReportGenerator("c:/temp/coverage/report.xml", "c:/temp/output");
        /// </code>
        /// </example>
        /// </member>
        public static void ReportGenerator(global::Cake.Core.IO.FilePath report, global::Cake.Core.IO.DirectoryPath targetDir)
            => global::Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Context, report, targetDir);

        /// <member name="M:Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.DirectoryPath,Cake.Common.Tools.ReportGenerator.ReportGeneratorSettings)">
        /// <summary>
        /// Converts the specified coverage report into human readable form using the specified settings.
        /// </summary>
        /// <param name="report">The coverage report.</param>
        /// <param name="targetDir">The output directory.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// ReportGenerator("c:/temp/coverage.xml", "c:/temp/output", new ReportGeneratorSettings(){
        /// ToolPath = "c:/tools/reportgenerator.exe"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ReportGenerator(global::Cake.Core.IO.FilePath report, global::Cake.Core.IO.DirectoryPath targetDir, global::Cake.Common.Tools.ReportGenerator.ReportGeneratorSettings settings)
            => global::Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Context, report, targetDir, settings);

        /// <member name="M:Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Converts the specified coverage reports into human readable form.
        /// </summary>
        /// <param name="reports">The coverage reports.</param>
        /// <param name="targetDir">The output directory.</param>
        /// <example>
        /// <code>
        /// ReportGenerator(new[] { "c:/temp/coverage1.xml", "c:/temp/coverage2.xml" }, "c:/temp/output");
        /// </code>
        /// </example>
        /// </member>
        public static void ReportGenerator(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> reports, global::Cake.Core.IO.DirectoryPath targetDir)
            => global::Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Context, reports, targetDir);

        /// <member name="M:Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Core.IO.DirectoryPath,Cake.Common.Tools.ReportGenerator.ReportGeneratorSettings)">
        /// <summary>
        /// Converts the specified coverage reports into human readable form using the specified settings.
        /// </summary>
        /// <param name="reports">The coverage reports.</param>
        /// <param name="targetDir">The output directory.</param>
        /// <param name="settings">The settings.</param>&gt;
        /// <example>
        /// <code>
        /// ReportGenerator(new[] { "c:/temp/coverage1.xml", "c:/temp/coverage2.xml" }, "c:/temp/output", new ReportGeneratorSettings(){
        /// ToolPath = "c:/tools/reportgenerator.exe"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ReportGenerator(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> reports, global::Cake.Core.IO.DirectoryPath targetDir, global::Cake.Common.Tools.ReportGenerator.ReportGeneratorSettings settings)
            => global::Cake.Common.Tools.ReportGenerator.ReportGeneratorAliases.ReportGenerator(Context, reports, targetDir, settings);

        /// <member name="M:Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath)">
        /// <summary>
        /// Converts the reports in the specified directory into human readable form.
        /// </summary>
        /// <param name="inputFolder">The input folder.</param>
        /// <example>
        /// <para>Provide only an input folder, which will causes ReportUnit to search entire directory for report files.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// ReportUnit("c:/temp");
        /// </code>
        /// </example>
        /// </member>
        public static void ReportUnit(global::Cake.Core.IO.DirectoryPath inputFolder)
            => global::Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Context, inputFolder);

        /// <member name="M:Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Common.Tools.ReportUnit.ReportUnitSettings)">
        /// <summary>
        /// Converts the reports in the specified directory into human readable form.
        /// </summary>
        /// <param name="inputFolder">The input folder.</param>
        /// <param name="settings">The ReportUnit settings.</param>
        /// <example>
        /// <para>Provide an input folder and custom ToolPath, which will causes ReportUnit to search entire directory for report files.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// ReportUnit("c:/temp", new ReportUnitSettings(){
        /// ToolPath = "c:/tools/reportunit.exe"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ReportUnit(global::Cake.Core.IO.DirectoryPath inputFolder, global::Cake.Common.Tools.ReportUnit.ReportUnitSettings settings)
            => global::Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Context, inputFolder, settings);

        /// <member name="M:Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.DirectoryPath,Cake.Common.Tools.ReportUnit.ReportUnitSettings)">
        /// <summary>
        /// Converts the reports in the specified directory into human readable form and outputs to specified folder.
        /// </summary>
        /// <param name="inputFolder">The input folder.</param>
        /// <param name="outputFolder">The output folder.</param>
        /// <param name="settings">The ReportUnit settings.</param>
        /// <example>
        /// <para>Provide both input and output folder, which will causes ReportUnit to search entire directory for report files, and output the results to specified location.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// ReportUnit("c:/temp/input", "c:/temp/output");
        /// </code>
        /// </example>
        /// </member>
        public static void ReportUnit(global::Cake.Core.IO.DirectoryPath inputFolder, global::Cake.Core.IO.DirectoryPath outputFolder, global::Cake.Common.Tools.ReportUnit.ReportUnitSettings settings)
            => global::Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Context, inputFolder, outputFolder, settings);

        /// <member name="M:Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Converts the single specified report into human readable form and outputs to specified file.
        /// </summary>
        /// <param name="inputFile">The input file.</param>
        /// <param name="outputFile">The output file.</param>
        /// <example>
        /// <para>Provide both input and output file, which will causes ReportUnit to transform only the specific file, and output to the specified location.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// ReportUnit("c:/temp/input", "c:/temp/output");
        /// </code>
        /// </example>
        /// </member>
        public static void ReportUnit(global::Cake.Core.IO.FilePath inputFile, global::Cake.Core.IO.FilePath outputFile)
            => global::Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Context, inputFile, outputFile);

        /// <member name="M:Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Common.Tools.ReportUnit.ReportUnitSettings)">
        /// <summary>
        /// Converts the single specified report into human readable form and outputs to specified file.
        /// </summary>
        /// <param name="inputFile">The input file.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="settings">The ReportUnit settings.</param>
        /// <example>
        /// <para>Provide both input and output file, which will causes ReportUnit to transform only the specific file, and output to the specified location.  Also use a custom path for the reportunit.exe.</para>
        /// <para>Cake task:</para>
        /// <code>
        /// ReportUnit("c:/temp/input", "c:/temp/output", new ReportUnitSettings(){
        /// ToolPath = "c:/tools/reportunit.exe"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void ReportUnit(global::Cake.Core.IO.FilePath inputFile, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.ReportUnit.ReportUnitSettings settings)
            => global::Cake.Common.Tools.ReportUnit.ReportUnitAliases.ReportUnit(Context, inputFile, outputFile, settings);

        /// <member name="M:Cake.Common.Tools.Roundhouse.RoundhouseAliases.RoundhouseMigrate(Cake.Core.ICakeContext,Cake.Common.Tools.Roundhouse.RoundhouseSettings)">
        /// <summary>
        /// Executes Roundhouse with the given configured settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// RoundhouseMigrate(new RoundhouseSettings{
        /// ServerName = "Sql2008R2",
        /// DatabaseName = "AdventureWorks2008R2",
        /// SqlFilesDirectory = "./src/sql"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void RoundhouseMigrate(global::Cake.Common.Tools.Roundhouse.RoundhouseSettings settings)
            => global::Cake.Common.Tools.Roundhouse.RoundhouseAliases.RoundhouseMigrate(Context, settings);

        /// <member name="M:Cake.Common.Tools.Roundhouse.RoundhouseAliases.RoundhouseDrop(Cake.Core.ICakeContext,Cake.Common.Tools.Roundhouse.RoundhouseSettings)">
        /// <summary>
        /// Executes Roundhouse migration to drop the database using the provided settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// RoundhouseDrop(new RoundhouseSettings{
        /// ServerName = "Sql2008R2",
        /// DatabaseName = "AdventureWorks2008R2"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void RoundhouseDrop(global::Cake.Common.Tools.Roundhouse.RoundhouseSettings settings)
            => global::Cake.Common.Tools.Roundhouse.RoundhouseAliases.RoundhouseDrop(Context, settings);

        /// <member name="M:Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.SignTool.SignToolSignSettings)">
        /// <summary>
        /// Signs the specified assembly.
        /// </summary>
        /// <param name="assembly">The target assembly.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// Task("Sign")
        /// .IsDependentOn("Clean")
        /// .IsDependentOn("Restore")
        /// .IsDependentOn("Build")
        /// .Does(() =&gt;
        /// {
        /// var file = "Core.dll";
        /// Sign(file, new SignToolSignSettings {
        /// TimeStampUri = new Uri("http://timestamp.digicert.com"),
        /// CertPath = "digitalcertificate.pfx",
        /// Password = "TopSecret"
        /// });
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void Sign(string assembly, global::Cake.Common.Tools.SignTool.SignToolSignSettings settings)
            => global::Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Context, assembly, settings);

        /// <member name="M:Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.SignTool.SignToolSignSettings)">
        /// <summary>
        /// Signs the specified assembly.
        /// </summary>
        /// <param name="assembly">The target assembly.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// Task("Sign")
        /// .IsDependentOn("Clean")
        /// .IsDependentOn("Restore")
        /// .IsDependentOn("Build")
        /// .Does(() =&gt;
        /// {
        /// var file = new FilePath("Core.dll");
        /// Sign(file, new SignToolSignSettings {
        /// TimeStampUri = new Uri("http://timestamp.digicert.com"),
        /// CertPath = "digitalcertificate.pfx",
        /// Password = "TopSecret"
        /// });
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void Sign(global::Cake.Core.IO.FilePath assembly, global::Cake.Common.Tools.SignTool.SignToolSignSettings settings)
            => global::Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Context, assembly, settings);

        /// <member name="M:Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.SignTool.SignToolSignSettings)">
        /// <summary>
        /// Signs the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The target assembly.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// Task("Sign")
        /// .IsDependentOn("Clean")
        /// .IsDependentOn("Restore")
        /// .IsDependentOn("Build")
        /// .Does(() =&gt;
        /// {
        /// var files = new string[] { "Core.dll", "Common.dll" };
        /// Sign(files, new SignToolSignSettings {
        /// TimeStampUri = new Uri("http://timestamp.digicert.com"),
        /// CertPath = "digitalcertificate.pfx",
        /// Password = "TopSecret"
        /// });
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void Sign(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.SignTool.SignToolSignSettings settings)
            => global::Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.SignTool.SignToolSignSettings)">
        /// <summary>
        /// Signs the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The target assembly.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// Task("Sign")
        /// .IsDependentOn("Clean")
        /// .IsDependentOn("Restore")
        /// .IsDependentOn("Build")
        /// .Does(() =&gt;
        /// {
        /// var files = GetFiles(solutionDir + "/**/bin/" + configuration + "/**/*.exe");
        /// Sign(files, new SignToolSignSettings {
        /// TimeStampUri = new Uri("http://timestamp.digicert.com"),
        /// CertPath = "digitalcertificate.pfx",
        /// Password = "TopSecret"
        /// });
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void Sign(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.SignTool.SignToolSignSettings settings)
            => global::Cake.Common.Tools.SignTool.SignToolSignAliases.Sign(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowStepDefinitionReport(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Creates a report that shows the usage and binding status of the steps for the entire project.
        /// You can use this report to find both unused code in the automation layer and scenario steps that have no definition yet.
        /// See <see href="https://github.com/techtalk/SpecFlow/wiki/Reporting#step-definition-report">SpecFlow Documentation</see> for more information.
        /// </summary>
        /// <param name="projectFile">The path of the project file containing the feature files.</param>
        /// </member>
        public static void SpecFlowStepDefinitionReport(global::Cake.Core.IO.FilePath projectFile)
            => global::Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowStepDefinitionReport(Context, projectFile);

        /// <member name="M:Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowStepDefinitionReport(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.SpecFlow.StepDefinitionReport.SpecFlowStepDefinitionReportSettings)">
        /// <summary>
        /// Creates a report that shows the usage and binding status of the steps for the entire project.
        /// You can use this report to find both unused code in the automation layer and scenario steps that have no definition yet.
        /// See <see href="https://github.com/techtalk/SpecFlow/wiki/Reporting#step-definition-report">SpecFlow Documentation</see> for more information.
        /// </summary>
        /// <param name="projectFile">The path of the project file containing the feature files.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void SpecFlowStepDefinitionReport(global::Cake.Core.IO.FilePath projectFile, global::Cake.Common.Tools.SpecFlow.StepDefinitionReport.SpecFlowStepDefinitionReportSettings settings)
            => global::Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowStepDefinitionReport(Context, projectFile, settings);

        /// <member name="M:Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowTestExecutionReport(Cake.Core.ICakeContext,System.Action{Cake.Core.ICakeContext},Cake.Core.IO.FilePath)">
        /// <summary>
        /// Creates a formatted HTML report of a test execution.
        /// The report contains a summary about the executed tests and the result and also a detailed report for the individual scenario executions.
        /// See <see href="https://github.com/techtalk/SpecFlow/wiki/Reporting#test-execution-report">SpecFlow Documentation</see> for more information.
        /// </summary>
        /// <param name="action">The action to run SpecFlow for. Supported actions are: MSTest, NUnit3 and XUnit2.</param>
        /// <param name="projectFile">The path of the project file containing the feature files.</param>
        /// </member>
        public static void SpecFlowTestExecutionReport(global::System.Action<global::Cake.Core.ICakeContext> action, global::Cake.Core.IO.FilePath projectFile)
            => global::Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowTestExecutionReport(Context, action, projectFile);

        /// <member name="M:Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowTestExecutionReport(Cake.Core.ICakeContext,System.Action{Cake.Core.ICakeContext},Cake.Core.IO.FilePath,Cake.Common.Tools.SpecFlow.TestExecutionReport.SpecFlowTestExecutionReportSettings)">
        /// <summary>
        /// Creates a formatted HTML report of a test execution.
        /// The report contains a summary about the executed tests and the result and also a detailed report for the individual scenario executions.
        /// See <see href="https://github.com/techtalk/SpecFlow/wiki/Reporting#test-execution-report">SpecFlow Documentation</see> for more information.
        /// </summary>
        /// <param name="action">The action to run SpecFlow for. Supported actions are: MSTest, NUnit, NUnit3, XUnit and XUnit2.</param>
        /// <param name="projectFile">The path of the project file containing the feature files.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void SpecFlowTestExecutionReport(global::System.Action<global::Cake.Core.ICakeContext> action, global::Cake.Core.IO.FilePath projectFile, global::Cake.Common.Tools.SpecFlow.TestExecutionReport.SpecFlowTestExecutionReportSettings settings)
            => global::Cake.Common.Tools.SpecFlow.SpecFlowAliases.SpecFlowTestExecutionReport(Context, action, projectFile, settings);

        /// <member name="M:Cake.Common.Tools.TextTransform.TextTransformAliases.TransformTemplate(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Transform a text template.
        /// </summary>
        /// <example>
        /// <code>
        /// // Transform a .tt template.
        /// var transform = File("./src/Cake/Transform.tt");
        /// TransformTemplate(transform);
        /// </code>
        /// </example>
        /// <param name="sourceFile">The source file.</param>
        /// </member>
        public static void TransformTemplate(global::Cake.Core.IO.FilePath sourceFile)
            => global::Cake.Common.Tools.TextTransform.TextTransformAliases.TransformTemplate(Context, sourceFile);

        /// <member name="M:Cake.Common.Tools.TextTransform.TextTransformAliases.TransformTemplate(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.TextTransform.TextTransformSettings)">
        /// <summary>
        /// Transform a text template.
        /// </summary>
        /// <example>
        /// <code>
        /// // Transform a .tt template.
        /// var transform = File("./src/Cake/Transform.tt");
        /// TransformTemplate(transform, new TextTransformSettings { OutputFile="./src/Cake/Transform.cs" });
        /// </code>
        /// </example>
        /// <param name="sourceFile">The source file.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void TransformTemplate(global::Cake.Core.IO.FilePath sourceFile, global::Cake.Common.Tools.TextTransform.TextTransformSettings settings)
            => global::Cake.Common.Tools.TextTransform.TextTransformAliases.TransformTemplate(Context, sourceFile, settings);

        /// <member name="M:Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all VSTest unit tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// VSTest("./Tests/*.UnitTests.dll");
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// </member>
        public static void VSTest(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Context, pattern);

        /// <member name="M:Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.VSTest.VSTestSettings)">
        /// <summary>
        /// Runs all VSTest unit tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// VSTest("./Tests/*.UnitTests.dll", new VSTestSettings() { Logger = "trx" });
        /// </code>
        /// </example>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void VSTest(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.VSTest.VSTestSettings settings)
            => global::Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all VSTest unit tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var paths = new List&lt;FilePath&gt;() { "./assemblydir1", "./assemblydir2" };
        /// VSTest(paths);
        /// </code>
        /// </example>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// </member>
        public static void VSTest(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths)
            => global::Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Context, assemblyPaths);

        /// <member name="M:Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.VSTest.VSTestSettings)">
        /// <summary>
        /// Runs all VSTest unit tests in the specified assemblies.
        /// </summary>
        /// <example>
        /// <code>
        /// var paths = new List&lt;FilePath&gt;() { "./assemblydir1", "./assemblydir2" };
        /// VSTest(paths, new VSTestSettings() { InIsolation = true });
        /// </code>
        /// </example>
        /// <param name="assemblyPaths">The assembly paths.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void VSTest(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblyPaths, global::Cake.Common.Tools.VSTest.VSTestSettings settings)
            => global::Cake.Common.Tools.VSTest.VSTestAliases.VSTest(Context, assemblyPaths, settings);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLegacy(Cake.Core.ICakeContext,System.Boolean)">
        /// <summary>
        /// Gets the legacy Visual Studio product installation paths.
        /// </summary>
        /// <param name="latest">Get the latest version.</param>
        /// <returns>The Visual Studio installation path.</returns>
        /// <example>
        /// <code>
        /// var legacyInstallationPath = VSWhereLegacy(true);
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPath VSWhereLegacy(bool latest)
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLegacy(Context, latest);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLegacy(Cake.Core.ICakeContext,Cake.Common.Tools.VSWhere.Legacy.VSWhereLegacySettings)">
        /// <summary>
        /// Gets the legacy Visual Studio product installation paths.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The Visual Studio installation paths.</returns>
        /// <example>
        /// <code>
        /// var legacyInstallationPaths = VSWhereLegacy(new VSWhereLegacySettings());
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection VSWhereLegacy(global::Cake.Common.Tools.VSWhere.Legacy.VSWhereLegacySettings settings)
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLegacy(Context, settings);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLatest(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets the latest Visual Studio product installation path.
        /// </summary>
        /// <returns>The Visual Studio installation path.</returns>
        /// <example>
        /// <code>
        /// var latestInstallationPath = VSWhereLatest();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPath VSWhereLatest()
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLatest(Context);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLatest(Cake.Core.ICakeContext,Cake.Common.Tools.VSWhere.Latest.VSWhereLatestSettings)">
        /// <summary>
        /// Gets the latest Visual Studio product installation path.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The Visual Studio installation path.</returns>
        /// <example>
        /// <code>
        /// var latestInstallationPath = VSWhereLatest(new VSWhereLatestSettings { Requires = "'Microsoft.Component.MSBuild" });
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPath VSWhereLatest(global::Cake.Common.Tools.VSWhere.Latest.VSWhereLatestSettings settings)
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereLatest(Context, settings);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereAll(Cake.Core.ICakeContext)">
        /// <summary>
        /// Gets all Visual Studio product installation paths.
        /// </summary>
        /// <returns>The Visual Studio installation paths.</returns>
        /// <example>
        /// <code>
        /// var latestInstallationPaths = VSWhereAll();
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection VSWhereAll()
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereAll(Context);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereAll(Cake.Core.ICakeContext,Cake.Common.Tools.VSWhere.All.VSWhereAllSettings)">
        /// <summary>
        /// Gets all Visual Studio product installation paths.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The Visual Studio installation paths.</returns>
        /// <example>
        /// <code>
        /// var latestInstallationPaths = VSWhereAll(new VSWhereAllSettings { Requires = "'Microsoft.Component.MSBuild" });
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection VSWhereAll(global::Cake.Common.Tools.VSWhere.All.VSWhereAllSettings settings)
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereAll(Context, settings);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereProducts(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Gets Visual Studio product installation paths.
        /// </summary>
        /// <param name="products">The products to find.</param>
        /// <returns>The Visual Studio installation paths.</returns>
        /// <example>
        /// <code>
        /// var latestInstallationPaths = VSWhereProducts("Microsoft.VisualStudio.Product.BuildTools");
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection VSWhereProducts(string products)
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereProducts(Context, products);

        /// <member name="M:Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereProducts(Cake.Core.ICakeContext,System.String,Cake.Common.Tools.VSWhere.Product.VSWhereProductSettings)">
        /// <summary>
        /// Gets Visual Studio product installation paths.
        /// </summary>
        /// <param name="products">The products to find.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>The Visual Studio installation paths.</returns>
        /// <example>
        /// <code>
        /// var latestInstallationPaths = VSWhereProducts("Microsoft.VisualStudio.Product.BuildTools", new VSWhereProductSettings { Requires = "'Microsoft.Component.MSBuild" });
        /// </code>
        /// </example>
        /// </member>
        public static global::Cake.Core.IO.DirectoryPathCollection VSWhereProducts(string products, global::Cake.Common.Tools.VSWhere.Product.VSWhereProductSettings settings)
            => global::Cake.Common.Tools.VSWhere.VSWhereAliases.VSWhereProducts(Context, products, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXCandle(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.WiX.CandleSettings)">
        /// <summary>
        /// Compiles all <c>.wxs</c> sources matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// CandleSettings settings = new CandleSettings {
        /// Architecture = Architecture.X64,
        /// Verbose = true
        /// };
        /// WiXCandle("./src/*.wxs", settings);
        /// </code>
        /// </example>
        /// <param name="pattern">The globbing pattern.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXCandle(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.WiX.CandleSettings? settings = null)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXCandle(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXCandle(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.WiX.CandleSettings)">
        /// <summary>
        /// Compiles all <c>.wxs</c> sources in the provided source files.
        /// </summary>
        /// <example>
        /// <code>
        /// var files = GetFiles("./src/*.wxs");
        /// CandleSettings settings = new CandleSettings {
        /// Architecture = Architecture.X64,
        /// Verbose = true
        /// };
        /// WiXCandle(files, settings);
        /// </code>
        /// </example>
        /// <param name="sourceFiles">The source files.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXCandle(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> sourceFiles, global::Cake.Common.Tools.WiX.CandleSettings? settings = null)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXCandle(Context, sourceFiles, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXLight(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.WiX.LightSettings)">
        /// <summary>
        /// Links all <c>.wixobj</c> files matching the specified pattern.
        /// </summary>
        /// <example>
        /// <code>
        /// LightSettings settings = new LightSettings {
        /// RawArguments = "-O1 -pedantic -v"
        /// };
        /// WiXLight("./src/*.wixobj", settings);
        /// </code>
        /// </example>
        /// <param name="pattern">The globbing pattern.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXLight(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.WiX.LightSettings? settings = null)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXLight(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXLight(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.WiX.LightSettings)">
        /// <summary>
        /// Links all <c>.wixobj</c> files in the provided object files.
        /// </summary>
        /// <example>
        /// <code>
        /// var files = GetFiles("./src/*.wxs");
        /// LightSettings settings = new LightSettings {
        /// RawArguments = "-O1 -pedantic -v"
        /// };
        /// WiXLight(files, settings);
        /// </code>
        /// </example>
        /// <param name="objectFiles">The object files.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXLight(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> objectFiles, global::Cake.Common.Tools.WiX.LightSettings? settings = null)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXLight(Context, objectFiles, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.FilePath,Cake.Common.Tools.WiX.Heat.WiXHarvestType)">
        /// <summary>
        /// Harvests files in the provided object files.
        /// </summary>
        /// <example>
        /// <code>
        /// DirectoryPath harvestDirectory = Directory("./src");
        /// var filePath = new FilePath("Wix.Directory.wxs");
        /// WiXHeat(harvestDirectory, filePath, WiXHarvestType.Dir);
        /// </code>
        /// </example>
        /// <param name="directoryPath">The object files.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="harvestType">The WiX harvest type.</param>
        /// </member>
        public static void WiXHeat(global::Cake.Core.IO.DirectoryPath directoryPath, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.WiX.Heat.WiXHarvestType harvestType)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Context, directoryPath, outputFile, harvestType);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Cake.Core.ICakeContext,Cake.Core.IO.DirectoryPath,Cake.Core.IO.FilePath,Cake.Common.Tools.WiX.Heat.WiXHarvestType,Cake.Common.Tools.WiX.Heat.HeatSettings)">
        /// <summary>
        /// Harvests files in the provided directory path.
        /// </summary>
        /// <example>
        /// <code>
        /// DirectoryPath harvestDirectory = Directory("./src");
        /// var filePath = File("Wix.Directory.wxs");
        /// Information(MakeAbsolute(harvestDirectory).FullPath);
        /// WiXHeat(harvestDirectory, filePath, WiXHarvestType.Dir, new HeatSettings { NoLogo = true });
        /// </code>
        /// </example>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="harvestType">The WiX harvest type.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXHeat(global::Cake.Core.IO.DirectoryPath directoryPath, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.WiX.Heat.WiXHarvestType harvestType, global::Cake.Common.Tools.WiX.Heat.HeatSettings settings)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Context, directoryPath, outputFile, harvestType, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Common.Tools.WiX.Heat.WiXHarvestType)">
        /// <summary>
        /// Harvests from the desired files.
        /// </summary>
        /// <example>
        /// <code>
        /// var harvestFile = File("./tools/Cake/Cake.Core.dll");
        /// var filePath = File("Wix.File.wxs");
        /// WiXHeat(harvestFile, filePath, WiXHarvestType.File);
        /// </code>
        /// </example>
        /// <param name="objectFile">The object file.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="harvestType">The WiX harvest type.</param>
        /// </member>
        public static void WiXHeat(global::Cake.Core.IO.FilePath objectFile, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.WiX.Heat.WiXHarvestType harvestType)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Context, objectFile, outputFile, harvestType);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Common.Tools.WiX.Heat.WiXHarvestType,Cake.Common.Tools.WiX.Heat.HeatSettings)">
        /// <summary>
        /// Harvests from the desired files.
        /// </summary>
        /// <example>
        /// <code>
        /// var harvestFiles = File("./tools/Cake/*.dll");
        /// var filePath = File("Wix.File.wxs");
        /// WiXHeat(harvestFiles, filePath, WiXHarvestType.File, new HeatSettings { NoLogo = true });
        /// </code>
        /// </example>
        /// <param name="objectFile">The object file.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="harvestType">The WiX harvest type.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXHeat(global::Cake.Core.IO.FilePath objectFile, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.WiX.Heat.WiXHarvestType harvestType, global::Cake.Common.Tools.WiX.Heat.HeatSettings settings)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Context, objectFile, outputFile, harvestType, settings);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Cake.Core.ICakeContext,System.String,Cake.Core.IO.FilePath,Cake.Common.Tools.WiX.Heat.WiXHarvestType)">
        /// <summary>
        /// Harvests files for a website or performance.
        /// </summary>
        /// <example>
        /// <code>
        /// var filePath = File("Wix.Website.wxs");
        /// WiXHeat("Default Web Site", filePath, WiXHarvestType.Website);
        /// </code>
        /// </example>
        /// <param name="harvestTarget">The harvest target.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="harvestType">The WiX harvest type.</param>
        /// </member>
        public static void WiXHeat(string harvestTarget, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.WiX.Heat.WiXHarvestType harvestType)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Context, harvestTarget, outputFile, harvestType);

        /// <member name="M:Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Cake.Core.ICakeContext,System.String,Cake.Core.IO.FilePath,Cake.Common.Tools.WiX.Heat.WiXHarvestType,Cake.Common.Tools.WiX.Heat.HeatSettings)">
        /// <summary>
        /// Harvests files for a website or performance.
        /// </summary>
        /// <example>
        /// <code>
        /// var filePath = File("Wix.Website.wxs");
        /// WiXHeat("Default Web Site", filePath, WiXHarvestType.Website, new HeatSettings { NoLogo = true });
        /// </code>
        /// </example>
        /// <param name="harvestTarget">The harvest target.</param>
        /// <param name="outputFile">The output file.</param>
        /// <param name="harvestType">The WiX harvest type.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void WiXHeat(string harvestTarget, global::Cake.Core.IO.FilePath outputFile, global::Cake.Common.Tools.WiX.Heat.WiXHarvestType harvestType, global::Cake.Common.Tools.WiX.Heat.HeatSettings settings)
            => global::Cake.Common.Tools.WiX.WiXAliases.WiXHeat(Context, harvestTarget, outputFile, harvestType, settings);

        /// <member name="M:Cake.Common.Tools.XBuild.XBuildAliases.XBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Builds the specified solution using XBuild.
        /// </summary>
        /// <param name="solution">The solution to build.</param>
        /// <example>
        /// <code>
        /// XBuild("./src/Cake.sln");
        /// </code>
        /// </example>
        /// </member>
        public static void XBuild(global::Cake.Core.IO.FilePath solution)
            => global::Cake.Common.Tools.XBuild.XBuildAliases.XBuild(Context, solution);

        /// <member name="M:Cake.Common.Tools.XBuild.XBuildAliases.XBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.Action{Cake.Common.Tools.XBuild.XBuildSettings})">
        /// <summary>
        /// Builds the specified solution using XBuild.
        /// </summary>
        /// <param name="solution">The solution to build.</param>
        /// <param name="configurator">The settings configurator.</param>
        /// <example>
        /// <code>
        /// XBuild("./src/Cake.sln", configurator =&gt;
        /// configurator.SetConfiguration("Debug")
        /// .SetVerbosity(Verbosity.Minimal)
        /// .UseToolVersion(XBuildToolVersion.NET40));
        /// </code>
        /// </example>
        /// </member>
        public static void XBuild(global::Cake.Core.IO.FilePath solution, global::System.Action<global::Cake.Common.Tools.XBuild.XBuildSettings> configurator)
            => global::Cake.Common.Tools.XBuild.XBuildAliases.XBuild(Context, solution, configurator);

        /// <member name="M:Cake.Common.Tools.XBuild.XBuildAliases.XBuild(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Common.Tools.XBuild.XBuildSettings)">
        /// <summary>
        /// Builds the specified solution using XBuild.
        /// </summary>
        /// <param name="solution">The solution to build.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// XBuild("./src/Cake.sln", new XBuildSettings {
        /// Verbosity = Verbosity.Minimal,
        /// ToolVersion = XBuildToolVersion.NET40,
        /// Configuration = "Release"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XBuild(global::Cake.Core.IO.FilePath solution, global::Cake.Common.Tools.XBuild.XBuildSettings settings)
            => global::Cake.Common.Tools.XBuild.XBuildAliases.XBuild(Context, solution, settings);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all xUnit.net v2 tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// XUnit2("./src/**/bin/Release/*.Tests.dll");
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit2(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Context, pattern);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.XUnit.XUnit2Settings)">
        /// <summary>
        /// Runs all xUnit.net v2 tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// XUnit2("./src/**/bin/Release/*.Tests.dll",
        /// new XUnit2Settings {
        /// Parallelism = ParallelismOption.All,
        /// HtmlReport = true,
        /// NoAppDomain = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit2(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.XUnit.XUnit2Settings settings)
            => global::Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Runs all xUnit.net v2 tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// XUnit2(new []{
        /// "./src/Cake.Common.Tests/bin/Release/Cake.Common.Tests.dll",
        /// "./src/Cake.Core.Tests/bin/Release/Cake.Core.Tests.dll",
        /// "./src/Cake.NuGet.Tests/bin/Release/Cake.NuGet.Tests.dll",
        /// "./src/Cake.Tests/bin/Release/Cake.Tests.dll"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit2(global::System.Collections.Generic.IEnumerable<string> assemblies)
            => global::Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all xUnit.net tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// XUnit2(testAssemblies);
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit2(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies)
            => global::Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.XUnit.XUnit2Settings)">
        /// <summary>
        /// Runs all xUnit.net v2 tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// XUnit2(new []{
        /// "./src/Cake.Common.Tests/bin/Release/Cake.Common.Tests.dll",
        /// "./src/Cake.Core.Tests/bin/Release/Cake.Core.Tests.dll",
        /// "./src/Cake.NuGet.Tests/bin/Release/Cake.NuGet.Tests.dll",
        /// "./src/Cake.Tests/bin/Release/Cake.Tests.dll"
        /// },
        /// new XUnit2Settings {
        /// Parallelism = ParallelismOption.All,
        /// HtmlReport = true,
        /// NoAppDomain = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit2(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.XUnit.XUnit2Settings settings)
            => global::Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.XUnit.XUnit2Settings)">
        /// <summary>
        /// Runs all xUnit.net v2 tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// XUnit2(testAssemblies,
        /// new XUnit2Settings {
        /// Parallelism = ParallelismOption.All,
        /// HtmlReport = true,
        /// NoAppDomain = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit2(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.XUnit.XUnit2Settings settings)
            => global::Cake.Common.Tools.XUnit.XUnit2Aliases.XUnit2(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern)">
        /// <summary>
        /// Runs all xUnit.net tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <example>
        /// <code>
        /// XUnit("./src/**/bin/Release/*.Tests.dll");
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit(global::Cake.Core.IO.GlobPattern pattern)
            => global::Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Context, pattern);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Cake.Core.ICakeContext,Cake.Core.IO.GlobPattern,Cake.Common.Tools.XUnit.XUnitSettings)">
        /// <summary>
        /// Runs all xUnit.net tests in the assemblies matching the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// XUnit("./src/**/bin/Release/*.Tests.dll",
        /// new XUnitSettings {
        /// HtmlReport = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit(global::Cake.Core.IO.GlobPattern pattern, global::Cake.Common.Tools.XUnit.XUnitSettings settings)
            => global::Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Context, pattern, settings);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Runs all xUnit.net tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// XUnit(new []{
        /// "./src/Cake.Common.Tests/bin/Release/Cake.Common.Tests.dll",
        /// "./src/Cake.Core.Tests/bin/Release/Cake.Core.Tests.dll",
        /// "./src/Cake.NuGet.Tests/bin/Release/Cake.NuGet.Tests.dll",
        /// "./src/Cake.Tests/bin/Release/Cake.Tests.dll"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit(global::System.Collections.Generic.IEnumerable<string> assemblies)
            => global::Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath})">
        /// <summary>
        /// Runs all xUnit.net tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// XUnit(testAssemblies);
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies)
            => global::Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Context, assemblies);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String},Cake.Common.Tools.XUnit.XUnitSettings)">
        /// <summary>
        /// Runs all xUnit.net tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// XUnit(new []{
        /// "./src/Cake.Common.Tests/bin/Release/Cake.Common.Tests.dll",
        /// "./src/Cake.Core.Tests/bin/Release/Cake.Core.Tests.dll",
        /// "./src/Cake.NuGet.Tests/bin/Release/Cake.NuGet.Tests.dll",
        /// "./src/Cake.Tests/bin/Release/Cake.Tests.dll"
        /// },
        /// new XUnitSettings {
        /// HtmlReport = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit(global::System.Collections.Generic.IEnumerable<string> assemblies, global::Cake.Common.Tools.XUnit.XUnitSettings settings)
            => global::Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{Cake.Core.IO.FilePath},Cake.Common.Tools.XUnit.XUnitSettings)">
        /// <summary>
        /// Runs all xUnit.net tests in the specified assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <code>
        /// var testAssemblies = GetFiles("./src/**/bin/Release/*.Tests.dll");
        /// XUnit(testAssemblies,
        /// new XUnitSettings {
        /// HtmlReport = true,
        /// OutputDirectory = "./build"
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static void XUnit(global::System.Collections.Generic.IEnumerable<global::Cake.Core.IO.FilePath> assemblies, global::Cake.Common.Tools.XUnit.XUnitSettings settings)
            => global::Cake.Common.Tools.XUnit.XUnitAliases.XUnit(Context, assemblies, settings);

        /// <member name="M:Cake.Common.Xml.XmlPeekAliases.XmlPeek(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String)">
        /// <summary>
        /// Gets the value of a target node.
        /// </summary>
        /// <returns>The value found at the given XPath query.</returns>
        /// <param name="filePath">The target file.</param>
        /// <param name="xpath">The xpath of the node to get.</param>
        /// <example>
        /// <code>
        /// string autoFacVersion = XmlPeek("./src/Cake/packages.config", "/packages/package[@id='Autofac']/@version");
        /// </code>
        /// </example>
        /// </member>
        public static string XmlPeek(global::Cake.Core.IO.FilePath filePath, string xpath)
            => global::Cake.Common.Xml.XmlPeekAliases.XmlPeek(Context, filePath, xpath);

        /// <member name="M:Cake.Common.Xml.XmlPeekAliases.XmlPeek(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String,Cake.Common.Xml.XmlPeekSettings)">
        /// <summary>
        /// Get the value of a target node.
        /// </summary>
        /// <returns>The value found at the given XPath query.</returns>
        /// <param name="filePath">The target file.</param>
        /// <param name="xpath">The xpath of the nodes to set.</param>
        /// <param name="settings">Additional settings to tweak Xml Peek behavior.</param>
        /// <example>
        /// <code>
        /// <para>XML document:</para>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="UTF-8"?>
        /// <pastery xmlns = "https://cakebuild.net/pastery" >
        /// <cake price="1.62" />
        /// </pastery>
        /// ]]>
        /// </code>
        /// <para>XmlPeek usage:</para>
        /// <code>
        /// string version = XmlPeek("./pastry.xml", "/pastry:pastry/pastry:cake/@price",
        /// new XmlPeekSettings {
        /// Namespaces = new Dictionary&lt;string, string&gt; {{ "pastry", "https://cakebuild.net/pastry" }}
        /// });
        /// string unknown = XmlPeek("./pastry.xml", "/pastry:pastry/pastry:cake/@recipe",
        /// new XmlPeekSettings {
        /// Namespaces = new Dictionary&lt;string, string&gt; {{ "pastry", "https://cakebuild.net/pastry" }},
        /// SuppressWarning = true
        /// });
        /// </code>
        /// </example>
        /// </member>
        public static string XmlPeek(global::Cake.Core.IO.FilePath filePath, string xpath, global::Cake.Common.Xml.XmlPeekSettings settings)
            => global::Cake.Common.Xml.XmlPeekAliases.XmlPeek(Context, filePath, xpath, settings);

        /// <member name="M:Cake.Common.Xml.XmlPokeAliases.XmlPoke(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String,System.String)">
        /// <summary>
        /// Set the value of, or remove, target nodes.
        /// </summary>
        /// <param name="filePath">The target file.</param>
        /// <param name="xpath">The xpath of the nodes to set.</param>
        /// <param name="value">The value to set too. Leave blank to remove the selected nodes.</param>
        /// <example>
        /// <para>
        /// Change the <c>server</c> setting in the configuration from <c>testhost.somecompany.com</c>
        /// to <c>productionhost.somecompany.com</c>.
        /// </para>
        /// <para>XML file:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var file = File("test.xml");
        /// XmlPoke(file, "/configuration/appSettings/add[@key = 'server']/@value", "productionhost.somecompany.com");
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Modify the <c>noNamespaceSchemaLocation</c> in an XML file.
        /// </para>
        /// <para>XML file:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <Commands xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:noNamespaceSchemaLocation="Path Value">
        /// </Commands>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var file = File("test.xml");
        /// XmlPoke(file, "/Commands/@xsi:noNamespaceSchemaLocation", "d:\\Commands.xsd", new XmlPokeSettings {
        /// Namespaces = new Dictionary<string, string> {
        /// { /* Prefix */ "xsi", /* URI */ "http://www.w3.org/2001/XMLSchema-instance" }
        /// }
        /// });
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Remove an app setting from a config file.
        /// </para>
        /// <para>XML file:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// <add key="testing" value="true" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var file = File("test.xml");
        /// XmlPoke(file, "/configuration/appSettings/add[@testing]", null);
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <para>
        /// Credit to NAnt for the original example.
        /// http://nant.sourceforge.net/release/latest/help/tasks/xmlpoke.html.
        /// </para>
        /// </member>
        public static void XmlPoke(global::Cake.Core.IO.FilePath filePath, string xpath, string value)
            => global::Cake.Common.Xml.XmlPokeAliases.XmlPoke(Context, filePath, xpath, value);

        /// <member name="M:Cake.Common.Xml.XmlPokeAliases.XmlPoke(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,System.String,System.String,Cake.Common.Xml.XmlPokeSettings)">
        /// <summary>
        /// Set the value of, or remove, target nodes.
        /// </summary>
        /// <param name="filePath">The target file.</param>
        /// <param name="xpath">The xpath of the nodes to set.</param>
        /// <param name="value">The value to set too. Leave blank to remove the selected nodes.</param>
        /// <param name="settings">Additional settings to tweak Xml Poke behavior.</param>
        /// <example>
        /// <para>
        /// Change the <c>server</c> setting in the configuration from <c>testhost.somecompany.com</c>
        /// to <c>productionhost.somecompany.com</c>.
        /// </para>
        /// <para>XML file:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var file = File("test.xml");
        /// XmlPoke(file, "/configuration/appSettings/add[@key = 'server']/@value", "productionhost.somecompany.com");
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Modify the <c>noNamespaceSchemaLocation</c> in an XML file.
        /// </para>
        /// <para>XML file:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <Commands xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:noNamespaceSchemaLocation="Path Value">
        /// </Commands>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var file = File("test.xml");
        /// XmlPoke(file, "/Commands/@xsi:noNamespaceSchemaLocation", "d:\\Commands.xsd", new XmlPokeSettings {
        /// Namespaces = new Dictionary<string, string> {
        /// { /* Prefix */ "xsi", /* URI */ "http://www.w3.org/2001/XMLSchema-instance" }
        /// }
        /// });
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Remove an app setting from a config file.
        /// </para>
        /// <para>XML file:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// <add key="testing" value="true" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var file = File("test.xml");
        /// XmlPoke(file, "/configuration/appSettings/add[@testing]", null);
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <para>
        /// Credit to NAnt for the original example.
        /// http://nant.sourceforge.net/release/latest/help/tasks/xmlpoke.html.
        /// </para>
        /// </member>
        public static void XmlPoke(global::Cake.Core.IO.FilePath filePath, string xpath, string value, global::Cake.Common.Xml.XmlPokeSettings settings)
            => global::Cake.Common.Xml.XmlPokeAliases.XmlPoke(Context, filePath, xpath, value, settings);

        /// <member name="M:Cake.Common.Xml.XmlPokeAliases.XmlPokeString(Cake.Core.ICakeContext,System.String,System.String,System.String)">
        /// <summary>
        /// Set the value of, or remove, target nodes.
        /// </summary>
        /// <param name="sourceXml">The source xml to transform.</param>
        /// <param name="xpath">The xpath of the nodes to set.</param>
        /// <param name="value">The value to set too. Leave blank to remove the selected nodes.</param>
        /// <returns>Resulting XML.</returns>
        /// <example>
        /// <para>
        /// Change the <c>server</c> setting in the configuration from <c>testhost.somecompany.com</c>
        /// to <c>productionhost.somecompany.com</c>.
        /// </para>
        /// <para>XML string:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var result = XmlPokeString(xmlString, "/configuration/appSettings/add[@key = 'server']/@value", "productionhost.somecompany.com");
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Modify the <c>noNamespaceSchemaLocation</c> in an XML file.
        /// </para>
        /// <para>XML string:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <Commands xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:noNamespaceSchemaLocation="Path Value">
        /// </Commands>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var result = XmlPokeString(xmlString, "/Commands/@xsi:noNamespaceSchemaLocation", "d:\\Commands.xsd", new XmlPokeSettings {
        /// Namespaces = new Dictionary<string, string> {
        /// { /* Prefix */ "xsi", /* URI */ "http://www.w3.org/2001/XMLSchema-instance" }
        /// }
        /// });
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Remove an app setting from a config file.
        /// </para>
        /// <para>XML string:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// <add key="testing" value="true" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var result = XmlPokeString(xmlString, "/configuration/appSettings/add[@testing]", null);
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <para>
        /// Credit to NAnt for the original example.
        /// http://nant.sourceforge.net/release/latest/help/tasks/xmlpoke.html.
        /// </para>
        /// </member>
        public static string XmlPokeString(string sourceXml, string xpath, string value)
            => global::Cake.Common.Xml.XmlPokeAliases.XmlPokeString(Context, sourceXml, xpath, value);

        /// <member name="M:Cake.Common.Xml.XmlPokeAliases.XmlPokeString(Cake.Core.ICakeContext,System.String,System.String,System.String,Cake.Common.Xml.XmlPokeSettings)">
        /// <summary>
        /// Set the value of, or remove, target nodes.
        /// </summary>
        /// <param name="sourceXml">The source xml to transform.</param>
        /// <param name="xpath">The xpath of the nodes to set.</param>
        /// <param name="value">The value to set too. Leave blank to remove the selected nodes.</param>
        /// <param name="settings">Additional settings to tweak Xml Poke behavior.</param>
        /// <returns>Resulting XML.</returns>
        /// <example>
        /// <para>
        /// Change the <c>server</c> setting in the configuration from <c>testhost.somecompany.com</c>
        /// to <c>productionhost.somecompany.com</c>.
        /// </para>
        /// <para>XML string:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var result = XmlPokeString(xmlString, "/configuration/appSettings/add[@key = 'server']/@value", "productionhost.somecompany.com");
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Modify the <c>noNamespaceSchemaLocation</c> in an XML file.
        /// </para>
        /// <para>XML string:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <Commands xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:noNamespaceSchemaLocation="Path Value">
        /// </Commands>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var result = XmlPokeString(xmlString, "/Commands/@xsi:noNamespaceSchemaLocation", "d:\\Commands.xsd", new XmlPokeSettings {
        /// Namespaces = new Dictionary<string, string> {
        /// { /* Prefix */ "xsi", /* URI */ "http://www.w3.org/2001/XMLSchema-instance" }
        /// }
        /// });
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <example>
        /// <para>
        /// Remove an app setting from a config file.
        /// </para>
        /// <para>XML string:</para>
        /// <code>
        /// <![CDATA[
        /// <?xml version="1.0" encoding="utf-8" ?>
        /// <configuration>
        /// <appSettings>
        /// <add key="server" value="testhost.somecompany.com" />
        /// <add key="testing" value="true" />
        /// </appSettings>
        /// </configuration>
        /// ]]>
        /// </code>
        /// <para>Cake Task:</para>
        /// <code>
        /// <![CDATA[
        /// Task("Transform")
        /// .Does(() =>
        /// {
        /// var result = XmlPokeString(xmlString, "/configuration/appSettings/add[@testing]", null);
        /// });
        /// ]]>
        /// </code>
        /// </example>
        /// <para>
        /// Credit to NAnt for the original example.
        /// http://nant.sourceforge.net/release/latest/help/tasks/xmlpoke.html.
        /// </para>
        /// </member>
        public static string XmlPokeString(string sourceXml, string xpath, string value, global::Cake.Common.Xml.XmlPokeSettings settings)
            => global::Cake.Common.Xml.XmlPokeAliases.XmlPokeString(Context, sourceXml, xpath, value, settings);

        /// <member name="M:Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Performs XML XSL transformation.
        /// </summary>
        /// <param name="xsl">XML style sheet.</param>
        /// <param name="xml">XML data.</param>
        /// <returns>Transformed XML string.</returns>
        /// <example>
        /// <code>
        /// <para>This example code will convert xml to a new xml structure using XmlTransform alias.</para>
        /// <![CDATA[
        /// string xsl = @"<xsl:stylesheet version=""1.0"" xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"">
        /// <xsl:output method=""xml"" omit-xml-declaration=""yes"" />
        /// <xsl:template match=""/"">
        /// <xsl:for-each select=""pastery/cake"" >
        /// <price><xsl:value-of select=""@price""/></price>
        /// </xsl:for-each>
        /// </xsl:template>
        /// </xsl:stylesheet>";
        /// string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
        /// <pastery>
        /// <cake price=""1.62"" />
        /// </pastery>";
        /// var priceTag = XmlTransform(xsl, xml);
        /// ]]>
        /// </code>
        /// <para>Result:</para>
        /// <code>
        /// <![CDATA[<price>1.62</price>]]>
        /// </code>
        /// </example>
        /// </member>
        public static string XmlTransform(string xsl, string xml)
            => global::Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Context, xsl, xml);

        /// <member name="M:Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Cake.Core.ICakeContext,System.String,System.String,Cake.Common.Xml.XmlTransformationSettings)">
        /// <summary>
        /// Performs XML XSL transformation.
        /// </summary>
        /// <param name="xsl">XML style sheet.</param>
        /// <param name="xml">XML data.</param>
        /// <param name="settings">Optional settings for result file xml writer.</param>
        /// <returns>Transformed XML string.</returns>
        /// <example>
        /// <code>
        /// <para>This example code will convert specific part of xml to plaintext using XmlTransform alias.</para>
        /// <![CDATA[string xsl = @"<xsl:stylesheet version=""1.0"" xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"">
        /// <xsl:output method=""text"" omit-xml-declaration=""yes"" indent=""no""/>
        /// <xsl:strip-space elements=""*""/>
        /// <xsl:template match=""pastery/cake""><xsl:value-of select=""@price""/></xsl:template>
        /// </xsl:stylesheet>";
        /// string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
        /// <pastery>
        /// <cake price=""1.62"" />
        /// </pastery>";
        /// var text = XmlTransform(xsl, xml, new XmlTransformationSettings {
        /// ConformanceLevel = System.Xml.ConformanceLevel.Fragment, Encoding = Encoding.ASCII });
        /// ]]>
        /// </code>
        /// </example>
        /// </member>
        public static string XmlTransform(string xsl, string xml, global::Cake.Common.Xml.XmlTransformationSettings settings)
            => global::Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Context, xsl, xml, settings);

        /// <member name="M:Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath)">
        /// <summary>
        /// Performs XML XSL transformation.
        /// </summary>
        /// <param name="xslPath">Path to xml style sheet.</param>
        /// <param name="xmlPath">Path xml data.</param>
        /// <param name="resultPath">Transformation result path, will overwrite if exists.</param>
        /// <example>
        /// <code>
        /// <para>This example code will convert the Cake nuspec into html using the XmlTransform alias.</para>
        /// <para>XML stylesheet:</para>
        /// <![CDATA[
        /// <?xml version="1.0" ?>
        /// <xsl:stylesheet
        /// version="1.0"
        /// xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        /// xmlns:p="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd"
        /// exclude-result-prefixes="p"
        /// >
        /// <xsl:output method="xml" indent="yes" omit-xml-declaration="yes" />
        /// <xsl:template match="/">
        /// <html lang="en" class="static">
        /// <head>
        /// <title>
        /// <xsl:for-each select="package/p:metadata">
        /// <xsl:value-of select="p:id"/>
        /// </xsl:for-each>
        /// </title>
        /// </head>
        /// <body>
        /// <xsl:for-each select="package/p:metadata">
        /// <h1>
        /// <xsl:value-of select="p:id"/>
        /// </h1>
        /// <h2>Description</h2>
        /// <i><xsl:value-of select="p:description"/></i>
        /// </xsl:for-each>
        /// <h3>Files</h3>
        /// <ul>
        /// <xsl:for-each select="package/files/file" >
        /// <li><xsl:value-of select="@src"/></li>
        /// </xsl:for-each>
        /// </ul>
        /// </body>
        /// </html>
        /// </xsl:template>
        /// </xsl:stylesheet>
        /// ]]>
        /// </code>
        /// <para>XmlTransform usage:</para>
        /// <code>
        /// XmlTransform("./nuspec.xsl", "./nuspec/Cake.nuspec", "./Cake.htm");
        /// </code>
        /// </example>
        /// </member>
        public static void XmlTransform(global::Cake.Core.IO.FilePath xslPath, global::Cake.Core.IO.FilePath xmlPath, global::Cake.Core.IO.FilePath resultPath)
            => global::Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Context, xslPath, xmlPath, resultPath);

        /// <member name="M:Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Cake.Core.ICakeContext,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Core.IO.FilePath,Cake.Common.Xml.XmlTransformationSettings)">
        /// <summary>
        /// Performs XML XSL transformation.
        /// </summary>
        /// <param name="xslPath">Path to xml style sheet.</param>
        /// <param name="xmlPath">Path xml data.</param>
        /// <param name="resultPath">Transformation result path.</param>
        /// <param name="settings">Optional settings for result file xml writer.</param>
        /// <example>
        /// <code>
        /// <para>This example code will convert the Cake nuspec into html using the XmlTransform alias,
        /// specifying that result should be indented and using Unicode encoding.</para>
        /// <para>XML stylesheet:</para>
        /// <![CDATA[
        /// <?xml version="1.0" ?>
        /// <xsl:stylesheet
        /// version="1.0"
        /// xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        /// xmlns:p="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd"
        /// exclude-result-prefixes="p"
        /// >
        /// <xsl:output method="xml" indent="yes" omit-xml-declaration="yes" />
        /// <xsl:template match="/">
        /// <html lang="en" class="static">
        /// <head>
        /// <title>
        /// <xsl:for-each select="package/p:metadata">
        /// <xsl:value-of select="p:id"/>
        /// </xsl:for-each>
        /// </title>
        /// </head>
        /// <body>
        /// <xsl:for-each select="package/p:metadata">
        /// <h1>
        /// <xsl:value-of select="p:id"/>
        /// </h1>
        /// <h2>Description</h2>
        /// <i><xsl:value-of select="p:description"/></i>
        /// </xsl:for-each>
        /// <h3>Files</h3>
        /// <ul>
        /// <xsl:for-each select="package/files/file" >
        /// <li><xsl:value-of select="@src"/></li>
        /// </xsl:for-each>
        /// </ul>
        /// </body>
        /// </html>
        /// </xsl:template>
        /// </xsl:stylesheet>
        /// ]]>
        /// </code>
        /// <para>XmlTransform usage:</para>
        /// <code>
        /// XmlTransform("./nuspec.xsl", "./nuspec/Cake.nuspec", "./Cake.htm",
        /// new XmlTransformationSettings { Indent = true, Encoding = Encoding.Unicode});
        /// </code>
        /// </example>
        /// </member>
        public static void XmlTransform(global::Cake.Core.IO.FilePath xslPath, global::Cake.Core.IO.FilePath xmlPath, global::Cake.Core.IO.FilePath resultPath, global::Cake.Common.Xml.XmlTransformationSettings settings)
            => global::Cake.Common.Xml.XmlTransformationAlias.XmlTransform(Context, xslPath, xmlPath, resultPath, settings);

    }

    public static partial class Cake_Docker
    {
        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXBake(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Build from a file using default settings.
        /// </summary>
        /// <param name="target">Targets</param>
        /// </member>
        public static void DockerBuildXBake(global::System.Collections.Generic.IEnumerable<string>? target = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXBake(Context, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXBake(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXBakeSettings,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Build from a file given <paramref name="settings" />.
        /// </summary>
        /// <param name="target">Targets</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerBuildXBake(global::Cake.Docker.DockerBuildXBakeSettings? settings, global::System.Collections.Generic.IEnumerable<string>? target = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXBake(Context, settings, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXBuild(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Start a build using default settings.
        /// </summary>
        /// <param name="target">Targets</param>
        /// </member>
        public static void DockerBuildXBuild(string target)
            => global::Cake.Docker.DockerAliases.DockerBuildXBuild(Context, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXBuild(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXBuildSettings,System.String)">
        /// <summary>
        /// Start a build given <paramref name="settings" />.
        /// </summary>
        /// <param name="target">Targets</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerBuildXBuild(global::Cake.Docker.DockerBuildXBuildSettings? settings, string target)
            => global::Cake.Docker.DockerAliases.DockerBuildXBuild(Context, settings, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXCreate(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Create a new builder instance using default settings.
        /// </summary>
        /// <param name="target">Targets</param>
        /// </member>
        public static void DockerBuildXCreate(string? target = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXCreate(Context, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXCreate(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXCreateSettings,System.String)">
        /// <summary>
        /// Create a new builder instance given <paramref name="settings" />.
        /// </summary>
        /// <param name="target">Targets</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerBuildXCreate(global::Cake.Docker.DockerBuildXCreateSettings? settings, string? target = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXCreate(Context, settings, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXDu(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXDuSettings)">
        /// <summary>
        /// Disk usage given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXDu(global::Cake.Docker.DockerBuildXDuSettings? settings = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXDu(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXImageToolsCreate(Cake.Core.ICakeContext,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Create a new image based on source images using default settings.
        /// </summary>
        /// <param name="target">Targets</param>
        /// </member>
        public static void DockerBuildXImageToolsCreate(global::System.Collections.Generic.IEnumerable<string>? target = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXImageToolsCreate(Context, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXImageToolsCreate(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXImageToolsCreateSettings,System.Collections.Generic.IEnumerable{System.String})">
        /// <summary>
        /// Create a new image based on source images given <paramref name="settings" />.
        /// </summary>
        /// <param name="target">Targets</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerBuildXImageToolsCreate(global::Cake.Docker.DockerBuildXImageToolsCreateSettings? settings, global::System.Collections.Generic.IEnumerable<string>? target = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXImageToolsCreate(Context, settings, target);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXImageToolsInspect(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Show details of image in the registry using default settings..
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXImageToolsInspect(string name)
            => global::Cake.Docker.DockerAliases.DockerBuildXImageToolsInspect(Context, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXImageToolsInspect(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXImageToolsInspectSettings,System.String)">
        /// <summary>
        /// Show details of image in the registry given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="name">Name</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXImageToolsInspect(global::Cake.Docker.DockerBuildXImageToolsInspectSettings? settings, string name)
            => global::Cake.Docker.DockerAliases.DockerBuildXImageToolsInspect(Context, settings, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXInspect(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Inspect current builder instance using default settings..
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXInspect(string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXInspect(Context, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXInspect(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXInspectSettings,System.String)">
        /// <summary>
        /// Inspect current builder instance given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="name">Name</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXInspect(global::Cake.Docker.DockerBuildXInspectSettings? settings, string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXInspect(Context, settings, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXInstall(Cake.Core.ICakeContext)">
        /// <summary>
        /// Install buildx as a ‘docker builder’ alias.
        /// </summary>
        /// </member>
        public static void DockerBuildXInstall()
            => global::Cake.Docker.DockerAliases.DockerBuildXInstall(Context);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXLs(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXLsSettings)">
        /// <summary>
        /// List images given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXLs(global::Cake.Docker.DockerBuildXLsSettings? settings = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXLs(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXPrune(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXPruneSettings)">
        /// <summary>
        /// Remove build cache.
        /// </summary>
        /// /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerBuildXPrune(global::Cake.Docker.DockerBuildXPruneSettings? settings = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXPrune(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXRm(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Remove a builder instance using default settings.
        /// </summary>
        /// <param name="name"></param>
        /// </member>
        public static void DockerBuildXRm(string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXRm(Context, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXRm(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXRmSettings,System.String)">
        /// <summary>
        /// Remove a builder instance given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="name"></param>
        /// </member>
        public static void DockerBuildXRm(global::Cake.Docker.DockerBuildXRmSettings? settings = null, string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXRm(Context, settings, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXStop(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Stop builder instance using default settings.
        /// </summary>
        /// <param name="name">The name.</param>
        /// </member>
        public static void DockerBuildXStop(string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXStop(Context, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXStop(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXStopSettings,System.String)">
        /// <summary>
        /// Stop builder instance given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="name">The name.</param>
        /// </member>
        public static void DockerBuildXStop(global::Cake.Docker.DockerBuildXStopSettings? settings = null, string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXStop(Context, settings, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXUninstall(Cake.Core.ICakeContext)">
        /// <summary>
        /// Uninstall the ‘docker builder’ alias.
        /// </summary>
        /// </member>
        public static void DockerBuildXUninstall()
            => global::Cake.Docker.DockerAliases.DockerBuildXUninstall(Context);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXUse(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Set the current builder instance using default settings.
        /// </summary>
        /// <param name="name">The name.</param>
        /// </member>
        public static void DockerBuildXUse(string name)
            => global::Cake.Docker.DockerAliases.DockerBuildXUse(Context, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXUse(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXUseSettings,System.String)">
        /// <summary>
        /// Set the current builder instance given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="name">The name.</param>
        /// </member>
        public static void DockerBuildXUse(global::Cake.Docker.DockerBuildXUseSettings? settings = null, string? name = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXUse(Context, settings, name);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuildXVersion(Cake.Core.ICakeContext,Cake.Docker.DockerBuildXVersionSettings)">
        /// <summary>
        /// List images given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerBuildXVersion(global::Cake.Docker.DockerBuildXVersionSettings? settings = null)
            => global::Cake.Docker.DockerAliases.DockerBuildXVersion(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeBuild(Cake.Core.ICakeContext,Cake.Docker.DockerComposeBuildSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose build given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="composeSettings">Compose settings</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerComposeBuild(global::Cake.Docker.DockerComposeBuildSettings settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeBuild(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeCp(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Runs docker compose cp with default settings.
        /// </summary>
        /// <param name="source">Source path.</param>
        /// <param name="destination">Destination path.</param>
        /// </member>
        public static void DockerComposeCp(string source, string destination)
            => global::Cake.Docker.DockerAliases.DockerComposeCp(Context, source, destination);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeCp(Cake.Core.ICakeContext,System.String,System.String,Cake.Docker.DockerComposeCpSettings,Cake.Docker.DockerComposeSettings)">
        /// <summary>
        /// Copy files from/to container given <paramref name="settings" />.
        /// </summary>
        /// <param name="source">Source path.</param>
        /// <param name="destination">Destination path.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeCp(string source, string destination, global::Cake.Docker.DockerComposeCpSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null)
            => global::Cake.Docker.DockerAliases.DockerComposeCp(Context, source, destination, settings, composeSettings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeCreate(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose create with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeCreate(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeCreate(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeCreate(Cake.Core.ICakeContext,Cake.Docker.DockerComposeCreateSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose create given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeCreate(global::Cake.Docker.DockerComposeCreateSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeCreate(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeDown(Cake.Core.ICakeContext)">
        /// <summary>
        /// Runs docker-compose down with default settings.
        /// </summary>
        /// </member>
        public static void DockerComposeDown()
            => global::Cake.Docker.DockerAliases.DockerComposeDown(Context);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeDown(Cake.Core.ICakeContext,Cake.Docker.DockerComposeDownSettings,Cake.Docker.DockerComposeSettings)">
        /// <summary>
        /// Runs docker-compose down given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeDown(global::Cake.Docker.DockerComposeDownSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null)
            => global::Cake.Docker.DockerAliases.DockerComposeDown(Context, settings, composeSettings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeExec(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Runs docker-compose exec with default settings.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="command">The command.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerComposeExec(string service, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerComposeExec(Context, service, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeExec(Cake.Core.ICakeContext,Cake.Docker.DockerComposeExecSettings,System.String,System.String,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose exec given <paramref name="settings" />.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="command">The command.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeExec(global::Cake.Docker.DockerComposeExecSettings? settings, string service, string command, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerComposeExec(Context, settings, service, command, composeSettings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeKill(Cake.Core.ICakeContext)">
        /// <summary>
        /// Runs docker-compose kill with default settings.
        /// </summary>
        /// </member>
        public static void DockerComposeKill()
            => global::Cake.Docker.DockerAliases.DockerComposeKill(Context);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeKill(Cake.Core.ICakeContext,Cake.Docker.DockerComposeKillSettings,Cake.Docker.DockerComposeSettings)">
        /// <summary>
        /// Runs docker-compose kill given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeKill(global::Cake.Docker.DockerComposeKillSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null)
            => global::Cake.Docker.DockerAliases.DockerComposeKill(Context, settings, composeSettings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeLogs(Cake.Core.ICakeContext)">
        /// <summary>
        /// Runs docker-compose logs with default settings.
        /// </summary>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerComposeLogs()
            => global::Cake.Docker.DockerAliases.DockerComposeLogs(Context);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeLogs(Cake.Core.ICakeContext,Cake.Docker.DockerComposeLogsSettings,Cake.Docker.DockerComposeSettings)">
        /// <summary>
        /// Runs docker-compose logs given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerComposeLogs(global::Cake.Docker.DockerComposeLogsSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null)
            => global::Cake.Docker.DockerAliases.DockerComposeLogs(Context, settings, composeSettings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePause(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose pause with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposePause(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePause(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePause(Cake.Core.ICakeContext,Cake.Docker.DockerComposeSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose pause.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposePause(global::Cake.Docker.DockerComposeSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePause(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePort(Cake.Core.ICakeContext,System.String,System.Int32)">
        /// <summary>
        /// Runs docker-compose port with default settings.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="port">The private port of the container.</param>
        /// </member>
        public static void DockerComposePort(string service, int port)
            => global::Cake.Docker.DockerAliases.DockerComposePort(Context, service, port);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePort(Cake.Core.ICakeContext,Cake.Docker.DockerComposePortSettings,System.String,System.Int32,Cake.Docker.DockerComposeSettings)">
        /// <summary>
        /// Runs docker-compose port.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="service">The service.</param>
        /// <param name="port">The private port of the container.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerComposePort(global::Cake.Docker.DockerComposePortSettings? settings, string service, int port, global::Cake.Docker.DockerComposeSettings? composeSettings = null)
            => global::Cake.Docker.DockerAliases.DockerComposePort(Context, settings, service, port, composeSettings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePs(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose ps with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposePs(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePs(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePs(Cake.Core.ICakeContext,Cake.Docker.DockerComposePsSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose ps.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerComposePs(global::Cake.Docker.DockerComposePsSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePs(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePull(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose pull with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposePull(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePull(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePull(Cake.Core.ICakeContext,Cake.Docker.DockerComposePullSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose pull given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposePull(global::Cake.Docker.DockerComposePullSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePull(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePush(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose push with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposePush(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePush(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposePush(Cake.Core.ICakeContext,Cake.Docker.DockerComposePushSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose push given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposePush(global::Cake.Docker.DockerComposePushSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposePush(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRestart(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose restart with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeRestart(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeRestart(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRestart(Cake.Core.ICakeContext,Cake.Docker.DockerComposeRestartSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose restart given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeRestart(global::Cake.Docker.DockerComposeRestartSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeRestart(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRm(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose rm with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeRm(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeRm(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRm(Cake.Core.ICakeContext,Cake.Docker.DockerComposeRmSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose rm given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeRm(global::Cake.Docker.DockerComposeRmSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeRm(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRun(Cake.Core.ICakeContext,System.String,System.String[])">
        /// <summary>
        /// Runs docker-compose run with default settings.
        /// </summary>
        /// <param name="service">The path.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerComposeRun(string service, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerComposeRun(Context, service, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRun(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Runs docker-compose run with default settings.
        /// </summary>
        /// <param name="service">The path.</param>
        /// <param name="command">The command.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerComposeRun(string service, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerComposeRun(Context, service, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRun(Cake.Core.ICakeContext,Cake.Docker.DockerComposeRunSettings,System.String,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose run given <paramref name="settings" />.
        /// </summary>
        /// <param name="service">The path.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeRun(global::Cake.Docker.DockerComposeRunSettings settings, string service, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerComposeRun(Context, settings, service, composeSettings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeRun(Cake.Core.ICakeContext,Cake.Docker.DockerComposeRunSettings,System.String,System.String,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose run given <paramref name="settings" />.
        /// </summary>
        /// <param name="service">The path.</param>
        /// <param name="command">The command.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeRun(global::Cake.Docker.DockerComposeRunSettings? settings, string service, string? command, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerComposeRun(Context, settings, service, command, composeSettings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeScale(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose scale with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeScale(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeScale(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeScale(Cake.Core.ICakeContext,Cake.Docker.DockerComposeScaleSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose scale.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="services">The list of services.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeScale(global::Cake.Docker.DockerComposeScaleSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeScale(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeStart(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose start with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeStart(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeStart(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeStart(Cake.Core.ICakeContext,Cake.Docker.DockerComposeSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose start.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="services">The list of services.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeStart(global::Cake.Docker.DockerComposeSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeStart(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeStop(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose stop with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeStop(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeStop(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeStop(Cake.Core.ICakeContext,Cake.Docker.DockerComposeBuildSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose stop given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeStop(global::Cake.Docker.DockerComposeBuildSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeStop(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeUnpause(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose unpause with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeUnpause(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeUnpause(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeUnpause(Cake.Core.ICakeContext,Cake.Docker.DockerComposeSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose unpause.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="services">The list of services.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeUnpause(global::Cake.Docker.DockerComposeSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeUnpause(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeUp(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Runs docker-compose up with default settings.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// </member>
        public static void DockerComposeUp(params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeUp(Context, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerComposeUp(Cake.Core.ICakeContext,Cake.Docker.DockerComposeUpSettings,Cake.Docker.DockerComposeSettings,System.String[])">
        /// <summary>
        /// Runs docker-compose up given <paramref name="settings" />.
        /// </summary>
        /// <param name="services">The list of services.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="composeSettings">The compose settings.</param>
        /// </member>
        public static void DockerComposeUp(global::Cake.Docker.DockerComposeUpSettings? settings, global::Cake.Docker.DockerComposeSettings? composeSettings = null, params string[] services)
            => global::Cake.Docker.DockerAliases.DockerComposeUp(Context, settings, composeSettings, services);

        /// <member name="M:Cake.Docker.DockerAliases.DockerCp(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Copy files from/to using default settings.
        /// </summary>
        /// <param name="from">Source path.</param>
        /// <param name="to">Destination path.</param>
        /// </member>
        public static void DockerCp(string from, string to)
            => global::Cake.Docker.DockerAliases.DockerCp(Context, from, to);

        /// <member name="M:Cake.Docker.DockerAliases.DockerCp(Cake.Core.ICakeContext,System.String,System.String,Cake.Docker.DockerContainerCpSettings)">
        /// <summary>
        /// Copy files from/to container given <paramref name="settings" />.
        /// </summary>
        /// <param name="from">Source path.</param>
        /// <param name="to">Destination path.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerCp(string from, string to, global::Cake.Docker.DockerContainerCpSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerCp(Context, from, to, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerCreate(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Creates a new container using default settings.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="command">The command.</param>
        /// <returns>container ID or null</returns>
        /// </member>
        public static string? DockerCreate(string image, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerCreate(Context, image, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerCreate(Cake.Core.ICakeContext,Cake.Docker.DockerContainerCreateSettings,System.String,System.String,System.String[])">
        /// <summary>
        /// Creates a new container given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="image">The image.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="command">The command.</param>
        /// <returns>container ID or null</returns>
        /// </member>
        public static string? DockerCreate(global::Cake.Docker.DockerContainerCreateSettings? settings, string image, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerCreate(Context, settings, image, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerExec(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Execs a command using default settings.
        /// </summary>
        /// <param name="container">The container</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerExec(string container, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerExec(Context, container, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerExec(Cake.Core.ICakeContext,Cake.Docker.DockerContainerExecSettings,System.String,System.String,System.String[])">
        /// <summary>
        /// Execs a command using given <paramref name="settings" />.
        /// </summary>
        /// <param name="container">The container</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerExec(global::Cake.Docker.DockerContainerExecSettings? settings, string container, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerExec(Context, settings, container, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLogs(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Logs <paramref name="container" /> using default settings.
        /// </summary>
        /// <param name="container">The list of containers.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerLogs(string container)
            => global::Cake.Docker.DockerAliases.DockerLogs(Context, container);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLogs(Cake.Core.ICakeContext,Cake.Docker.DockerContainerLogsSettings,System.String)">
        /// <summary>
        /// Logs <paramref name="container" /> using the given <paramref name="settings" />.
        /// </summary>
        /// <param name="container">The list of containers.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerLogs(global::Cake.Docker.DockerContainerLogsSettings? settings, string container)
            => global::Cake.Docker.DockerAliases.DockerLogs(Context, settings, container);

        /// <member name="M:Cake.Docker.DockerAliases.DockerContainerLs(Cake.Core.ICakeContext,Cake.Docker.DockerContainerLsSettings)">
        /// <summary>
        /// List containers given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerContainerLs(global::Cake.Docker.DockerContainerLsSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerContainerLs(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerPs(Cake.Core.ICakeContext,Cake.Docker.DockerContainerPsSettings)">
        /// <summary>
        /// List containers given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static string DockerPs(global::Cake.Docker.DockerContainerPsSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerPs(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRm(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Removes an array of <paramref name="containers" /> using default settings.
        /// </summary>
        /// <param name="containers">The list of containers.</param>
        /// </member>
        public static void DockerRm(params string[] containers)
            => global::Cake.Docker.DockerAliases.DockerRm(Context, containers);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRm(Cake.Core.ICakeContext,Cake.Docker.DockerContainerRmSettings,System.String[])">
        /// <summary>
        /// Removes an array of <paramref name="containers" /> using the given <param name="settings" />.
        /// </summary>
        /// <param name="containers">The list of containers.</param>
        /// </member>
        public static void DockerRm(global::Cake.Docker.DockerContainerRmSettings? settings, params string[] containers)
            => global::Cake.Docker.DockerAliases.DockerRm(Context, settings, containers);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRun(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Creates a new container using default settings.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="command">The command.</param>
        /// <returns>Container ID or null</returns>
        /// <remarks>Return value is first line from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static string? DockerRun(string image, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerRun(Context, image, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRun(Cake.Core.ICakeContext,Cake.Docker.DockerContainerRunSettings,System.String,System.String,System.String[])">
        /// <summary>
        /// Creates a new container given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="image">The image.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="command">The command.</param>
        /// <returns>Container ID or null</returns>
        /// <remarks>Return value is first line from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static string? DockerRun(global::Cake.Docker.DockerContainerRunSettings? settings, string image, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerRun(Context, settings, image, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRunWithoutResult(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Creates a new container using default settings. and doesn't return the output like
        /// <see cref="M:Cake.Docker.DockerAliases.DockerRun(Cake.Core.ICakeContext,System.String,System.String,System.String[])" /> does.
        /// This way one can capture stdout.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="command">The command.</param>
        /// </member>
        public static void DockerRunWithoutResult(string image, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerRunWithoutResult(Context, image, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRunWithoutResult(Cake.Core.ICakeContext,Cake.Docker.DockerContainerRunSettings,System.String,System.String,System.String[])">
        /// <summary>
        /// Creates a new container given <paramref name="settings" /> and doesn't return the output like
        /// <see cref="M:Cake.Docker.DockerAliases.DockerRun(Cake.Core.ICakeContext,Cake.Docker.DockerContainerRunSettings,System.String,System.String,System.String[])" /> does.
        /// This way one can capture stdout.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="image">The image.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="command">The command.</param>
        /// </member>
        public static void DockerRunWithoutResult(global::Cake.Docker.DockerContainerRunSettings? settings, string image, string command, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerRunWithoutResult(Context, settings, image, command, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerStart(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Starts an array of <paramref name="containers" /> using default settings.
        /// </summary>
        /// <param name="containers">The list of containers.</param>
        /// </member>
        public static void DockerStart(params string[] containers)
            => global::Cake.Docker.DockerAliases.DockerStart(Context, containers);

        /// <member name="M:Cake.Docker.DockerAliases.DockerStart(Cake.Core.ICakeContext,Cake.Docker.DockerContainerStartSettings,System.String[])">
        /// <summary>
        /// Starts an array of <paramref name="containers" /> using the give <paramref name="settings" />.
        /// </summary>
        /// <param name="containers">The list of containers.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerStart(global::Cake.Docker.DockerContainerStartSettings? settings, params string[] containers)
            => global::Cake.Docker.DockerAliases.DockerStart(Context, settings, containers);

        /// <member name="M:Cake.Docker.DockerAliases.DockerStop(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Stops an array of <paramref name="containers" /> using default settings.
        /// </summary>
        /// <param name="containers">The list of containers.</param>
        /// </member>
        public static void DockerStop(params string[] containers)
            => global::Cake.Docker.DockerAliases.DockerStop(Context, containers);

        /// <member name="M:Cake.Docker.DockerAliases.DockerStop(Cake.Core.ICakeContext,Cake.Docker.DockerContainerStopSettings,System.String[])">
        /// <summary>
        /// Stops an array of <paramref name="containers" /> using the give <paramref name="settings" />.
        /// </summary>
        /// <param name="containers">The list of containers.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerStop(global::Cake.Docker.DockerContainerStopSettings? settings, params string[] containers)
            => global::Cake.Docker.DockerAliases.DockerStop(Context, settings, containers);

        /// <member name="M:Cake.Docker.DockerAliases.DockerCustomCommand(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Run a custom docker command
        /// </summary>
        /// <param name="command">The custom command.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerCustomCommand(string command)
            => global::Cake.Docker.DockerAliases.DockerCustomCommand(Context, command);

        /// <member name="M:Cake.Docker.DockerAliases.DockerCustomCommand(Cake.Core.ICakeContext,Cake.Docker.DockerCustomCommandSettings,System.String)">
        /// <summary>
        /// Run a custom docker command
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="command">The custom command.</param>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerCustomCommand(global::Cake.Docker.DockerCustomCommandSettings settings, string command)
            => global::Cake.Docker.DockerAliases.DockerCustomCommand(Context, settings, command);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuild(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Builds an image using default settings.
        /// </summary>
        /// <param name="path">The path.</param>
        /// </member>
        public static void DockerBuild(string path)
            => global::Cake.Docker.DockerAliases.DockerBuild(Context, path);

        /// <member name="M:Cake.Docker.DockerAliases.DockerBuild(Cake.Core.ICakeContext,Cake.Docker.DockerImageBuildSettings,System.String)">
        /// <summary>
        /// Builds an image given <paramref name="settings" />.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerBuild(global::Cake.Docker.DockerImageBuildSettings? settings, string path)
            => global::Cake.Docker.DockerAliases.DockerBuild(Context, settings, path);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLoad(Cake.Core.ICakeContext,Cake.Docker.DockerImageLoadSettings)">
        /// <summary>
        /// Load an image from a tar archive or STDIN.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerLoad(global::Cake.Docker.DockerImageLoadSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerLoad(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerImageLs(Cake.Core.ICakeContext,Cake.Docker.DockerImageLsSettings)">
        /// <summary>
        /// List images given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerImageLs(global::Cake.Docker.DockerImageLsSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerImageLs(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerImagePrune(Cake.Core.ICakeContext)">
        /// <summary>
        /// Remove unused images.
        /// </summary>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerImagePrune()
            => global::Cake.Docker.DockerAliases.DockerImagePrune(Context);

        /// <member name="M:Cake.Docker.DockerAliases.DockerImagePrune(Cake.Core.ICakeContext,Cake.Docker.DockerImagePruneSettings)">
        /// <summary>
        /// Remove unused images given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerImagePrune(global::Cake.Docker.DockerImagePruneSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerImagePrune(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerPull(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Pull an image or a repository from the registry.
        /// </summary>
        /// <param name="imageReference">The image reference.</param>
        /// </member>
        public static void DockerPull(string imageReference)
            => global::Cake.Docker.DockerAliases.DockerPull(Context, imageReference);

        /// <member name="M:Cake.Docker.DockerAliases.DockerPull(Cake.Core.ICakeContext,Cake.Docker.DockerImagePullSettings,System.String)">
        /// <summary>
        /// Pull an image or a repository from the registry with given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="imageReference">The image reference.</param>
        /// </member>
        public static void DockerPull(global::Cake.Docker.DockerImagePullSettings? settings, string imageReference)
            => global::Cake.Docker.DockerAliases.DockerPull(Context, settings, imageReference);

        /// <member name="M:Cake.Docker.DockerAliases.DockerPush(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Push an image or a repository to the registry.
        /// </summary>
        /// <param name="imageReference">The image reference.</param>
        /// </member>
        public static void DockerPush(string imageReference)
            => global::Cake.Docker.DockerAliases.DockerPush(Context, imageReference);

        /// <member name="M:Cake.Docker.DockerAliases.DockerPush(Cake.Core.ICakeContext,Cake.Docker.DockerImagePushSettings,System.String)">
        /// <summary>
        /// Push an image or a repository to the registry with given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="imageReference">The image reference.</param>
        /// </member>
        public static void DockerPush(global::Cake.Docker.DockerImagePushSettings? settings, string imageReference)
            => global::Cake.Docker.DockerAliases.DockerPush(Context, settings, imageReference);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRmi(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Removes an array of <paramref name="images" /> using default settings.
        /// </summary>
        /// <param name="images">The list of images.</param>
        /// </member>
        public static void DockerRmi(params string[] images)
            => global::Cake.Docker.DockerAliases.DockerRmi(Context, images);

        /// <member name="M:Cake.Docker.DockerAliases.DockerRemove(Cake.Core.ICakeContext,Cake.Docker.DockerImageRemoveSettings,System.String[])">
        /// <summary>
        /// Removes an array of <paramref name="images" /> using the give <paramref name="settings" />.
        /// </summary>
        /// <param name="images">The list of images.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerRemove(global::Cake.Docker.DockerImageRemoveSettings? settings, params string[] images)
            => global::Cake.Docker.DockerAliases.DockerRemove(Context, settings, images);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSave(Cake.Core.ICakeContext,Cake.Docker.DockerImageSaveSettings,System.String[])">
        /// <summary>
        /// Save one or more images to a tar archive (streamed to STDOUT by default).
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="images">The list of images.</param>
        /// </member>
        public static void DockerSave(global::Cake.Docker.DockerImageSaveSettings? settings, params string[] images)
            => global::Cake.Docker.DockerAliases.DockerSave(Context, settings, images);

        /// <member name="M:Cake.Docker.DockerAliases.DockerTag(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Tag an image into a repository.
        /// </summary>
        /// <param name="imageReference">The image reference.</param>
        /// <param name="registryReference">The registry reference.</param>
        /// </member>
        public static void DockerTag(string imageReference, string registryReference)
            => global::Cake.Docker.DockerAliases.DockerTag(Context, imageReference, registryReference);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestAnnotate(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Add additional information to a local image manifest
        /// </summary>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// <param name="manifest">MANIFEST</param>
        /// </member>
        public static void DockerManifestAnnotate(string manifestList, string manifest)
            => global::Cake.Docker.DockerAliases.DockerManifestAnnotate(Context, manifestList, manifest);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestAnnotate(Cake.Core.ICakeContext,Cake.Docker.DockerManifestAnnotateSettings,System.String,System.String)">
        /// <summary>
        /// Add additional information to a local image manifest
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// <param name="manifest">MANIFEST</param>
        /// </member>
        public static void DockerManifestAnnotate(global::Cake.Docker.DockerManifestAnnotateSettings? settings, string manifestList, string manifest)
            => global::Cake.Docker.DockerAliases.DockerManifestAnnotate(Context, settings, manifestList, manifest);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestCreate(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Create a local manifest list for annotating and pushing to a registry
        /// </summary>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// <param name="manifest">MANIFEST</param>
        /// <param name="manifests">[MANIFEST...]</param>
        /// </member>
        public static void DockerManifestCreate(string manifestList, string manifest, params string[] manifests)
            => global::Cake.Docker.DockerAliases.DockerManifestCreate(Context, manifestList, manifest, manifests);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestCreate(Cake.Core.ICakeContext,Cake.Docker.DockerManifestCreateSettings,System.String,System.String,System.String[])">
        /// <summary>
        /// Create a local manifest list for annotating and pushing to a registry
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// <param name="manifest">MANIFEST</param>
        /// /// <param name="manifests">[MANIFEST...]</param>
        /// </member>
        public static void DockerManifestCreate(global::Cake.Docker.DockerManifestCreateSettings? settings, string manifestList, string manifest, params string[] manifests)
            => global::Cake.Docker.DockerAliases.DockerManifestCreate(Context, settings, manifestList, manifest, manifests);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestInspect(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Display an image manifest, or manifest list
        /// </summary>
        /// <param name="manifest">MANIFEST</param>
        /// </member>
        public static void DockerManifestInspect(string manifest)
            => global::Cake.Docker.DockerAliases.DockerManifestInspect(Context, manifest);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestInspect(Cake.Core.ICakeContext,System.String,System.String)">
        /// <summary>
        /// Display an image manifest, or manifest list
        /// </summary>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// <param name="manifest">MANIFEST</param>
        /// </member>
        public static void DockerManifestInspect(string manifestList, string manifest)
            => global::Cake.Docker.DockerAliases.DockerManifestInspect(Context, manifestList, manifest);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestInspect(Cake.Core.ICakeContext,Cake.Docker.DockerManifestInspectSettings,System.String,System.String)">
        /// <summary>
        /// Display an image manifest, or manifest list
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// <param name="manifest">MANIFEST</param>
        /// </member>
        public static void DockerManifestInspect(global::Cake.Docker.DockerManifestInspectSettings? settings, string? manifestList, string manifest)
            => global::Cake.Docker.DockerAliases.DockerManifestInspect(Context, settings, manifestList, manifest);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestPush(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Push a manifest list to a repository
        /// </summary>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// </member>
        public static void DockerManifestPush(string manifestList)
            => global::Cake.Docker.DockerAliases.DockerManifestPush(Context, manifestList);

        /// <member name="M:Cake.Docker.DockerAliases.DockerManifestPush(Cake.Core.ICakeContext,Cake.Docker.DockerManifestPushSettings,System.String)">
        /// <summary>
        /// Push a manifest list to a repository
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="manifestList">MANIFEST_LIST</param>
        /// </member>
        public static void DockerManifestPush(global::Cake.Docker.DockerManifestPushSettings? settings, string manifestList)
            => global::Cake.Docker.DockerAliases.DockerManifestPush(Context, settings, manifestList);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkConnect(Cake.Core.ICakeContext,System.String,System.String,System.String[])">
        /// <summary>
        /// Connects a container to a network using default settings.
        /// </summary>
        /// <param name="network">The network.</param>
        /// <param name="container">The container.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkConnect(string network, string container, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkConnect(Context, network, container, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkConnect(Cake.Core.ICakeContext,Cake.Docker.DockerNetworkConnectSettings,System.String,System.String,System.String[])">
        /// <summary>
        /// Connects a container to a network given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="network">The network.</param>
        /// <param name="container">The container.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkConnect(global::Cake.Docker.DockerNetworkConnectSettings? settings, string network, string container, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkConnect(Context, settings, network, container, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkCreate(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Creates a network using default settings.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkCreate(params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkCreate(Context, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkCreate(Cake.Core.ICakeContext,Cake.Docker.DockerNetworkCreateSettings,System.String[])">
        /// <summary>
        /// Creates a network given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkCreate(global::Cake.Docker.DockerNetworkCreateSettings? settings, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkCreate(Context, settings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkDisconnect(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Disconnects a network using default settings.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkDisconnect(params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkDisconnect(Context, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkDisconnect(Cake.Core.ICakeContext,Cake.Docker.DockerNetworkDisconnectSettings,System.String[])">
        /// <summary>
        /// Disconnects a network given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkDisconnect(global::Cake.Docker.DockerNetworkDisconnectSettings? settings, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkDisconnect(Context, settings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkRemove(Cake.Core.ICakeContext,System.String,System.String[])">
        /// <summary>
        /// Removes a network.
        /// </summary>
        /// <param name="network">The network.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkRemove(string network, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkRemove(Context, network, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerNetworkRemove(Cake.Core.ICakeContext,System.String[],System.String[])">
        /// <summary>
        /// Removes networks.
        /// </summary>
        /// <param name="network">The network.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerNetworkRemove(string[] network, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerNetworkRemove(Context, network, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLogin(Cake.Core.ICakeContext,System.String,System.String,System.String)">
        /// <summary>
        /// Register or log in to a Docker registry.
        /// If no server is specified, the docker engine default is used.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="server">The server.</param>
        /// </member>
        public static void DockerLogin(string username, string password, string? server = null)
            => global::Cake.Docker.DockerAliases.DockerLogin(Context, username, password, server);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLogin(Cake.Core.ICakeContext,Cake.Docker.DockerRegistryLoginSettings,System.String)">
        /// <summary>
        /// Register or log in to a Docker registry.
        /// If no server is specified, the docker engine default is used.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="server">The server.</param>
        /// </member>
        public static void DockerLogin(global::Cake.Docker.DockerRegistryLoginSettings settings, string? server = null)
            => global::Cake.Docker.DockerAliases.DockerLogin(Context, settings, server);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLogout(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Logout from a Docker registry.
        /// If no server is specified, the docker engine default is used.
        /// </summary>
        /// <param name="server">The server.</param>
        /// </member>
        public static void DockerLogout(string? server = null)
            => global::Cake.Docker.DockerAliases.DockerLogout(Context, server);

        /// <member name="M:Cake.Docker.DockerAliases.DockerLogout(Cake.Core.ICakeContext,Cake.Docker.DockerRegistryLogoutSettings,System.String)">
        /// <summary>
        /// Logout from a Docker registry.
        /// If no server is specified, the docker engine default is used.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="server">The server.</param>
        /// </member>
        public static void DockerLogout(global::Cake.Docker.DockerRegistryLogoutSettings? settings, string? server = null)
            => global::Cake.Docker.DockerAliases.DockerLogout(Context, settings, server);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmInit(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Initializes a swarm using default settings.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmInit(params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmInit(Context, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmInit(Cake.Core.ICakeContext,Cake.Docker.DockerSwarmInitSettings,System.String[])">
        /// <summary>
        /// Initializes a swarm given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmInit(global::Cake.Docker.DockerSwarmInitSettings? settings, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmInit(Context, settings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmJoin(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Joins a swarm using default settings.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmJoin(params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmJoin(Context, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmJoin(Cake.Core.ICakeContext,Cake.Docker.DockerSwarmJoinSettings,System.String[])">
        /// <summary>
        /// Joins a swarm given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmJoin(global::Cake.Docker.DockerSwarmJoinSettings? settings, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmJoin(Context, settings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmLeave(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Leaves a swarm using default settings.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmLeave(params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmLeave(Context, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmLeave(Cake.Core.ICakeContext,Cake.Docker.DockerSwarmLeaveSettings,System.String[])">
        /// <summary>
        /// Leaves a swarm given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmLeave(global::Cake.Docker.DockerSwarmLeaveSettings? settings, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmLeave(Context, settings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmUpdate(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Updates a swarm using default settings.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmUpdate(params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmUpdate(Context, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerSwarmUpdate(Cake.Core.ICakeContext,Cake.Docker.DockerSwarmUpdateSettings,System.String[])">
        /// <summary>
        /// Updates a swarm given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="args">The arguments.</param>
        /// </member>
        public static void DockerSwarmUpdate(global::Cake.Docker.DockerSwarmUpdateSettings? settings, params string[] args)
            => global::Cake.Docker.DockerAliases.DockerSwarmUpdate(Context, settings, args);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeCreate(Cake.Core.ICakeContext,System.String)">
        /// <summary>
        /// Runs docker volume create with default settings.
        /// </summary>
        /// <param name="volume">Volume to create.</param>
        /// </member>
        public static void DockerVolumeCreate(string volume)
            => global::Cake.Docker.DockerAliases.DockerVolumeCreate(Context, volume);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeCreate(Cake.Core.ICakeContext,Cake.Docker.DockerVolumeCreateSettings,System.String)">
        /// <summary>
        /// Runs docker volume create given <paramref name="settings" />.
        /// </summary>
        /// <param name="volume">Volume to create.</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerVolumeCreate(global::Cake.Docker.DockerVolumeCreateSettings? settings, string volume)
            => global::Cake.Docker.DockerAliases.DockerVolumeCreate(Context, settings, volume);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeInspect(Cake.Core.ICakeContext,Cake.Docker.DockerVolumeInspectSettings,System.String[])">
        /// <summary>
        /// Display detailed information on one or more volumes given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="volumes">Volumes</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerVolumeInspect(global::Cake.Docker.DockerVolumeInspectSettings? settings, string[] volumes)
            => global::Cake.Docker.DockerAliases.DockerVolumeInspect(Context, settings, volumes);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeInspect(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Display detailed information on one or more volumes.
        /// </summary>
        /// <param name="volumes">Volumes</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerVolumeInspect(string[] volumes)
            => global::Cake.Docker.DockerAliases.DockerVolumeInspect(Context, volumes);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeLs(Cake.Core.ICakeContext,Cake.Docker.DockerVolumeLsSettings)">
        /// <summary>
        /// List volumes given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>Output text.</returns>
        /// <remarks>Return value are the lines from stdout. This method will redirect stdout and it won't be available for capture.</remarks>
        /// </member>
        public static global::System.Collections.Generic.IEnumerable<string> DockerVolumeLs(global::Cake.Docker.DockerVolumeLsSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerVolumeLs(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumePrune(Cake.Core.ICakeContext,Cake.Docker.DockerVolumePruneSettings)">
        /// <summary>
        /// Remove all unused local volumes given <paramref name="settings" />.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerVolumePrune(global::Cake.Docker.DockerVolumePruneSettings? settings)
            => global::Cake.Docker.DockerAliases.DockerVolumePrune(Context, settings);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeRm(Cake.Core.ICakeContext,Cake.Docker.DockerVolumeRmSettings,System.String[])">
        /// <summary>
        /// Remove one or more volumes given <paramref name="settings" />.
        /// </summary>
        /// <param name="volumes">Volumes</param>
        /// <param name="settings">The settings.</param>
        /// </member>
        public static void DockerVolumeRm(global::Cake.Docker.DockerVolumeRmSettings? settings, string[] volumes)
            => global::Cake.Docker.DockerAliases.DockerVolumeRm(Context, settings, volumes);

        /// <member name="M:Cake.Docker.DockerAliases.DockerVolumeRm(Cake.Core.ICakeContext,System.String[])">
        /// <summary>
        /// Remove one or more volumes.
        /// </summary>
        /// <param name="volumes">Volumes</param>
        /// </member>
        public static void DockerVolumeRm(string[] volumes)
            => global::Cake.Docker.DockerAliases.DockerVolumeRm(Context, volumes);

    }

}
