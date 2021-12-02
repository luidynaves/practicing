using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 12321, 1232, 10, 1 };

            foreach (var number in numbers)
            {
                Console.WriteLine($"Is {number} a Palindrome? {IsPalindrome(number)}");
            }

            Console.ReadLine();
        }

        static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int revertedNumber = 0;

            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
