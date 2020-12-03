using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                           .ReadLine()
                           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int index = rnd.Next(0, input.Length);
                string word = input[i];
                input[i] = input[index];
                input[index] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
