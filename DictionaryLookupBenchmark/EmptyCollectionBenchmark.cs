//BenchmarkDotNet.Running.BenchmarkRunner.Run<LookupBenchmark>();
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

[SimpleJob(runtimeMoniker: RuntimeMoniker.Net80)]
[SimpleJob(runtimeMoniker: RuntimeMoniker.Net90)]
public class EmptyCollectionBenchmark
{
    private readonly Consumer _consumer = new();

    [Params(1000, 10_000, 100_000)]
    public int Length { get; set; }

    [Benchmark(Baseline = true)]
    public void NewEmptyArray()
    {
        for (int i = 0; i != this.Length; i++)
        {
            var empty = new int[0];
            _consumer.Consume(empty);
        }
    }

    [Benchmark(Baseline = false)]
    public void EnumerableEmpty()
    {
        for (int i = 0; i != this.Length; i++)
        {
            var empty = Enumerable.Empty<int>();
            _consumer.Consume(empty);
        }
    }

    [Benchmark(Baseline = false)]
    public void ArrayEmpty()
    {
        for (int i = 0; i != this.Length; i++)
        {
            var empty = Array.Empty<int>();
            _consumer.Consume(empty);
        }
    }

    [Benchmark(Baseline = false)]
    public void CollectionInitializer()
    {
        for (int i = 0; i != this.Length; i++)
        {
            IEnumerable<int> empty = [];
            _consumer.Consume(empty);
        }
    }
}
