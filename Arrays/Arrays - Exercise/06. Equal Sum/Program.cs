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
            for (int curent = 0; curent < arr.Length; curent++)
            {
                int rightSum = 0;
                int leftSum = 0;
                for (int i = curent + 1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }
                for (int k = curent - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(curent);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}






