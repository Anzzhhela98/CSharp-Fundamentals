using System;
using System.Linq;

namespace CheckExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                          .ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        Console.WriteLine($"{ arr[i]} {arr[j]}");
                        break;
                    }
                }
            }

        }
    }
}






