using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] first = Console
                          .ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
            int[] second = Console
                          .ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
            GetSumOfArray(first, second);
        }
        static void GetSumOfArray(int[] first, int[] second)
        {
            int largegLength = Math.Max(first.Length, second.Length);
            for (int i = 0; i < largegLength; i++)
            {
                int firstValue = first[i % first.Length];
                int secondValue = second[i % second.Length];
                Console.Write("{0} ", firstValue + secondValue);
            }
        }
    }
}
