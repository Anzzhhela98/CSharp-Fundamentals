using System;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                string rezult = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    rezult += word[i];
                }
                Console.WriteLine($"{word} = {rezult}");

            }
        }
    }
}
