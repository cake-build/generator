#:sdk Cake.Sdk

Task("TrivialTask")
    .Does(() =>
{
    Information("Hello, World!");
});

RunTarget("TrivialTask"); 