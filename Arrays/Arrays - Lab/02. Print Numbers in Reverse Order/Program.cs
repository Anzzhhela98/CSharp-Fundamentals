using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;
            }
            for (int i = numbers.Length; i > 0; i--)
            {
                Console.Write(numbers[i - 1] + " ");
            }

            double name = double.Parse(Console.ReadLine());


        }
    }
}
