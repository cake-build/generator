public static partial class Program
{
    private static void SignBinaries(ICakeContext context, BuildData data)
    {
        // Get the files to sign.
        var files = GetFiles($"{data.OutputDirectory}/Cake.*.{data.Version}.nupkg").ToArray();
        var commandSettings = new CommandSettings
        {
            ToolExecutableNames =
            [
                "sign", "sign.exe"
            ],
            ToolName = "sign",
            ToolPath = data.CodeSigningCredentials.SignClientPath
        };

        Parallel.ForEach(
            files,
            file =>
            {
                context.Information("Signing {0}...", file.FullPath);

                // Build the argument list.
                var arguments = new ProcessArgumentBuilder()
                .Append("code")
                .Append("azure-key-vault")
                .AppendQuoted(file.FullPath)
                .AppendSwitchQuoted("--file-list", data.CodeSigningCredentials.SignFilterPath.FullPath)
                .AppendSwitchQuoted("--publisher-name", "Cake")
                .AppendSwitchQuoted("--description", "Cake (C# Make) is a cross platform build automation system.")
                .AppendSwitchQuoted("--description-url", "https://cakebuild.net")
                .AppendSwitchQuoted("--azure-credential-type", "azure-cli")
                .AppendSwitchQuotedSecret("--azure-key-vault-certificate", data.CodeSigningCredentials.SignKeyVaultCertificate)
                .AppendSwitchQuotedSecret("--azure-key-vault-url", data.CodeSigningCredentials.SignKeyVaultUrl);

                context.Command(
                commandSettings,
                arguments);

                context.Information("Done signing {0}.", file.FullPath);
            });
    }
}