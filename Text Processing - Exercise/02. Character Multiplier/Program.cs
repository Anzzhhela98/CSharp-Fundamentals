using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console
                          .ReadLine()
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .ToList();
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }
        static int CharMultiplier(string first, string second)
        {
            int sum = 0;
            string longest = string.Empty;
            string shortest = string.Empty;
            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }
            for (int i = 0; i < shortest.Length; i++)
            {
                sum += longest[i] * shortest[i];
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }
            return sum;
        }
    }
}
