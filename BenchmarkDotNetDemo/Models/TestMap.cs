namespace BenchmarkDotNetDemo.Models;

public class TestMap
{
    public int AgeMap { get; set; }
    public int Age2Map { get; set; }
    public string NameMap { get; set; }
    public string Name2Map { get; set; }
    public override string ToString()
    {
        return
            $"2 => {AgeMap}:{Age2Map}:{NameMap}.{Name2Map}";
    }
}