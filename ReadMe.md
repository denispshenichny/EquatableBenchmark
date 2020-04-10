``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.752 (1909/November2018Update/19H2)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4150.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4150.0), X86 LegacyJIT


```
|      Method |      Mean |    Error |   StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|------------ |----------:|---------:|---------:|------------:|------:|------:|------------:|
| ContainsImp |  75.00 ms | 1.452 ms | 2.173 ms |           - |     - |     - |           - |
| ContainsExp |  72.31 ms | 1.090 ms | 1.020 ms |           - |     - |     - |           - |
| ContainsDef | 226.40 ms | 4.524 ms | 5.386 ms | 152500.0000 |     - |     - | 480707954 B |
