using AutoMapper;
using BenchmarkDotNetDemo.Mappers;
using BenchmarkDotNetDemo.Models;

namespace BenchmarkDotNetDemo;

public class MyMapper
{
    private readonly Mapper _mapper = new (new MapperConfiguration( c => c.CreateMap<Test, TestMap>()
        .ForMember(t => t.AgeMap, t => t.MapFrom(t2 => t2.Age))
        .ForMember(t => t.Age2Map, t => t.MapFrom(t2 => t2.Age2))
        .ForMember(t => t.NameMap, t => t.MapFrom(t2 => t2.Name))
        .ForMember(t => t.Name2Map, t => t.MapFrom(t2 => t2.Name2))));

    private readonly Map _map = new Map();
    public TestMap MapFromAutoMapper(Test test) =>
        _mapper.Map<TestMap>(test);
        
    public TestMap MapFromMapExtension(Test test) =>
        test.AutoMap();

    public TestMap MapFromMapClass(Test test) =>
        _map.Mapping(test);
}