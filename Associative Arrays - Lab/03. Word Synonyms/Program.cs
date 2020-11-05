using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                string synonyms = Console.ReadLine();
                if (words.ContainsKey(type))
                {
                    words[type].Add(synonyms);
                }
                else
                {
                    words.Add(type, new List<string>());
                    words[type].Add(synonyms);
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{ word.Key} - {string.Join(", ", word.Value)}");
            }

        }
    }
}
