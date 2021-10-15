using System;

namespace FrequencyOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frequency of Characters");

            Console.WriteLine(printCharWithFreq("geeksforgeeks"));
            Console.ReadLine();
        }

        static int SIZE = 26;

        // function to print the character and its 
        // frequency in order of its occurrence 
        static string printCharWithFreq(String str)
        {
            // size of the string 'str' 
            int n = str.Length;

            // 'freq[]' implemented as hash table 
            int[] freq = new int[SIZE];

            // accumulate freqeuncy of each character 
            // in 'str' 
            for (int i = 0; i < n; i++)
                freq[str[i] - 'a']++;

            string resultValue = string.Empty;

            // traverse 'str' from left to right 
            for (int i = 0; i < n; i++)
            {

                // if frequency of character str.charAt(i) 
                // is not equal to 0 
                if (freq[str[i] - 'a'] != 0)
                {

                    // print the character along with its 
                    // frequency 
                    resultValue += str[i];
                    resultValue += freq[str[i] - 'a'] + " ";

                    // update frequency of str.charAt(i) to 
                    // 0 so that the same character is not 
                    // printed again 
                    freq[str[i] - 'a'] = 0;
                }
            }

            return resultValue;
        }
    }
}
