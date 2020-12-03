using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            StringBuilder others = new StringBuilder();
            StringBuilder digits = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    word.Append(text[i]);
                }
                else
                {
                    others.Append(text[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(word);
            Console.WriteLine(others);
        }
    }
}
