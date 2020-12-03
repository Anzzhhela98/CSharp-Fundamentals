using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            PrintingTriangle(nums);
        }
        static void PrintLine(int edn)
        {
            for (int i = 1; i <= edn; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
        static void PrintingTriangle(int nums)
        {
            for (int i = 1; i <= nums; i++)
            {
                PrintLine(i);
            }
            for (int i = nums - 1; i >= 1; i--)
            {
                PrintLine(i);
            }

        }


    }
}
