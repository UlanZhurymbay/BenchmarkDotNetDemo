// See https://aka.ms/new-console-template for more information
//TODO "cd .\BenchmarkDotNetDemo\"
//TODO command for run in the terminal -> "dotnet run --project BenchmarkDotNetDemo.csproj -c Release"

using System.Collections;
using BenchmarkDotNet.Running;
using BenchmarkDotNetDemo;
using BenchmarkDotNetDemo.ForBoxingUnBoxing;
using BenchmarkDotNetDemo.ForCastType;

BenchmarkRunner.Run<BoxingClass>();
//BenchmarkRunner.Run<CastObject>();
//BenchmarkRunner.Run<MemoryBenchMarkerDemo>();