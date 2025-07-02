namespace Cake.Generator.TestApp.Models;

public record CodeSigningCredentials(
    string SignTenantId,
    string SignClientId,
    string SignClientSubsription,
    string SignKeyVaultCertificate,
    string SignKeyVaultUrl,
    FilePath? SignClientPath,
    FilePath SignFilterPath)
{
    public bool HasCredentials
    {
        get
        {
            return
                !string.IsNullOrEmpty(SignTenantId) &&
                !string.IsNullOrEmpty(SignClientId) &&
                !string.IsNullOrEmpty(SignClientSubsription) &&
                !string.IsNullOrEmpty(SignKeyVaultCertificate) &&
                !string.IsNullOrEmpty(SignKeyVaultUrl);
        }
    }

    public static CodeSigningCredentials GetCodeSigningCredentials(ICakeContext context)
    {
        return new CodeSigningCredentials(
            SignTenantId: context.EnvironmentVariable("SIGN_TENANT_ID"),
            SignClientId: context.EnvironmentVariable("SIGN_CLIENT_ID"),
            SignClientSubsription: context.EnvironmentVariable("SIGN_CLIENT_SUBSCRIPTION"),
            SignKeyVaultCertificate: context.EnvironmentVariable("SIGN_KEYVAULT_CERTIFICATE"),
            SignKeyVaultUrl: context.EnvironmentVariable("SIGN_KEYVAULT_URL"),
            SignClientPath: context.Tools.Resolve("sign.exe")
                                    ?? context.Tools.Resolve("sign")
                                    ?? (
                                        context.IsRunningOnWindows()
                                            ? throw new Exception("Failed to locate sign tool")
                                            : null),
            SignFilterPath: context
                                .GetFiles("signclient.filter")
                                .FirstOrDefault()
                                ?? throw new Exception("Failed to locate signclient.filter"));
    }
}