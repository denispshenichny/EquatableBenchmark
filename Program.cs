using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;


namespace EquatableBenchmark {
    class Program {
        static void Main(string[] args) {
            BenchmarkRunner.Run<Benchmark>(DefaultConfig.Instance
                    .AddDiagnoser(MemoryDiagnoser.Default));
        }
    }
}
