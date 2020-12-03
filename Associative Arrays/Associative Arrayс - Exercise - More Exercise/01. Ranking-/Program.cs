using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string[] splitted;
            Dictionary<string, string> contestPass = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> informations = new SortedDictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "end of contests")
            {
                splitted = input.Split(new string[] { ":", " => " },
                StringSplitOptions.RemoveEmptyEntries);
                string contest = splitted[0];
                string pass = splitted[1];
                if (!contestPass.ContainsKey(contest))
                {
                    contestPass.Add(contest, pass);
                }
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                splitted = input.Split(new string[] { ":", "=>" },
               StringSplitOptions.RemoveEmptyEntries);
                string contest = splitted[0];
                string pass = splitted[1];
                string user = splitted[2];
                int points = int.Parse(splitted[3]);
                if (contestPass.ContainsKey(contest) && contestPass[contest] == pass)
                {
                    if (informations.ContainsKey(user))
                    {
                        if (informations[user].ContainsKey(contest))
                        {
                            if (informations[user][contest] < points)
                            {
                                informations[user][contest] = points;
                            }
                        }
                        else
                        {
                            informations[user].Add(contest, points);
                        }
                    }
                    else
                    {
                        informations.Add(user, new Dictionary<string, int>());
                        informations[user].Add(contest, points);
                    }
                }
            }

            string bestName = string.Empty;
            int bestPoint = 0;
            foreach (var name in informations)
            {
            int point = 0;
                foreach (var namePoint in name.Value.Values)
                {
                    point += namePoint;

                }
                if (point > bestPoint)
                {
                    bestPoint = point;
                    bestName = name.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestName} with total {bestPoint} points.");
            Console.WriteLine("Ranking: ");
            foreach (var item in informations.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
