using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;


namespace EquatableBenchmark {
    class Program {
        static void Main(string[] args) {
            BenchmarkRunner.Run<Benchmark>(DefaultConfig.Instance
                    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core31))
                    .AddJob(Job.Default.WithRuntime(ClrRuntime.Net48))
                    .AddDiagnoser(MemoryDiagnoser.Default));
        }
    }
}
