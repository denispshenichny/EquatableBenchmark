``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.778 (1909/November2018Update/19H2)
Intel Core i3-8100 CPU 3.60GHz (Coffee Lake), 1 CPU, 4 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4121.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4121.0), X86 LegacyJIT


```
|           Method |      Mean |    Error |   StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|----------------- |----------:|---------:|---------:|------------:|------:|------:|------------:|
|      ContainsImp |  62.74 ms | 0.210 ms | 0.196 ms |           - |     - |     - |           - |
|      ContainsExp |  62.98 ms | 0.142 ms | 0.133 ms |           - |     - |     - |           - |
|      ContainsDef | 186.89 ms | 1.227 ms | 1.148 ms | 152666.6667 |     - |     - | 480706595 B |
| ContainsNoEquals | 783.61 ms | 3.452 ms | 3.229 ms | 305000.0000 |     - |     - | 961415908 B |
|      OperatorImp |  64.38 ms | 0.226 ms | 0.200 ms |           - |     - |     - |           - |
|      OperatorExp | 451.59 ms | 2.224 ms | 2.081 ms | 305000.0000 |     - |     - | 961415908 B |
