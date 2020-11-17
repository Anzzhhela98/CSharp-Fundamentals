using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = string.Empty; ;
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isOver = true;
            while (isOver)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                GoTrueItems(ref type, materials, junk, ref isOver, input);
            }
            materials = PrintFarming(type, materials, junk);
        }

        private static void GoTrueItems(ref string type, Dictionary<string, int> materials, Dictionary<string, int> junk, ref bool isOver, string[] input)
        {
            for (int i = 0; i < input.Length; i += 2)
            {
                string item = input[i + 1].ToLower();
                int points = int.Parse(input[i]);
                switch (item)
                {
                    case "shards":
                    case "fragments":
                    case "motes":
                        materials[item] += points;
                        break;
                    default:
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, 0);
                        }
                        junk[item] += points;
                        break;
                }
                if (materials.Any(kvp => kvp.Value >= 250))
                {
                    if (item == "shards")
                    {
                        type = "Shadowmourne";
                    }
                    if (item == "fragments")
                    {
                        type = "Valanyr";
                    }
                    else
                    {
                        type = "Dragonwrath";
                    }
                    materials[item] -= 250;
                    isOver = false;
                    break;
                }

            }
        }
        private static Dictionary<string, int> PrintFarming(string type, Dictionary<string, int> materials, Dictionary<string, int> junk)
        {
            Console.WriteLine($"{type} obtained!");
            materials = materials
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(n => n.Key)
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            return materials;
        }
    }
}
