namespace BenchmarkDotNetDemo.Models;

public class Test
{
    public Test(int age, int age2, string name, string name2)
    {
        Age = age;
        Age2 = age2;
        Name = name;
        Name2 = name2;
    }

    public int Age { get; private set; }
    public int Age2 { get; private set; }
    public string Name { get; private set; }
    public string Name2 { get; private set; }

    public override string ToString()
    {
        return
            $"1 => {Age}:{Age2}:{Name}.{Name2}";
    }
}