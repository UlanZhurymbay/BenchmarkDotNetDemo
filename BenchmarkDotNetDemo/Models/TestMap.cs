namespace BenchmarkDotNetDemo.Models;

public class TestMap
{
    public TestMap(int ageMap, int age2Map, string nameMap, string name2Map)
    {
        AgeMap = ageMap;
        Age2Map = age2Map;
        NameMap = nameMap;
        Name2Map = name2Map;
    }

    public int AgeMap { get; private set; }
    public int Age2Map { get; private set; }
    public string NameMap { get; private set; }
    public string Name2Map { get; private set; }

    public override string ToString()
    {
        return
            $"2 => {AgeMap}:{Age2Map}:{NameMap}.{Name2Map}";
    }
}