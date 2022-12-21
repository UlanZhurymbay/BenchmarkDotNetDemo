using BenchmarkDotNetDemo.Models;

namespace BenchmarkDotNetDemo.Mappers;

public static class MapExtensions
{
    public static TestMap AutoMap(this Test test) =>
        new() { AgeMap = test.Age, Age2Map = test.Age2, NameMap = test.Name, Name2Map = test.Name2 };
}