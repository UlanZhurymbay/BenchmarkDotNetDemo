namespace BenchmarkDotNetDemo.Models;

public class Test
{
    public int Age { get; set; }
    public int Age2 { get; set; }
    public string Name { get; set; }
    public string Name2 { get; set; }
    public override string ToString()
    {
        return
            $"1 => {Age}:{Age2}:{Name}.{Name2}";
    }
}