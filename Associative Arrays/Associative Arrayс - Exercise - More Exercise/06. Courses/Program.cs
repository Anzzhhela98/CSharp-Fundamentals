using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> informatonList = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] spllited = input.Split(" : ");
                string course = spllited[0];
                string name = spllited[1];
                if (!informatonList.ContainsKey(course))
                {
                    informatonList[course] = new List<string>();
                    informatonList[course].Add(name);
                }
                else
                {
                    informatonList[course].Add(name);
                }
            }
            foreach (var item in informatonList.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var name in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
