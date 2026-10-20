public static partial class Program
{
    private static void Main_One()
    {
        Task(nameof(Main_One))
            .IsDependeeOf("Clean")
            .Does(() => Information("Hello from {0}", nameof(Main_One)));
    }

    private static void Main_Two()
    {
        Task(nameof(Main_Two))
            .IsDependeeOf(nameof(Main_One))
            .Does(() => Information("Hello from {0}", nameof(Main_Two)));
    }
}
