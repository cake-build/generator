//HintName: CakeScriptHost.g.cs

/// <summary>
/// Static proxy methods and properties for IScriptHost.
/// </summary>"
public static partial class Program
{
    /// <summary>
    /// Gets the Cake script host instance from the service provider.
    /// </summary>
    public static IScriptHost ScriptHost => Helper.ScriptHost;

    private static partial class Helper
    {
        private static object _scriptHostLock = new object();
        private static IScriptHost? _scriptHost;

        /// <summary>
        /// Gets the configured script host instance.
        /// </summary>
        public static IScriptHost ScriptHost => _scriptHost ??= GetScriptHost();

        private static IScriptHost GetScriptHost()
        {
            lock(_scriptHostLock)
            {
                _scriptHost = Helper.ServiceProvider.GetRequiredService<IScriptHost>();
            }
            
            PostScriptHost();
            
            return _scriptHost;
        }

        private static void PostScriptHost()
        {
            // Call any static private void no argument methods in current executing assembly in static Program class prefixed with Main_ here
            Main_Initialize();
            Main_Setup();
        }
    }

    /// <member name="M:Cake.Core.Scripting.IScriptHost.Task(System.String)">
    /// <summary>
    /// Registers a new task.
    /// </summary>
    /// <param name="name">The name of the task.</param>
    /// <returns>A <see cref="T:Cake.Core.CakeTaskBuilder" />.</returns>
    /// <example>
    /// <code>
    /// Task("Hello")
    ///     .Does(() =&gt;
    /// {
    ///     Information("Hello World");
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static global::Cake.Core.CakeTaskBuilder Task(string name)
        => ScriptHost.Task(name);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.TaskOf``1(System.String)">
    /// <summary>
    /// Registers a new task.
    /// </summary>
    /// <param name="name">The name of the task.</param>
    /// <returns>A <see cref="T:Cake.Core.CakeTaskBuilder" />.</returns>
    /// <typeparam name="TData">The type of the data context.</typeparam>
    /// <example>
    /// <code>
    /// TaskOf&lt;Foo&gt;("Hello")
    ///     .Does(data =&gt;
    /// {
    ///     Information("Hello {0}", data.Place);
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static global::Cake.Core.CakeTaskBuilder<TData> TaskOf<TData>(string name)
        where TData : class
        => ScriptHost.TaskOf<TData>(name);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.Setup(System.Action{Cake.Core.ISetupContext})">
    /// <summary>
    /// Allows registration of an action that's executed before any tasks are run.
    /// If setup fails, no tasks will be executed but teardown will be performed.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// Setup(context =&gt; {
    ///   context.Log.Information("Hello World!");
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void Setup(global::System.Action<global::Cake.Core.ISetupContext> action)
        => ScriptHost.Setup(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.Setup``1(System.Func{Cake.Core.ISetupContext,``0})">
    /// <summary>
    /// Allows registration of an action that's executed before any tasks are run.
    /// If setup fails, no tasks will be executed but teardown will be performed.
    /// </summary>
    /// <typeparam name="TData">The data type.</typeparam>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// Setup&lt;Foo&gt;(context =&gt; {
    ///   return new Foo();
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void Setup<TData>(global::System.Func<global::Cake.Core.ISetupContext, TData> action)
        where TData : class
        => ScriptHost.Setup<TData>(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.Teardown(System.Action{Cake.Core.ITeardownContext})">
    /// <summary>
    /// Allows registration of an action that's executed after all other tasks have been run.
    /// If a setup action or a task fails with or without recovery, the specified teardown action will still be executed.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// Teardown(context =&gt; {
    ///   context.Log.Information("Goodbye World!");
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void Teardown(global::System.Action<global::Cake.Core.ITeardownContext> action)
        => ScriptHost.Teardown(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.Teardown``1(System.Action{Cake.Core.ITeardownContext,``0})">
    /// <summary>
    /// Allows registration of an action that's executed after all other tasks have been run.
    /// If a setup action or a task fails with or without recovery, the specified teardown action will still be executed.
    /// </summary>
    /// <typeparam name="TData">The data type.</typeparam>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// Teardown((context, data) =&gt; {
    ///   context.Log.Information("Goodbye {0}!", data.Place);
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void Teardown<TData>(global::System.Action<global::Cake.Core.ITeardownContext, TData> action)
        where TData : class
        => ScriptHost.Teardown<TData>(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.TaskSetup(System.Action{Cake.Core.ITaskSetupContext})">
    /// <summary>
    /// Allows registration of an action that's executed before each task is run.
    /// If the task setup fails, its task will not be executed but the task teardown will be performed.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// TaskSetup(context =&gt;
    /// {
    ///     Information("Starting {0}", context.Task.Name);
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void TaskSetup(global::System.Action<global::Cake.Core.ITaskSetupContext> action)
        => ScriptHost.TaskSetup(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.TaskSetup``1(System.Action{Cake.Core.ITaskSetupContext,``0})">
    /// <summary>
    /// Allows registration of an action that's executed before each task is run.
    /// If the task setup fails, its task will not be executed but the task teardown will be performed.
    /// </summary>
    /// <typeparam name="TData">The data type.</typeparam>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// TaskSetup&lt;Foo&gt;((context, data) =&gt;
    /// {
    ///     Information("Starting {0} for {1}", context.Task.Name, data.Place);
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void TaskSetup<TData>(global::System.Action<global::Cake.Core.ITaskSetupContext, TData> action)
        where TData : class
        => ScriptHost.TaskSetup<TData>(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.TaskTeardown(System.Action{Cake.Core.ITaskTeardownContext})">
    /// <summary>
    /// Allows registration of an action that's executed after each task has been run.
    /// If a task setup action or a task fails with or without recovery, the specified task teardown action will still be executed.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// TaskTeardown(context =&gt;
    /// {
    ///     Information("Finished {0}", context.Task.Name);
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void TaskTeardown(global::System.Action<global::Cake.Core.ITaskTeardownContext> action)
        => ScriptHost.TaskTeardown(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.TaskTeardown``1(System.Action{Cake.Core.ITaskTeardownContext,``0})">
    /// <summary>
    /// Allows registration of an action that's executed after each task has been run.
    /// If a task setup action or a task fails with or without recovery, the specified task teardown action will still be executed.
    /// </summary>
    /// <typeparam name="TData">The data type.</typeparam>
    /// <param name="action">The action to be executed.</param>
    /// <example>
    /// <code>
    /// TaskTeardown&lt;Foo&gt;((context, data) =&gt;
    /// {
    ///     Information("Finished {0} for {1}", context.Task.Name, data.Place);
    /// });
    /// </code>
    /// </example>
    /// </member>
    public static void TaskTeardown<TData>(global::System.Action<global::Cake.Core.ITaskTeardownContext, TData> action)
        where TData : class
        => ScriptHost.TaskTeardown<TData>(action);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.RunTarget(System.String)">
    /// <summary>
    /// Runs the specified target.
    /// </summary>
    /// <param name="target">The target to run.</param>
    /// <returns>The resulting report.</returns>
    /// <example>
    /// <code>
    /// var target = Argument("target", "Default");
    /// RunTarget(target);
    /// </code>
    /// </example>
    /// </member>
    public static global::Cake.Core.CakeReport RunTarget(string target)
        => ScriptHost.RunTarget(target);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.RunTargetAsync(System.String)">
    /// <summary>
    /// Runs the specified target.
    /// </summary>
    /// <param name="target">The target to run.</param>
    /// <returns>The resulting report.</returns>
    /// <example>
    /// <code>
    /// var target = Argument("target", "Default");
    /// await RunTargetAsync(target);
    /// </code>
    /// </example>
    /// </member>
    public static global::System.Threading.Tasks.Task<global::Cake.Core.CakeReport> RunTargetAsync(string target)
        => ScriptHost.RunTargetAsync(target);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.RunTargets(System.Collections.Generic.IEnumerable{System.String})">
    /// <summary>
    /// Runs the specified targets.
    /// </summary>
    /// <param name="targets">The targets to run.</param>
    /// <returns>The resulting report.</returns>
    /// <example>
    /// <code>
    /// RunTargets(["Clean", "Build"]);
    /// </code>
    /// </example>
    /// </member>
    public static global::Cake.Core.CakeReport RunTargets(global::System.Collections.Generic.IEnumerable<string> targets)
        => ScriptHost.RunTargets(targets);

    /// <member name="M:Cake.Core.Scripting.IScriptHost.RunTargetsAsync(System.Collections.Generic.IEnumerable{System.String})">
    /// <summary>
    /// Runs the specified targets.
    /// </summary>
    /// <param name="targets">The targets to run.</param>
    /// <returns>The resulting report.</returns>
    /// <example>
    /// <code>
    /// await RunTargetsAsync(["Clean", "Build"]);
    /// </code>
    /// </example>
    /// </member>
    public static global::System.Threading.Tasks.Task<global::Cake.Core.CakeReport> RunTargetsAsync(global::System.Collections.Generic.IEnumerable<string> targets)
        => ScriptHost.RunTargetsAsync(targets);

    /// <summary>
    /// Gets the context.
    /// </summary>
    public static global::Cake.Core.ICakeContext Context
        => ScriptHost.Context;

    /// <summary>
    /// Gets all registered tasks.
    /// </summary>
    public static global::System.Collections.Generic.IReadOnlyList<global::Cake.Core.ICakeTaskInfo> Tasks
        => ScriptHost.Tasks;

    /// <summary>
    /// Gets the execution settings.
    /// </summary>
    public static global::Cake.Core.ExecutionSettings Settings
        => ScriptHost.Settings;

}
