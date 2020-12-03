using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "END")
            {
                Console.WriteLine(IsPalindrom(input).ToString().ToLower());
                input = Console.ReadLine();
            }

        }
        static bool IsPalindrom(string text)//323
        {
            var reversed = text.Reverse().ToArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (!(text[i] == reversed[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
