using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console
                            .ReadLine()
                            .ToList();
            for (int i = 0; i < text.Count - 1; i++)
            {
                char first = text[i];
                char last = text[i + 1];
                if (first == last)
                {
                    text.RemoveAt(i);
                    i--;
                }

            }


            Console.WriteLine(string.Join("", text));

        }
    }
}
