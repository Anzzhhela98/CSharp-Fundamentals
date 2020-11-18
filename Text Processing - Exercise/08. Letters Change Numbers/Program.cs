using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double curRezult = 0;
            double totalRezult = 0;
            for (int i = 0; i < input.Length; i++)
            {
              
                curRezult = 0;

                //A12b s17G
                char first = input[i].ElementAt(0);
                char last = input[i].ElementAt(input[i].Length - 1);
                string digits = new string(input[i].Skip(1).Take(input[i].Length - 2).ToArray());
                double number = double.Parse(digits);
                if (char.IsLower(first)) //*
                {
                    curRezult += number * (first - 96);
                }
                else if (char.IsUpper(first))//:/
                {
                    curRezult += number / (first - 64);
                }
                if (char.IsLower(last)) //+
                {
                    curRezult += (last - 96);
                }
                else if (char.IsUpper(last))//-
                {
                    curRezult -= (last - 64);
                }
                totalRezult += curRezult;

            }
            Console.WriteLine($"{totalRezult:f2}");
        }
    }
}
