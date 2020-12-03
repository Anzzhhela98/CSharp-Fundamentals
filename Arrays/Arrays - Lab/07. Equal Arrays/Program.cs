using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondInput = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < firstInput.Length; i++)
            {
                if (firstInput[i] != secondInput[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index ");
                    return;

                }
            }
            int sum = firstInput.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");




        }
    }
}
