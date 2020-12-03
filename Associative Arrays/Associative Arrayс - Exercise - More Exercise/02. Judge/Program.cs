using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var userPoints
                 = new Dictionary<string, Dictionary<string, int>>();

            var allUserPoints
                = new Dictionary<string, int>();
            while ((input = Console.ReadLine()) != "no more time")
            {
                //Pesho -> Algo -> 400 
                string[] command = input.Split(" -> ").ToArray();
                string course = command[1];
                string name = command[0];
                int points = int.Parse(command[2]);
                bool itMust = false;
                if (!userPoints.ContainsKey(course))//if not, add 
                {
                    userPoints[course] = new Dictionary<string, int>();
                    userPoints[course][name] = points;
                    itMust = true;
                }
                else
                {
                    if (!userPoints[course].ContainsKey(name))
                    {
                        userPoints[course][name] = points;
                        itMust = true;
                    }
                    else
                    {
                        int currentPoints = userPoints[course][name];
                        if (currentPoints < points)
                        {
                            userPoints[course][name] = points;
                            points = points - currentPoints;
                            itMust = true;
                        }
                    }
                }
                if (!allUserPoints.ContainsKey(name))
                {
                    allUserPoints[name] = 0;
                }
                if (itMust)
                {
                    allUserPoints[name] += points;
                }
            }
            foreach (var kvp in userPoints)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()} participants");
                int count = 0;
                var sorted = kvp.Value.OrderByDescending(x => x.Value).ThenBy(u => u.Key);
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {item.Key} <::> {item.Value}");
                }
            }
            Console.WriteLine($"Individual standings:");

            int counter = 0;
            foreach (var kvp in allUserPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter++;
                Console.WriteLine($"{counter}. {kvp.Key} -> {kvp.Value}");

            }
        }
    }
}

