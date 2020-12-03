using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listOfNum = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            SumAdjacentNumbers(listOfNum);
        }
        static void SumAdjacentNumbers(List<double> listOfNum)
        {
            for (int i = 0; i < listOfNum.Count - 1; i++)
            {
                if (listOfNum[i] == listOfNum[i + 1])
                {
                    listOfNum[i] += listOfNum[i + 1];
                    listOfNum.RemoveAt(i + 1);
                    i = -1;
                }

            }

            Console.WriteLine(string.Join(" ", listOfNum));
        }
    }
}
