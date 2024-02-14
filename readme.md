```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3155/23H2/2023Update/SunValley3) (Hyper-V)
AMD EPYC 7763, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.102
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method                 | ElementsCount | LookupsCount | Mean               | Error            | StdDev           | Ratio | RatioSD |
|----------------------- |-------------- |------------- |-------------------:|-----------------:|-----------------:|------:|--------:|
| **DictionaryLookup**       | **10**            | **10**           |           **104.0 ns** |          **0.16 ns** |          **0.15 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10            | 10           |         1,131.7 ns |          1.60 ns |          1.34 ns | 10.88 |    0.02 |
| SortedListLookup       | 10            | 10           |         1,074.1 ns |          0.96 ns |          0.80 ns | 10.33 |    0.02 |
| HashSetLookup          | 10            | 10           |           100.1 ns |          0.25 ns |          0.22 ns |  0.96 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10**            | **100**          |           **988.7 ns** |          **1.68 ns** |          **1.49 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10            | 100          |         9,656.0 ns |         23.79 ns |         22.25 ns |  9.77 |    0.02 |
| SortedListLookup       | 10            | 100          |         9,428.2 ns |         12.34 ns |         10.94 ns |  9.54 |    0.01 |
| HashSetLookup          | 10            | 100          |           964.1 ns |          1.43 ns |          1.34 ns |  0.98 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10**            | **1000**         |        **10,959.3 ns** |        **215.56 ns** |        **348.10 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10            | 1000         |        90,986.4 ns |        399.17 ns |        353.85 ns |  8.27 |    0.30 |
| SortedListLookup       | 10            | 1000         |        93,867.7 ns |        454.41 ns |        425.05 ns |  8.56 |    0.31 |
| HashSetLookup          | 10            | 1000         |        10,632.0 ns |        144.39 ns |        135.06 ns |  0.97 |    0.04 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10**            | **10000**        |       **123,539.1 ns** |        **487.56 ns** |        **407.13 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10            | 10000        |       976,436.9 ns |      1,263.34 ns |      1,181.72 ns |  7.90 |    0.02 |
| SortedListLookup       | 10            | 10000        |     1,010,075.3 ns |      1,664.36 ns |      1,389.81 ns |  8.18 |    0.02 |
| HashSetLookup          | 10            | 10000        |       121,491.2 ns |        440.80 ns |        390.76 ns |  0.98 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10**            | **100000**       |     **1,362,519.1 ns** |      **9,705.68 ns** |      **9,078.70 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10            | 100000       |     9,837,753.5 ns |     17,474.26 ns |     14,591.80 ns |  7.22 |    0.05 |
| SortedListLookup       | 10            | 100000       |    10,172,609.9 ns |     15,928.06 ns |     13,300.65 ns |  7.46 |    0.05 |
| HashSetLookup          | 10            | 100000       |     1,303,727.7 ns |     10,728.21 ns |     10,035.17 ns |  0.96 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10**            | **1000000**      |    **13,662,254.5 ns** |     **90,698.07 ns** |     **80,401.48 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10            | 1000000      |    98,618,485.0 ns |    109,527.60 ns |     85,511.95 ns |  7.23 |    0.04 |
| SortedListLookup       | 10            | 1000000      |   101,098,836.7 ns |    206,932.38 ns |    193,564.68 ns |  7.40 |    0.04 |
| HashSetLookup          | 10            | 1000000      |    12,900,725.3 ns |     66,391.63 ns |     62,102.77 ns |  0.94 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100**           | **10**           |           **104.1 ns** |          **0.23 ns** |          **0.20 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100           | 10           |         2,352.2 ns |          3.34 ns |          2.96 ns | 22.60 |    0.06 |
| SortedListLookup       | 100           | 10           |         1,919.0 ns |          2.62 ns |          2.18 ns | 18.44 |    0.05 |
| HashSetLookup          | 100           | 10           |           101.1 ns |          0.27 ns |          0.25 ns |  0.97 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100**           | **100**          |           **999.2 ns** |          **3.37 ns** |          **3.15 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100           | 100          |        23,317.7 ns |         74.22 ns |         61.97 ns | 23.33 |    0.09 |
| SortedListLookup       | 100           | 100          |        21,981.3 ns |         66.57 ns |         59.01 ns | 22.00 |    0.09 |
| HashSetLookup          | 100           | 100          |           964.8 ns |          1.63 ns |          1.36 ns |  0.97 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100**           | **1000**         |        **10,443.2 ns** |         **62.95 ns** |         **55.81 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100           | 1000         |       240,414.3 ns |        863.12 ns |        807.36 ns | 23.03 |    0.16 |
| SortedListLookup       | 100           | 1000         |       223,598.2 ns |        587.18 ns |        549.25 ns | 21.41 |    0.12 |
| HashSetLookup          | 100           | 1000         |        10,250.5 ns |        137.69 ns |        128.80 ns |  0.98 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100**           | **10000**        |       **125,763.1 ns** |        **200.70 ns** |        **177.91 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100           | 10000        |     2,422,679.3 ns |      4,065.91 ns |      3,803.26 ns | 19.26 |    0.04 |
| SortedListLookup       | 100           | 10000        |     2,418,261.8 ns |      5,357.85 ns |      5,011.74 ns | 19.23 |    0.04 |
| HashSetLookup          | 100           | 10000        |       124,150.6 ns |        848.94 ns |        794.10 ns |  0.99 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100**           | **100000**       |     **1,396,954.4 ns** |      **3,861.74 ns** |      **3,423.33 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100           | 100000       |    24,598,552.9 ns |     29,121.25 ns |     27,240.03 ns | 17.61 |    0.05 |
| SortedListLookup       | 100           | 100000       |    23,082,259.1 ns |     31,620.43 ns |     26,404.49 ns | 16.52 |    0.05 |
| HashSetLookup          | 100           | 100000       |     1,376,270.8 ns |     10,620.76 ns |      9,934.67 ns |  0.99 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100**           | **1000000**      |    **14,344,415.1 ns** |     **61,826.91 ns** |     **57,832.93 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100           | 1000000      |   243,416,091.7 ns |    117,232.33 ns |     91,527.30 ns | 16.98 |    0.06 |
| SortedListLookup       | 100           | 1000000      |   228,630,114.3 ns |    325,866.44 ns |    288,872.11 ns | 15.94 |    0.05 |
| HashSetLookup          | 100           | 1000000      |    13,757,921.2 ns |     34,328.50 ns |     30,431.33 ns |  0.96 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000**          | **10**           |           **126.0 ns** |          **0.20 ns** |          **0.17 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000          | 10           |         3,590.5 ns |          4.85 ns |          3.79 ns | 28.50 |    0.05 |
| SortedListLookup       | 1000          | 10           |         3,948.6 ns |         13.06 ns |         11.58 ns | 31.35 |    0.11 |
| HashSetLookup          | 1000          | 10           |           119.8 ns |          0.36 ns |          0.34 ns |  0.95 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000**          | **100**          |         **1,231.6 ns** |          **1.58 ns** |          **1.48 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000          | 100          |        41,995.3 ns |        211.28 ns |        197.63 ns | 34.10 |    0.17 |
| SortedListLookup       | 1000          | 100          |        38,003.5 ns |        254.61 ns |        238.16 ns | 30.86 |    0.18 |
| HashSetLookup          | 1000          | 100          |         1,221.4 ns |          2.22 ns |          1.97 ns |  0.99 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000**          | **1000**         |        **13,256.7 ns** |         **14.84 ns** |         **11.59 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000          | 1000         |       434,711.9 ns |      1,705.77 ns |      1,595.58 ns | 32.78 |    0.13 |
| SortedListLookup       | 1000          | 1000         |       433,741.6 ns |        877.13 ns |        732.44 ns | 32.73 |    0.05 |
| HashSetLookup          | 1000          | 1000         |        13,007.6 ns |         15.18 ns |         13.46 ns |  0.98 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000**          | **10000**        |       **162,036.8 ns** |        **637.69 ns** |        **565.29 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000          | 10000        |     4,338,005.1 ns |      8,068.31 ns |      7,152.35 ns | 26.77 |    0.11 |
| SortedListLookup       | 1000          | 10000        |     4,062,707.3 ns |     11,539.58 ns |     10,229.53 ns | 25.07 |    0.10 |
| HashSetLookup          | 1000          | 10000        |       163,611.9 ns |      3,233.14 ns |      3,175.38 ns |  1.01 |    0.02 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000**          | **100000**       |     **2,023,122.0 ns** |      **2,831.87 ns** |      **2,510.38 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000          | 100000       |    43,570,367.2 ns |     57,507.20 ns |     53,792.27 ns | 21.53 |    0.04 |
| SortedListLookup       | 1000          | 100000       |    44,799,232.2 ns |     95,522.08 ns |     89,351.42 ns | 22.15 |    0.05 |
| HashSetLookup          | 1000          | 100000       |     2,006,670.9 ns |      1,757.10 ns |      1,467.26 ns |  0.99 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000**          | **1000000**      |    **20,571,112.7 ns** |     **22,503.18 ns** |     **18,791.18 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000          | 1000000      |   435,840,446.2 ns |    335,105.94 ns |    279,828.64 ns | 21.19 |    0.02 |
| SortedListLookup       | 1000          | 1000000      |   398,026,992.9 ns |    846,806.01 ns |    750,671.47 ns | 19.35 |    0.04 |
| HashSetLookup          | 1000          | 1000000      |    20,067,695.1 ns |     32,214.18 ns |     28,557.03 ns |  0.98 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10000**         | **10**           |           **136.1 ns** |          **0.31 ns** |          **0.29 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10000         | 10           |         5,845.8 ns |          3.50 ns |          2.92 ns | 42.98 |    0.10 |
| SortedListLookup       | 10000         | 10           |         5,668.8 ns |         11.03 ns |          9.78 ns | 41.67 |    0.11 |
| HashSetLookup          | 10000         | 10           |           133.5 ns |          0.16 ns |          0.15 ns |  0.98 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10000**         | **100**          |         **1,595.4 ns** |          **2.16 ns** |          **1.92 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10000         | 100          |        61,319.3 ns |        168.42 ns |        140.64 ns | 38.44 |    0.12 |
| SortedListLookup       | 10000         | 100          |        57,310.7 ns |        390.00 ns |        345.72 ns | 35.92 |    0.23 |
| HashSetLookup          | 10000         | 100          |         1,535.6 ns |          0.87 ns |          0.77 ns |  0.96 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10000**         | **1000**         |        **19,823.0 ns** |        **111.36 ns** |         **98.72 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10000         | 1000         |       669,412.4 ns |      2,702.90 ns |      2,528.29 ns | 33.76 |    0.14 |
| SortedListLookup       | 10000         | 1000         |       617,395.1 ns |      1,697.35 ns |      1,504.65 ns | 31.15 |    0.21 |
| HashSetLookup          | 10000         | 1000         |        19,597.9 ns |        373.72 ns |        399.87 ns |  0.99 |    0.02 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10000**         | **10000**        |       **310,499.8 ns** |      **1,737.74 ns** |      **1,625.48 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10000         | 10000        |     6,759,332.9 ns |     11,340.85 ns |     10,053.36 ns | 21.76 |    0.13 |
| SortedListLookup       | 10000         | 10000        |     6,377,872.4 ns |     17,630.77 ns |     15,629.22 ns | 20.53 |    0.12 |
| HashSetLookup          | 10000         | 10000        |       303,645.6 ns |      1,826.06 ns |      1,708.10 ns |  0.98 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10000**         | **100000**       |     **3,283,005.3 ns** |     **10,897.60 ns** |     **10,193.62 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10000         | 100000       |    67,951,936.6 ns |    105,342.26 ns |     93,383.17 ns | 20.69 |    0.06 |
| SortedListLookup       | 10000         | 100000       |    64,106,964.2 ns |    204,318.03 ns |    191,119.21 ns | 19.53 |    0.09 |
| HashSetLookup          | 10000         | 100000       |     3,193,270.3 ns |      6,404.81 ns |      5,677.70 ns |  0.97 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **10000**         | **1000000**      |    **33,254,185.8 ns** |     **78,808.67 ns** |     **73,717.68 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 10000         | 1000000      |   681,830,883.3 ns |  1,970,341.84 ns |  1,538,313.31 ns | 20.50 |    0.08 |
| SortedListLookup       | 10000         | 1000000      |   621,914,621.4 ns |  2,900,587.69 ns |  2,571,295.44 ns | 18.70 |    0.10 |
| HashSetLookup          | 10000         | 1000000      |    32,272,944.2 ns |    125,571.05 ns |    104,857.52 ns |  0.97 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100000**        | **10**           |           **139.7 ns** |          **0.30 ns** |          **0.28 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100000        | 10           |         7,893.7 ns |          8.85 ns |          8.28 ns | 56.52 |    0.13 |
| SortedListLookup       | 100000        | 10           |         6,384.7 ns |          5.52 ns |          4.61 ns | 45.71 |    0.09 |
| HashSetLookup          | 100000        | 10           |           136.6 ns |          0.26 ns |          0.21 ns |  0.98 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100000**        | **100**          |         **1,827.0 ns** |          **0.91 ns** |          **0.76 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100000        | 100          |        80,938.0 ns |        472.22 ns |        418.61 ns | 44.28 |    0.22 |
| SortedListLookup       | 100000        | 100          |        77,096.0 ns |        543.17 ns |        508.08 ns | 42.21 |    0.29 |
| HashSetLookup          | 100000        | 100          |         1,758.5 ns |          2.10 ns |          1.86 ns |  0.96 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100000**        | **1000**         |        **27,996.3 ns** |        **176.21 ns** |        **137.57 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100000        | 1000         |       967,989.6 ns |      2,059.04 ns |      1,926.03 ns | 34.57 |    0.18 |
| SortedListLookup       | 100000        | 1000         |       944,606.1 ns |      2,515.14 ns |      2,229.61 ns | 33.74 |    0.18 |
| HashSetLookup          | 100000        | 1000         |        24,465.8 ns |        118.00 ns |        110.38 ns |  0.87 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100000**        | **10000**        |       **498,511.5 ns** |        **929.09 ns** |        **823.61 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100000        | 10000        |     9,894,803.2 ns |     35,215.79 ns |     32,940.87 ns | 19.86 |    0.05 |
| SortedListLookup       | 100000        | 10000        |     9,667,117.1 ns |     70,662.35 ns |     66,097.60 ns | 19.37 |    0.11 |
| HashSetLookup          | 100000        | 10000        |       518,421.2 ns |      2,568.10 ns |      2,402.20 ns |  1.04 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100000**        | **100000**       |     **5,325,098.6 ns** |     **44,100.68 ns** |     **41,251.80 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100000        | 100000       |    99,968,246.4 ns |    917,497.76 ns |    813,337.87 ns | 18.77 |    0.19 |
| SortedListLookup       | 100000        | 100000       |   100,925,071.8 ns |  1,932,877.19 ns |  1,614,039.99 ns | 18.98 |    0.28 |
| HashSetLookup          | 100000        | 100000       |     5,407,806.9 ns |     37,246.94 ns |     34,840.81 ns |  1.02 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **100000**        | **1000000**      |    **55,295,561.9 ns** |  **1,082,257.06 ns** |  **1,288,350.05 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 100000        | 1000000      | 1,002,250,771.4 ns | 18,193,279.38 ns | 16,127,868.29 ns | 18.03 |    0.51 |
| SortedListLookup       | 100000        | 1000000      |   988,917,460.0 ns | 17,093,021.65 ns | 15,988,823.06 ns | 17.79 |    0.62 |
| HashSetLookup          | 100000        | 1000000      |    56,681,013.3 ns |  1,116,241.47 ns |  1,670,737.68 ns |  1.03 |    0.04 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000000**       | **10**           |           **150.7 ns** |          **0.45 ns** |          **0.42 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000000       | 10           |         9,357.5 ns |          6.71 ns |          5.95 ns | 62.09 |    0.17 |
| SortedListLookup       | 1000000       | 10           |         8,799.1 ns |         16.15 ns |         14.32 ns | 58.39 |    0.20 |
| HashSetLookup          | 1000000       | 10           |           142.3 ns |          0.24 ns |          0.20 ns |  0.94 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000000**       | **100**          |         **1,800.4 ns** |          **1.38 ns** |          **1.22 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000000       | 100          |       102,582.4 ns |      1,062.92 ns |        994.25 ns | 57.02 |    0.52 |
| SortedListLookup       | 1000000       | 100          |        98,563.0 ns |        576.68 ns |        539.43 ns | 54.72 |    0.28 |
| HashSetLookup          | 1000000       | 100          |         1,882.9 ns |          2.02 ns |          1.69 ns |  1.05 |    0.00 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000000**       | **1000**         |        **59,234.4 ns** |        **291.07 ns** |        **258.02 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000000       | 1000         |     1,338,549.8 ns |      4,098.05 ns |      3,833.32 ns | 22.59 |    0.10 |
| SortedListLookup       | 1000000       | 1000         |     1,433,400.4 ns |      6,193.63 ns |      5,793.52 ns | 24.20 |    0.16 |
| HashSetLookup          | 1000000       | 1000         |        60,440.6 ns |        566.63 ns |        473.16 ns |  1.02 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000000**       | **10000**        |       **728,404.1 ns** |      **3,034.53 ns** |      **2,690.03 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000000       | 10000        |    14,369,042.7 ns |    286,021.94 ns |    329,383.29 ns | 19.81 |    0.49 |
| SortedListLookup       | 1000000       | 10000        |    15,174,195.2 ns |    208,024.31 ns |    162,411.70 ns | 20.83 |    0.24 |
| HashSetLookup          | 1000000       | 10000        |       774,758.9 ns |      4,488.74 ns |      4,198.77 ns |  1.06 |    0.01 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000000**       | **100000**       |    **12,868,310.7 ns** |    **256,245.13 ns** |    **534,879.02 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000000       | 100000       |   183,253,624.4 ns |  3,342,081.36 ns |  3,126,184.98 ns | 14.57 |    0.36 |
| SortedListLookup       | 1000000       | 100000       |   187,996,420.0 ns |  2,255,904.16 ns |  2,110,174.15 ns | 14.95 |    0.42 |
| HashSetLookup          | 1000000       | 100000       |    13,104,911.7 ns |    288,279.98 ns |    831,753.66 ns |  1.02 |    0.07 |
|                        |               |              |                    |                  |                  |       |         |
| **DictionaryLookup**       | **1000000**       | **1000000**      |   **164,367,145.2 ns** |  **2,395,139.92 ns** |  **2,123,229.16 ns** |  **1.00** |    **0.00** |
| SortedDictionaryLookup | 1000000       | 1000000      | 1,794,668,884.6 ns | 24,747,592.52 ns | 20,665,360.58 ns | 10.92 |    0.22 |
| SortedListLookup       | 1000000       | 1000000      | 1,904,261,067.6 ns | 33,123,617.88 ns | 56,246,417.01 ns | 11.78 |    0.42 |
| HashSetLookup          | 1000000       | 1000000      |   170,670,665.2 ns |  3,349,947.67 ns |  4,114,036.58 ns |  1.04 |    0.03 |
