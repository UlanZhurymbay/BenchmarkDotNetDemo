using BenchmarkDotNetDemo.Models;

namespace BenchmarkDotNetDemo.Mappers;

public class Map
{
    public TestMap Mapping( Test test) =>
        new() { AgeMap = test.Age, Age2Map = test.Age2, NameMap = test.Name, Name2Map = test.Name2 };
}