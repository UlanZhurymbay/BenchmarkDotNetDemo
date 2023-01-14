using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetDemo.ForBoxingUnBoxing;
[RankColumn ]
[MemoryDiagnoser]
public class BoxingClass
{
    private const int Capacity = 2000;
    BoxingA A = new();
    BoxingB B = new();    
    BoxingAClass AClass = new();
    BoxingBClass BClass = new();
    
    [Benchmark(Description = "B Boxing with override")]
    public void First()
    {
        for (var i = 0; i < Capacity; i++)
        {
            B.ToString();
        }
    }
    [Benchmark(Description = "A Boxing without override")]
    public void Second()
    {
        for (var i = 0; i < Capacity; i++)
        {
            A.ToString();
        }
    }   
    [Benchmark(Description = "B BoxingClass with override")]
    public void Third()
    {
        for (var i = 0; i < Capacity; i++)
        {
            BClass.ToString();
        }
    }
    [Benchmark(Description = "A BoxingClass without override")]
    public void Fourth()
    {
        for (var i = 0; i < Capacity; i++)
        {
            AClass.ToString();
        }
    }
}
public struct BoxingA
{
}
public struct BoxingB
{
    public override string ToString()
    {
        return "BenchmarkDotNetDemo.ForBoxingUnBoxing.BoxingA";
    }
}
public class BoxingAClass
{
}
public class BoxingBClass
{
    public override string ToString()
    {
        return "BenchmarkDotNetDemo.ForBoxingUnBoxing.BoxingA";
    }
}