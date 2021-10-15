using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARE ANAGRAMS?");

            Console.WriteLine(AreAnagram("abcd", "abcd"));
            Console.WriteLine(100 ^ 45);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        // Function to check whether two strings are anagram of  
        // each other  
        static bool AreAnagram(String str1, String str2)
        {
            // If two strings have different length  
            if (str1.Length != str2.Length)
            {
                return false;
            }

            // To store the xor value  
            int value = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                value = value ^ (int)str1[i];
                value = value ^ (int)str2[i];
            }

            return value == 0;

        }
    }
}
