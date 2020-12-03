using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        // увеличава ми Value;
        // слага ми Value 1 само
        //  ако е за първи път
        {
            string[] language = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string type in language)
            {
                string wordInLowerCase = type.ToLower();

                if (counts.ContainsKey(type))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(type, 1);
                }
            }

            counts = counts.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key, y => y.Value);
                  Console.WriteLine($"{string.Join(" ", counts.Keys)}"); ;
        }


    }
}
