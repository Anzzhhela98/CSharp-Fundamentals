using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();
            for (int i = 0; i < words.Length; i++)
            {
                text = text.Replace(words[i], new string('*', words[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
