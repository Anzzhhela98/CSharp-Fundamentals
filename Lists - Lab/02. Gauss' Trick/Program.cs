using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console
                      .ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            SumListNumbers(list);
        }
        static void SumListNumbers(List<int> list)
        {
            int countList = list.Count / 2;
            
            for (int i = 0; i < countList; i++)
            {
                list[i] += list[list.Count - 1];
                list.Remove( list[list.Count - 1]);

               
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
