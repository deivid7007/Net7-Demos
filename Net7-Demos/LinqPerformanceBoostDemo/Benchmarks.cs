using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqPerformanceBoostDemo
{
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        [Params(1000)]
        public int Size { get; set; }

        public IEnumerable<int> Items { get; set; }

        public void Setup()
        {
            Items = Enumerable.Range(1, Size).ToArray();
        }

        [Benchmark]
        public int Max() => Items.Max();

        [Benchmark]
        public int Min() => Items.Min();

        [Benchmark]
        public double Average() => Items.Average();

        [Benchmark]
        public int Sum() => Items.Sum();
    }
}
