using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console
                      .ReadLine()
                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(x => x.Trim())
                      .ToList();
            string patternHealth = @"[0-9-+.\/*]+";
            string patternDamage = @"[0-9-+.]+";
            string attack = @"[^\/*]";
            SortedDictionary<string, List<double>> infoDemons = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < input.Count; i++)
            {

                int health = 0;
                string demonLetter = Regex.Replace(input[i], patternHealth, "");
                if (demonLetter.Length == 0)
                {
                    continue;
                }
                foreach (var character in demonLetter)
                {
                    health += (char)character;
                }
                MatchCollection matchDigits = Regex.Matches(input[i], patternDamage);
                double damage = 0;
                foreach (Match num in matchDigits)
                {
                    damage += double.Parse(num.Value);
                }
                string symbols = Regex.Replace(input[i], attack, "");
                foreach (var symbol in symbols)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                infoDemons.Add(input[i], new List<double>());
                infoDemons[input[i]].Add(health);
                infoDemons[input[i]].Add(damage);
            }

            foreach (var demon in infoDemons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }




        }
    }
}
