using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Length % 2 == 0)
            {
                Console.WriteLine(FindMiddleCharactersOfEvenString(str));
            }
            else
            {
                Console.WriteLine(FindMiddleCharactersOfOddString(str));
            }

        }
        static string FindMiddleCharactersOfEvenString(string str)
        {
            int index = str.Length / 2;
            string chars = str.Substring(index - 1, 2);
            return chars;
        }
        static  string FindMiddleCharactersOfOddString(string str)
        {
            int index = str.Length / 2;
            string chars = str.Substring(index , 1);
            return chars;
        }
    }
}
