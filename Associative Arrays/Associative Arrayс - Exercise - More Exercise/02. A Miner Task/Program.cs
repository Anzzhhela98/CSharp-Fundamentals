using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<string> sequance = new List<string>();
            Dictionary<string, int> collection = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "stop")
            {
                sequance.Add(input);

            }
            for (int i = 0; i < sequance.Count; i += 2)
            {
                if (!collection.ContainsKey(sequance[i]))
                {
                    collection.Add(sequance[i], int.Parse(sequance[i + 1]));
                }
                else
                {
                    collection[sequance[i]] += int.Parse(sequance[i + 1]);
                }
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
