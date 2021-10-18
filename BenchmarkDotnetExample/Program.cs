using System.Linq;
using System.Numerics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static FibonacciLib.Algorithms;

namespace BenchmarkDotnetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<FibonacciBenchmark>();
        }
    }

    [SimpleJob(baseline: true)]
    [RPlotExporter, RankColumn]
    [CsvMeasurementsExporter]
    [MemoryDiagnoser]
    public class FibonacciBenchmark
    {
        [Params(1000,2000,3000,4000,5000,6000,7000,8000)]
        public int N { get; set; }
        
        [Benchmark]
        public BigInteger Imperative()
        {
            return Fibonacci1(N);
        }
        
        [Benchmark]
        public BigInteger Linq()
        {
            return FibonacciSequence().Take(N + 1).Last();
        }
    }
}