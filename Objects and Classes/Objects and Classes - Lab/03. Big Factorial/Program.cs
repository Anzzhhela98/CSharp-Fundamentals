using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = CalculateFactoriel(number);
        }

        private static int CalculateFactoriel(int number)
        {
            BigInteger result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            Console.WriteLine(result);
            return number;
        }


    }
}
