using System;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permutation Output:");

            Permutation(string.Empty, "123");

            Console.ReadKey();
        }

        static void Permutation(string perm, string word)
        {
            if (string.IsNullOrEmpty(word))
                Console.WriteLine(perm);
            else
            {
                for (int index = 0; index < word.Length; index++)
                {
                    string zeroSubstring = word.Substring(0, index);
                    string indexSubstring = word.Substring(index + 1);
                    Permutation(perm + word[index], zeroSubstring + indexSubstring);
                }
            }
        }
    }
}

//QUICK MANUAL DEBUG

// word = 123
// perm = ""
//index = 0
//zeroSubstring = "" (from zero to index = 0)
//indexSubstring = 23 (from 1 to word.Length)
//wordIndex = 1 (word[index = 0])
//Permutation("" + 1, "" + 23)
        //word = 23
        //perm = 1
        //index = 0
        //zeroSubstring = "" (from zero to index = 0)
        //indexSubstring = 3 (from 1 to word.Length)
        //wordIndex = 2 (word[index = 0])
        //Permutation(1 + 2, "" + 3)
            //word = 3
            //perm = 12
            //index = 0
            //zeroSubstring = "" (from zero to index = 0)
            //indexSubstring = "" (from 1 to word.Length)
            //wordIndex = 3 (word[index = 0])
            //Permutation(12 + 3, "" + "")
                //word = ""
                //perm = 123
                //=======================> PRINT 123
        //word = 23
        //perm = 1
        //index = 1
        //zeroSubstring = 2 (from zero to index = 1)
        //indexSubstring = "" (from 2 to word.Length)
        //wordIndex = 3 (word[index = 1])
        //Permutation(1 + 3, 2 + "")
            //word = 2
            //perm = 13
            //index = 0
            //zeroSubstring = "" (from zero to index = 1)
            //indexSubstring = "" (from 1 to word.Length)
            //wordIndex = 2 (word[index = 0])
            //Permutation(13 + 2, "" + "")
                //word = ""
                //perm = 132
                //=======================> PRINT 132