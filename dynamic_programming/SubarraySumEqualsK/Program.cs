using System;
using System.Collections.Generic;

namespace SubarraySumEqualsK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subarray Sum Equals K");
            int[] array = { 3, 4, 7, 2, -3, 1, 4, 2 };
            
            Console.WriteLine(SubarraySum(array, 7));

            Console.ReadLine();
        }

        public static int SubarraySum(int[] nums, int k)
        {
            var total = 0;
            var sum = 0;
            var countingNumbers = new Dictionary<int, int>();

            countingNumbers.Add(0, 1);

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (countingNumbers.ContainsKey(sum - k))
                {
                    total += countingNumbers[sum - k];
                }

                countingNumbers[sum] = countingNumbers.GetValueOrDefault(sum, 0) + 1;
            }

            return total;
        }
    }
}
