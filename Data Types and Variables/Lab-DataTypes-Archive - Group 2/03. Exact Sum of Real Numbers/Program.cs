using System;

namespace _03._Exact_Sum_of_Real_Numbers
{

    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal isValue = 0;
            for (int i = 0; i < n; i++)
            {
                decimal curentNum = decimal.Parse(Console.ReadLine());

                isValue += curentNum;
            }
            Console.WriteLine($"{isValue}");

        }
    }
}
