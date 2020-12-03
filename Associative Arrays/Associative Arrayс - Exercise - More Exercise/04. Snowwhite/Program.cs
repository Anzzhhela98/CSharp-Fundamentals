using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var infoDwarfs = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] splitted = input.Split(" <:> ",
                    StringSplitOptions.RemoveEmptyEntries);
                string name = splitted[0];
                string color = splitted[1];
                int physics = int.Parse(splitted[2]);
                if (!infoDwarfs.ContainsKey(color))
                {
                    infoDwarfs.Add(color, new Dictionary<string, int>());
                    infoDwarfs[color].Add(name, physics);
                }
                else
                {
                    if (!infoDwarfs[color].ContainsKey(name))
                    {
                        infoDwarfs[color].Add(name, physics);
                    }
                    else
                    {
                        foreach (var phy in infoDwarfs[color])
                        {
                            if (phy.Value < physics)
                            {
                                infoDwarfs[color][name] = physics;
                                break;
                            }
                        }
                    }
                }
            }
            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var hatColor in infoDwarfs
                .OrderByDescending(x => x.Value.Count))
            {
                foreach (var dwarf in hatColor.Value)
                {

                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);

                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
