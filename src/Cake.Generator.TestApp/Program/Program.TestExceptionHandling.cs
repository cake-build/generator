public static partial class Program
{
    /// <summary>
    /// Intentionally throws to verify generated RegisterExceptionHandlers output.
    /// Run with: <code>dotnet run -- --target=Test-Exception-Handling</code>.
    /// </summary>
    private static void TestExceptionHandling()
    {
        throw new InvalidOperationException(
            "Intentional exception to verify RegisterExceptionHandlers output.");
    }
}
