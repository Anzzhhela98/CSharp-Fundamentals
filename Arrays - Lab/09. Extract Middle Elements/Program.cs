﻿using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = array.Length;
            int[] result;

            if (n == 1)
            {
                result = new int[1];
                result[0] = array[0];
            }
            else if (n % 2 == 0)
            {
                result = new int[2];
                result[0] = array[n / 2 - 1];
                result[1] = array[n / 2];
            }
            else
            {
                result = new int[3];
                result[0] = array[n / 2 - 1];
                result[1] = array[n / 2];
                result[2] = array[n / 2 + 1];
            }

            Console.WriteLine(string.Join(", ", result));
        }
       
    }
}
