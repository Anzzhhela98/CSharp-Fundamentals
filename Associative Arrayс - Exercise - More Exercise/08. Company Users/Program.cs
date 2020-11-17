using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> information = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] entrance = input.Split(" -> ");
                string ID = entrance[1];
                string company = entrance[0];
                if (!information.ContainsKey(company))
                {

                    information[company] = new List<string>();
                    information[company].Add(ID);

                }
                else
                {
                    if (!information[company].Contains(ID))
                    {
                        information[company].Add(ID);
                    }
                }

            }
            foreach (var name in information.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key}");
                for (int i = 0; i < name.Value.Count; i++)
                {
                    Console.WriteLine($"-- {name.Value[i]}");
                }

            }
        }
    }
}
