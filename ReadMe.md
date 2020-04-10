``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.752 (1909/November2018Update/19H2)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4150.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4150.0), X86 LegacyJIT


```
|      Method |      Mean |    Error |   StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|------------ |----------:|---------:|---------:|------------:|------:|------:|------------:|
| ContainsImp |  68.38 ms | 1.360 ms | 2.520 ms |           - |     - |     - |           - |
| ContainsExp |  68.37 ms | 0.926 ms | 0.866 ms |           - |     - |     - |           - |
| ContainsDef | 222.49 ms | 4.301 ms | 5.120 ms | 152666.6667 |     - |     - | 480706595 B |
| OperatorImp |  70.83 ms | 1.140 ms | 1.066 ms |           - |     - |     - |           - |
| OperatorExp | 510.08 ms | 6.545 ms | 7.537 ms | 305000.0000 |     - |     - | 961415908 B |
