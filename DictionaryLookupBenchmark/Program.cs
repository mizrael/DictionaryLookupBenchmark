// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using static System.Runtime.InteropServices.JavaScript.JSType;

BenchmarkDotNet.Running.BenchmarkRunner.Run<LookupBenchmark>();


public class LookupBenchmark
{
    private readonly Dictionary<string, string> _dictionary = new ();
    private readonly SortedDictionary<string, string> _sortedDictionary = new ();
    private readonly SortedList<string, string> _sortedList = new ();
    private readonly HashSet<string> _hashSet = new ();

    private string[] _keysToLookup;

    [Params(10, 100, 1000, 10_000, 100_000, 1_000_000)]
    public int ElementsCount { get; set; }

    [Params(10, 100, 1000, 10_000, 100_000, 1_000_000)]
    public int LookupsCount { get; set; }


    [GlobalSetup]
    public void GlobalSetup()
    {
        _dictionary.Clear ();
        _sortedDictionary.Clear ();
        _sortedList.Clear ();
        _hashSet.Clear ();

        for (int i = 0; i < this.ElementsCount; i++)
        {
            var item = i.ToString();

            _dictionary.Add(item, item);
            _sortedDictionary.Add(item, item);
            _sortedList.Add(item, item);
            _hashSet.Add(item);
        }

        _keysToLookup = new string[this.LookupsCount];
        for (int i = 0; i < this.LookupsCount; i++)        
            _keysToLookup[i] = Random.Shared.Next(0, this.ElementsCount).ToString();        
    }

    [Benchmark(Baseline = true)]
    public bool[] DictionaryLookup()
    {
        var results = new bool[this.LookupsCount];
        for (int i = 0; i < this.LookupsCount; i++)
        {
            var key = _keysToLookup[i];
            results[i] = _dictionary.ContainsKey(key);
        }
        return results;
    }

    [Benchmark]
    public bool[] SortedDictionaryLookup()
    {
        var results = new bool[this.LookupsCount];
        for (int i = 0; i < this.LookupsCount; i++)
        {
            var key = _keysToLookup[i];
            results[i] = _sortedDictionary.ContainsKey(key);
        }
        return results;
    }

    [Benchmark]
    public bool[] SortedListLookup()
    {
        var results = new bool[this.LookupsCount];
        for (int i = 0; i < this.LookupsCount; i++)
        {
            var key = _keysToLookup[i];
            results[i] = _sortedList.ContainsKey(key);
        }
        return results;
    }

    [Benchmark]
    public bool[] HashSetLookup()
    {
        var results = new bool[this.LookupsCount];
        for (int i = 0; i < this.LookupsCount; i++)
        {
            var key = _keysToLookup[i];
            results[i] = _hashSet.Contains(key);
        }
        return results;
    }
}