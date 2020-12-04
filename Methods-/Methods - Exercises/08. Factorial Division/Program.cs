using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorialOfEachNumber(firsNum, secondNum));
        }
        static int CalculateFactorialOfEachNumber(int first, int second)
        {
            int firstResult = first;
            for (int i = 1; i < first; i++)
            {
                firstResult *= first - i;
            }
            int secondResult = second;
            for (int i = 1; i < second; i++)
            {
               secondResult *= second - i;
            }

            return firstResult /secondResult;
           
        }
    }
}
