using BenchmarkDotNetDemo.Models;

namespace BenchmarkDotNetDemo.Mappers;

public class Map
{
    public TestMap Mapping( Test test) =>
        new( test.Age,  test.Age2, test.Name, test.Name2 );
}