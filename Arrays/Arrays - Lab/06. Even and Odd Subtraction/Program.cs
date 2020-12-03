using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int evenDigits = 0;
            int oddDigits = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]%2==0)
                {
                    evenDigits += input[i];
                }
                else
                {
                    oddDigits += input[i];
                }
            }
            int result = evenDigits - oddDigits;
            Console.WriteLine(result);
        }
    }
}
