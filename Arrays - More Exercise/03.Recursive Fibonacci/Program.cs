using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < 2; i++)
            {
                if (i==0||i==1)
                {
                    arr[i] = 1;
                }
            }
            for (int i = 1; i < n-1; i++)
            {
                arr[i + 1] = arr[i] + arr[i - 1];
            }
            Console.WriteLine(arr.Length);

        }
    }
}
