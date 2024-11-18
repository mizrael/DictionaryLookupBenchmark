using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

[SimpleJob(runtimeMoniker: RuntimeMoniker.Net80)]
[SimpleJob(runtimeMoniker: RuntimeMoniker.Net90)]
public class DictionaryLookupBenchmark
{
    private Dictionary<int, string> _dict;
    private readonly Consumer _consumer = new();

    [GlobalSetup]
    public void GlobalSetup()
    {
        _dict = Enumerable.Range(0, this.Length)
                   .ToDictionary(x => x, x => x.ToString());
    }

    [Benchmark(Baseline = true)]
    public void TryGetValue()
    {
        for (int i = 0; i != this.Length; i++)
        {
            if (_dict.TryGetValue(i, out var value))
            {
                _consumer.Consume(value);
            }
        }
    }

    [Benchmark()]
    public void LookupAndGet()
    {
        for (int i = 0; i != this.Length; i++)
        {
            if (_dict.ContainsKey(i))
            {
                var value = _dict[i];
                _consumer.Consume(value);
            }
        }
    }

    [Params(1000, 10_000, 100_000)]
    public int Length { get; set; }
}
