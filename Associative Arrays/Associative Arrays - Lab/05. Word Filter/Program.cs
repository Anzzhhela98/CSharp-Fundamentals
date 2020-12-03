using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split();
            Console.WriteLine(string.Join("\n", words.Where(x => x.Length % 2 == 0)));

        }
    }
}
