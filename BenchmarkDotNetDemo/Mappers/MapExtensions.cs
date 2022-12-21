using BenchmarkDotNetDemo.Models;

namespace BenchmarkDotNetDemo.Mappers;

public static class MapExtensions
{
    public static TestMap AutoMap(this Test test) =>
        new( test.Age,  test.Age2, test.Name, test.Name2 );
}