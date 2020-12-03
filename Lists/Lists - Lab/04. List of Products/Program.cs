using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> sortProduct = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                sortProduct.Add(item);
            }
            sortProduct.Sort();
            for (int i = 0; i < sortProduct.Count; i++)
            {
                Console.WriteLine($"{i+1}.{sortProduct[i]}");
            }
        }

    }
}
