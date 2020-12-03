using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragons =
                new Dictionary<string, SortedDictionary<string, int[]>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split(" ");
                string type = splitted[0];
                string name = splitted[1];
                var damage = 0;
                var health = 0;
                var armor = 0;
                damage = splitted[2] == "null" ? 45 : int.Parse(splitted[2]);
                health = splitted[3] == "null" ? 250 : int.Parse(splitted[3]);
                armor = splitted[4] == "null" ? 10 : int.Parse(splitted[4]);

                AddDragons(dragons, type, name, damage, health, armor);

            }

            PrintDragons(dragons);

        }

        private static void AddDragons(Dictionary<string, SortedDictionary<string, int[]>> dragons, string type, string name, int damage, int health, int armor)
        {
            if (!dragons.ContainsKey(type))
            {
                dragons.Add(type, new SortedDictionary<string, int[]>());
            }
            if (!dragons[type].ContainsKey(name)) // създаваме нов дракон 
            {
                dragons[type][name] = new int[3];
            }
            dragons[type][name][0] = damage;
            dragons[type][name][1] = health;
            dragons[type][name][2] = armor;
        }

        private static void PrintDragons(Dictionary<string, SortedDictionary<string, int[]>> dragons)
        {
            foreach (var kvp in dragons)
            {
                Console.WriteLine($"{kvp.Key}::" +
                         $"({kvp.Value.Select(x => x.Value[0]).Average():f2}" +
                         $"/{kvp.Value.Select(x => x.Value[1]).Average():f}" +
                         $"/{kvp.Value.Select(x => x.Value[2]).Average():f})");
                foreach (var line in kvp.Value)
                {
                    Console.WriteLine($"-{line.Key} -> damage: {line.Value[0]}, health: {line.Value[1]}, armor: {line.Value[2]} ");
                }
            }
        }
    }
}