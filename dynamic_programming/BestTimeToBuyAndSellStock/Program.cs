using System;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfitFaster(new int[] { 10, 1, 5, 3, 9, 4 }));
            Console.WriteLine(MaxProfitFaster(new int[] { 9, 5, 4, 2, 1 }));
            Console.WriteLine(MaxProfitFaster(new int[] { 1, 5 }));
            Console.WriteLine(MaxProfitFaster(new int[] { 9 }));
            Console.ReadKey();
        }

        static int GetMaxProfit(int[] prices)
        {
            if (prices is null || prices.Length < 2)
                return 0;                

            int maxProfit = 0;
            int min = int.MaxValue;

            for (int index = 0; index < prices.Length; index++)
            {
                int price = prices[index];

                if (price < min)
                    min = price;
                else
                    maxProfit = Math.Max(price - min, maxProfit);
            }

            return maxProfit;
        }

        static int MaxProfitFaster(int[] prices)
        {
            if (prices is null || prices.Length < 2)
                return 0;

            int maxDiff = 0;
            int minPrice = int.MaxValue;

            for (int index = 0; index < prices.Length; index++)
            {
                int price = prices[index];

                if (price < minPrice)
                {
                    minPrice = price;
                    continue;
                }

                int currentDiff = price - minPrice;

                if (currentDiff > maxDiff)
                    maxDiff = currentDiff;
            }

            return maxDiff;
        }
    }
}
