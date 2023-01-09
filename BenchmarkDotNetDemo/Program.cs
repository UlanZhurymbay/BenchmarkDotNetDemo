// See https://aka.ms/new-console-template for more information
//TODO "cd .\BenchmarkDotNetDemo\"
//TODO command for run in the terminal -> "dotnet run -p BenchmarkDotNetDemo.csproj -c Release"

using BenchmarkDotNet.Running;
using BenchmarkDotNetDemo;

BenchmarkRunner.Run<CastObject>();
//BenchmarkRunner.Run<MemoryBenchMarkerDemo>();