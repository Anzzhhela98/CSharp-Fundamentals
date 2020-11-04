using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            double[] arr = new double[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(input[i]);

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 0;
                }
                Console.WriteLine($"{arr[i]} => {(int)Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
