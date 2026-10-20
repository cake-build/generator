using BenchmarkDotNet.Running;

namespace Cake.Generator.Core.BenchmarkSuite;

internal class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
    }
}
