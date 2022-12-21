using BenchmarkDotNet.Attributes;
using BenchmarkDotNetDemo.Models;

namespace BenchmarkDotNetDemo;

[RankColumn ]
[MemoryDiagnoser]
public class MemoryBenchMarkerDemo
{
    private readonly Test _item = new ( 5,  2, "1",  "2");
    private const int Capacity = 2000;
    private readonly MyMapper _myMapper = new ();
    [Benchmark(Description = "AutoMapper")]
    public List<TestMap> UsingAutoMapperFromList()
    {
        var testList = new List<TestMap>(Capacity);
        for (var i = 0; i < Capacity; i++)          
        {
            testList.Add(_myMapper.MapFromAutoMapper(_item));
        }
        return testList;
    }    
    [Benchmark(Description = "MapExtension")]
    public List<TestMap> UsingMapExtensionFromList()
    {
        var testList = new List<TestMap>(Capacity);
        for (var i = 0; i < Capacity; i++)   
        {
            testList.Add(_myMapper.MapFromMapExtension(_item));
        }
        return testList;
    }
    [Benchmark(Description = "MapClass")]
    public List<TestMap> UsingMapClassFromList()
    {
        var testList = new List<TestMap>(Capacity);
        for (var i = 0; i < Capacity; i++)   
        {
            testList.Add(_myMapper.MapFromMapClass(_item));
        }
        return testList;
    }
}