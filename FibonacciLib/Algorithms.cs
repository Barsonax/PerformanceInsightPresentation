using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciLib
{
    public static class Algorithms
    {
        public static BigInteger Fibonacci1(int n)
        {
            BigInteger a = 0;
            BigInteger b = 1;

            for (int i = 0; i < n; i++)
            {
                BigInteger temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static IEnumerable<BigInteger> FibonacciSequence()
        {
            BigInteger first = 0;
            BigInteger second = 1;

            // first and second result are always 1.
            yield return first;
            yield return second;

            // this enumerable sequence is bounded by the caller.
            while (true)
            {
                BigInteger current = first + second;
                yield return current;

                // wind up for next number if we're requesting one
                first = second;
                second = current;
            }
        }
    }
}