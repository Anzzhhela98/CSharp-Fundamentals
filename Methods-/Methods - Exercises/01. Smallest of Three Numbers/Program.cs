using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            GetSmallestNumbers(firstNum, secondNum, thirdNum);
        }
        static void GetSmallestNumbers(int firstNum, int secondNum, int thirdNum)
        {
            int minValue = int.MaxValue;


            if (firstNum < minValue)
            {
                minValue = firstNum;
            }
            if (secondNum < minValue)
            {
                minValue = secondNum;
            }
            if (thirdNum < minValue)
            {
                minValue = thirdNum;
            }

            Console.WriteLine(minValue);
        }
    }
}
