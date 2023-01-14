using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetDemo.ForCastType;
[RankColumn ]
[MemoryDiagnoser]
public class CastObject
{
    private readonly object _b = new B{ Name = "B"};
    private const int Capacity = 2000;
    [Benchmark(Description = "A class from as")]
    public A Second()
    {
        var a = new A();
        for (var i = 0; i < Capacity; i++)
        {
            //    var b = _b as A;
            a = _b as A;
            //   if (b != null)
            //       a = b;
        }
        return a;
    }
    [Benchmark(Description = "A class from is")]
    public A First()
    {
        var a = new A();
        for (var i = 0; i < Capacity; i++)
        {
            //    if (_b is A)
                a = (A)_b;
        }
        return a;
    }


    [Benchmark(Description = "A class pattern matching")]
    public A Third()
    {
        var a = new A();
        for (var i = 0; i < Capacity; i++)
        {
            if (_b is A b)
                a = b;
        }
        return a;
    }
}

public class A
{
    public string Name { get; set; } = "A";
}
public class B : A
{
}