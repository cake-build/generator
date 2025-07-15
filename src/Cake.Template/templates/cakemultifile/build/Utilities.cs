public static partial class Program
{
    public static class BuildUtilities
    {
        public static void LogInfo(string message)
        {
            Information($"INFO: {message}");
        }
        
        public static void LogWarning(string message)
        {
            Warning($"WARNING: {message}");
        }
        
        public static void LogError(string message)
        {
            Error($"ERROR: {message}");
        }
    }
} 