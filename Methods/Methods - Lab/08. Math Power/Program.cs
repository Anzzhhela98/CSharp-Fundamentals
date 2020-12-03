using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double mathPow = double.Parse(Console.ReadLine());
            RaiseToPower(num, mathPow);

        }
        static void RaiseToPower(double num, double mathPow)
        {
            Console.WriteLine($"{Math.Pow(num, mathPow)}");
        }
    }
}
