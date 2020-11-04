using System;

namespace _01.Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintsSign(n);

        }
        static void PrintsSign(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }
    }
}
