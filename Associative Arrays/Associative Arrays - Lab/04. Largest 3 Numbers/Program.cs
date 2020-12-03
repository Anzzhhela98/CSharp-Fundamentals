using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console
                       .ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .OrderByDescending(n => n)
                       .Take(3)
                       .ToList();
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
