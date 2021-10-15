using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseRobber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HouseRob(new int[] { 3, 5, 1, 3, 4, 5, 1 }));
            Console.WriteLine(HouseRob(new int[] { 3, 1, 2, 5, 4, 2 }));
            Console.ReadKey();
        }

        static int HouseRob(int[] houses)
        {
            int currentMax = 0;
            int prevMax = 0;

            for(int index = 0; index < houses.Length; index++)
            {
                int currentHouse = houses[index];

                int newMax = prevMax + currentHouse;
                prevMax = currentMax;

                if (newMax > currentMax)
                    currentMax = newMax;
            }

            return currentMax;
        }
    }
}
