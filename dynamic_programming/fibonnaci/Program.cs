using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace fibonnaci
{
    class Program
    {
        static int calculating;
        static Dictionary<int, int> calculatedFibonaccis;

        static void Main(string[] args)
        {
            Console.WriteLine("type wanted fibonacci number:");
            int n = Convert.ToInt32(Console.ReadLine());

            CallFibonacci(n);

            CallFibonacciDynamicProgramming(n);

            Console.ReadKey();
        }

        #region Fibonacci

        private static void CallFibonacci(int n)
        {
            calculating = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int fibonacci = Fibonacci(n);
            stopwatch.Stop();

            Console.WriteLine($"Fibonacci of {n} => {fibonacci} - {calculating} Number of iterations - time: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static int Fibonacci(int n)
        {
            calculating++;
            if (n < 2)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        #endregion

        #region Fibonacci Dynamic Programming

        private static void CallFibonacciDynamicProgramming(int n)
        {
            calculatedFibonaccis = new Dictionary<int, int>();
            calculating = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int dynamicFibonnaci = FibonacciDynamicProgramming(n);
            stopwatch.Stop();

            Console.WriteLine($"DP - Fibonacci of {n} => {dynamicFibonnaci} - {calculating} Number of iterations - time: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static int FibonacciDynamicProgramming(int n)
        {
            if (calculatedFibonaccis.ContainsKey(n))
                return calculatedFibonaccis[n];

            calculating++;
            if (n < 2)
                return n;

            int value = FibonacciDynamicProgramming(n - 1) + FibonacciDynamicProgramming(n - 2);
            calculatedFibonaccis.Add(n, value);
            return calculatedFibonaccis[n];
        }

        #endregion
    }
}
