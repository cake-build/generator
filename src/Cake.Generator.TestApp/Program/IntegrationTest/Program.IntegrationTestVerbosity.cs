public static partial class Program
{
    private static void IntegrationTestVerbosity(ICakeContext ctx, BuildData data)
    {
        var script = data.IntegrationTest.CakeVerbosityCs;

        (string Description, string? ConfiguredVerbosity, string CommandLine, string Expected)[] cases =
            [
                ("configuration supplies the verbosity", "Minimal", string.Empty, "Minimal"),
                ("command line beats configuration", "Diagnostic", "--verbosity quiet", "Quiet"),
                ("explicit normal beats configuration", "Diagnostic", "--verbosity normal", "Normal"),
                ("cake.config inside the working directory is honoured", null, "--working verbosity-config", "Diagnostic"),
                ("cake.config outside the working directory is ignored", null, string.Empty, "Normal")
            ];

        foreach (var (description, configuredVerbosity, commandLine, expected) in cases)
        {
            Information("Verbosity precedence: {0}, expecting {1}.", description, expected);

            data.DotNet(
                configuredVerbosity is null
                    ? []
                    : new Dictionary<string, string>
                    {
                        ["CAKE_SETTINGS_VERBOSITY"] = configuredVerbosity
                    },
                $"{script.FullPath.Quote()} -p:TreatWarningsAsErrors=true -- {commandLine} --expected-verbosity={expected}");
        }
    }
}
