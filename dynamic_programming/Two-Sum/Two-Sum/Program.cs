using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void TwoSum()
        {
            var input = new List<int> { 1, 4, 10, -3 };
            var target = 14;

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] + input[j] == target)
                    {
                        Console.WriteLine($"{i} - {j}");
                        break;
                    }
                }
            }
        }

        public static void TwoSum()
        {
            var input = new List<int> { 1, 4, 10, -3 };
            var target = 14;

            var result = new Dictionary<int, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (result.ContainsKey(input[i]))
                {
                    Console.WriteLine($"{result[input[i]]} - {i}");
                    break;
                }

                result.Add(target - input[i], i);
            }
        }
    }
}
