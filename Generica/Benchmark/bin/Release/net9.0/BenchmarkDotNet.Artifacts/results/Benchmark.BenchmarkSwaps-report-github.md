```

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.4061/24H2/2024Update/HudsonValley)
13th Gen Intel Core i5-13420H 2.10GHz, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2


```
| Method               | Mean      | Error     | StdDev    | Median    |
|--------------------- |----------:|----------:|----------:|----------:|
| BenchmarkSwapGeneric | 0.0111 ns | 0.0234 ns | 0.0183 ns | 0.0003 ns |
| BenchmarkSwap        | 6.5783 ns | 1.0740 ns | 3.1666 ns | 6.5782 ns |
