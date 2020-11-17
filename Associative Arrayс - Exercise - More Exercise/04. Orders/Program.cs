using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> collection = new Dictionary<string, List<double>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] splitted = input.Split(" ");
                string item = splitted[0];
                double price = double.Parse(splitted[1]);
                double quantity = double.Parse(splitted[2]);
                if (!collection.ContainsKey(item))
                {
                    collection[item] = new List<double>();

                    collection[item].Add(price);
                    collection[item].Add(quantity);
                }
                else
                {
                    collection[item][0] = price;
                    collection[item][1] += quantity;//?
                }
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
