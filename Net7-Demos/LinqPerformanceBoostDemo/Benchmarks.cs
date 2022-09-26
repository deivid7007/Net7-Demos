using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqPerformanceBoostDemo
{
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private IEnumerable<int> _items { get; set; } =
            Enumerable.Range(1, 100).ToArray();

        [Benchmark]
        public int Max() => _items.Max();

        [Benchmark]
        public int Min() => _items.Min();

        [Benchmark]
        public double Average() => _items.Average();

        [Benchmark]
        public int Sum() => _items.Sum();
    }
}
