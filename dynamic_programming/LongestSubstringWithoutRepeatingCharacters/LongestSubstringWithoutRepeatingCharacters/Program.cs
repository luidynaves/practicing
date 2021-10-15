using System;
using System.Collections;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inputs = new Dictionary<string, int>();
            inputs.Add("au", 2);
            inputs.Add(" ", 1);
            inputs.Add("  ", 1);
            inputs.Add("abcabcbb", 3);
            inputs.Add("bbbbb", 1);
            inputs.Add("pwwkew", 3);
            inputs.Add("", 0);
            inputs.Add("dvdf", 3);
            inputs.Add("anviaj", 5);
            inputs.Add("anviajia", 5);
            inputs.Add("wobgrovw", 6);

            foreach (var input in inputs)
            {
                Console.WriteLine($"{input.Key}, Expected: {input.Value} - {LengthOfLongestSubstring(input.Key)}");
            }

            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring2(string s)
        {
            if (s == "" || s.Length == 1)
                return s.Length;

            string result = "";

            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (result.Contains(s[i]))
                    result = result.Substring(result.IndexOf(s[i]) + 1);

                result += s[i];
                max = Math.Max(max, result.Length);
            }

            return max;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (s == "")
                return 0;

            if (s.Length == 1)
                return 1;

            Dictionary<char, int> exist = new Dictionary<char, int>();
            int output = -1;
            int currentLength = 0;
            int lastRemoved = -1;


            for (int i = 0; i < s.Length; i++)
            {
                if (exist.ContainsKey(s[i]) && exist[s[i]] > lastRemoved)
                {
                    if (output < currentLength)
                        output = currentLength;

                    lastRemoved = exist[s[i]];
                    currentLength = i - lastRemoved - 1;
                    exist.Remove(s[i]);
                }

                if (exist.ContainsKey(s[i]) && exist[s[i]] < lastRemoved)
                    exist[s[i]] = i;
                else
                    exist.Add(s[i], i);
                currentLength++;
            }

            return Math.Max(output, currentLength);
        }
    }
}
