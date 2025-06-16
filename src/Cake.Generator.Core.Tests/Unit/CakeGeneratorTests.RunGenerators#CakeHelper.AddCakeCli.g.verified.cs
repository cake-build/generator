//HintName: CakeHelper.AddCakeCli.g.cs

using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Cli;

public static partial class Program
{
    private static partial class Helper
    {
        private static IServiceCollection AddCakeCli(
            IServiceCollection services
            )
        {
            // Converters
            services.AddSingleton<global::Cake.Cli.DirectoryPathConverter>();
            services.AddSingleton<global::Cake.Cli.FilePathConverter>();
            services.AddSingleton<global::Cake.Cli.VerbosityConverter>();
            services.AddSingleton<global::Cake.Cli.VersionFeature>();
            services.AddSingleton<global::Cake.Cli.InfoFeature>();
            services.AddSingleton<global::Cake.Cli.IVersionResolver, VersionResolver>();

            services.AddSingleton<global::Cake.Cli.DescriptionScriptHost>();
            services.AddSingleton<global::Cake.Cli.DryRunScriptHost>();
            services.AddSingleton<global::Cake.Cli.TreeScriptHost>();

            var interceptor = new CakeArgumentsCommandInterceptor();
            var commandApp = new CommandApp<CakeArgumentsCommand>();
            
            var appName = new FilePath(Environment.GetCommandLineArgs().FirstOrDefault() ?? "cake").GetFilenameWithoutExtension();

            commandApp.Configure(config => {
                    config.SetInterceptor(interceptor);
                    config.SetApplicationName($"dotnet run {appName}.cs / dotnet run --project {appName}.csproj");
                }
            );
            
            var result = commandApp.Run(Environment.GetCommandLineArgs().Skip(1));

            // If the command is not a cake command, exit with the result
            if (interceptor.Context is null || interceptor.CakeAppSettings is null)
            {
                Environment.Exit(result);
            }

            services.AddSingleton(interceptor.CakeAppSettings);
            services.AddSingleton<Spectre.Console.Cli.CommandSettings>(provider => provider.GetRequiredService<CakeAppSettings>());
            
            var arguments = global::Cake.Cli.Infrastructure.IRemainingArgumentsExtensions.ToCakeArguments(ToUnQuotedRemainingArguments(interceptor.Context.Remaining), interceptor.CakeAppSettings.Targets);
            services.AddSingleton(arguments);
            services.AddSingleton<ICakeArguments>(arguments);

            return services;
        }

        private class CakeArgumentsCommandInterceptor : ICommandInterceptor
        {
            public CommandContext? Context { get; private set; }
            public Spectre.Console.Cli.CommandSettings? CommandSettings { get; private set; }
            public CakeAppSettings? CakeAppSettings { get; private set; }
            public void Intercept(CommandContext context, Spectre.Console.Cli.CommandSettings settings)
            {
                Context = context;
                CommandSettings = settings;
                if (settings is CakeAppSettings cakeAppSettings)
                {
                    CakeAppSettings = cakeAppSettings;
                }
            }
        }

        private class CakeArgumentsCommand : Command<CakeAppSettings>
        {
            public override int Execute(Spectre.Console.Cli.CommandContext context, CakeAppSettings settings)
            {
                return 0;
            }
        }

        private class VersionResolver : global::Cake.Cli.IVersionResolver
        {
            public string GetVersion() => CakeGeneratorVersion;
            public string GetProductVersion() => CakeGeneratorInformationalVersion;
        }

        /// <summary>
        /// Removes surrounding quotes from a string if they exist, otherwise returns the original string.
        /// Handles both single and double quotes, and preserves escaped quotes within the string.
        /// </summary>
        /// <param name="value">The string to unquote.</param>
        /// <returns>The unquoted string, or the original string if not quoted.</returns>
        private static string? UnQuote(string? value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            // Check if string starts and ends with the same quote type
            char startQuote = value[0];
            if (startQuote != '"' && startQuote != '\'')
            {
                return value;
            }

            if (value[^1] != startQuote)
            {
                return value;
            }

            // Use span to avoid allocations
            ReadOnlySpan<char> span = value.AsSpan(1, value.Length - 2);
            if (span.IsEmpty)
            {
                return string.Empty;
            }

            // If no escaped quotes, we can return the substring directly
            if (!span.Contains('\\'))
            {
                return span.ToString();
            }

            // Handle escaped quotes
            var result = new char[span.Length];
            int writeIndex = 0;
            bool escaped = false;

            for (int i = 0; i < span.Length; i++)
            {
                char c = span[i];
                if (escaped)
                {
                    result[writeIndex++] = c;
                    escaped = false;
                }
                else if (c == '\\')
                {
                    escaped = true;
                }
                else
                {
                    result[writeIndex++] = c;
                }
            }

            return new string(result, 0, writeIndex);
        }

        /// <summary>
        /// Creates a new lookup where all values have been unquoted using the UnQuote extension method.
        /// </summary>
        /// <param name="lookup">The source lookup containing quoted strings.</param>
        /// <returns>A new lookup with unquoted values.</returns>
        private static ILookup<string, string?> ToUnQuotedLookup(ILookup<string, string?> lookup)
        {
            return lookup
                .SelectMany(g => g.Select(v => new { g.Key, Value = UnQuote(v) }))
                .ToLookup(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// Creates a new <see cref="Spectre.Console.Cli.IRemainingArguments"/> where all parsed values have been unquoted.
        /// </summary>
        /// <param name="argument">The source remaining arguments containing quoted strings.</param>
        /// <returns>A new remaining arguments instance with unquoted values.</returns>
        private static Spectre.Console.Cli.IRemainingArguments ToUnQuotedRemainingArguments(Spectre.Console.Cli.IRemainingArguments argument)
        {
            return new RemainingArgumentsAdapter(
                ToUnQuotedLookup(argument.Parsed),
                argument.Raw);
        }

        private record RemainingArgumentsAdapter(
            ILookup<string, string?> Parsed,
            IReadOnlyList<string> Raw)
            : Spectre.Console.Cli.IRemainingArguments;
    }
}