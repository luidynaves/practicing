using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort");

            var result = SelectionSort(new int[] { 5, 3, 6, 2, 10 });

            foreach (var item in result)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadKey();
        }

        static int FindSmallest(int[] arr, int j)
        {
            var smallest = arr[j];
            var smallestIndex = j;

            for (int i = j + 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }

        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallestIndex = i;
                if (i + 1 != arr.Length)
                    smallestIndex = FindSmallest(arr, i);

                int temp = arr[i];
                arr[i] = arr[smallestIndex];
                arr[smallestIndex] = temp;
            }

            return arr;
        }
    }
}
