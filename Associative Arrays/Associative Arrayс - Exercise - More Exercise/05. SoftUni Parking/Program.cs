using System;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string name = input[1];

                switch (command)
                {
                    case "register":
                        string license = input[2];
                        if (!collection.ContainsKey(name))
                        {
                            collection[name] = new List<string>();
                            collection[name].Add(license);
                            Console.WriteLine($"{name} registered {license} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {license}");
                        }
                        break;
                    case "unregister":
                        if (!collection.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            collection.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var license in collection)
            {
                Console.WriteLine($"{license.Key} => {license.Value[0]}");
            }
        }
    }
}
