using System;

namespace StringsMakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings Make Anagram");

            var result = MakeAnagram("jfdlasnvdakj", "fjdksajnnvaj");
            Console.WriteLine(result);

            Console.ReadLine();
        }

        static int MakeAnagram(string a, string b) 
        {
            int[] letterCounts = new int[26];

            foreach (var c in a.ToCharArray())
            {
                letterCounts[c-'a']++;
            }

            foreach (var c in b.ToCharArray())
            {
                letterCounts[c-'a']--;
            }

            var total = 0;

            foreach (var i in letterCounts)
            {
                total += Math.Abs(i);
            }

            return total;
        }
    }
}
