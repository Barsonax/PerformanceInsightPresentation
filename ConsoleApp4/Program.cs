using System;
using System.Diagnostics;
using static FibonacciLib.Algorithms;

namespace FibonacciExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var watch = Stopwatch.StartNew();
                var n = 100000;
                var result = Fibonacci1(n);
                //var result = FibonacciLib.FibonacciSequence().Take(n + 1).Last();

                Console.WriteLine($"Result is {result} in {watch.ElapsedMilliseconds} ms");
                Console.WriteLine();
            }
        }
    }
}
