using System;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hello World!"));

            Console.ReadLine();
        }

        static string Reverse(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            string newString = string.Empty;

            for (int index = str.Length - 1; index > -1; index--)
            {
                newString += str[index];
            }

            return newString;
        }
    }
}
