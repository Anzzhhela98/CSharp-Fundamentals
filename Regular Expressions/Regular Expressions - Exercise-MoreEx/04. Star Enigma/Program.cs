using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string patternLetters = "[STRAstra]";
            Regex checkCount = new Regex(patternLetters);
            string pattern = @"@(?<planet>[A-Za-z]+)[^:@!-]*\d*:(\d+)[^:@!-]*!(?<type>[A,D])![^:@!-]*->(\d+)";
            Regex checkInfo = new Regex(pattern);

            Dictionary<string, List<string>> dictPalnet = new Dictionary<string, List<string>>()
            {
                ["Attacked"] = new List<string>(),
                ["Destroyed"] = new List<string>(),

            };
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection letters = checkCount.Matches(input);
                int num = letters.Count;
                StringBuilder firstStageDecrypt = new StringBuilder();
                for (int l = 0; l < input.Length; l++)
                {
                    firstStageDecrypt.Append((char)(input[l] - num));

                }
                string newInfo = firstStageDecrypt.ToString();

                Match decryptInfo = checkInfo.Match(newInfo);
                if (decryptInfo.Success)
                {
                    string type = decryptInfo.Groups["type"].Value;
                    string planet = decryptInfo.Groups["planet"].Value;
                    if (type == "A")
                    {
                        dictPalnet["Attacked"].Add(planet);
                    }
                    else
                    {

                        dictPalnet["Destroyed"].Add(planet);

                    }
                }

            }

            foreach (var planet in dictPalnet)
            {
                Console.WriteLine($"{planet.Key} planets: {planet.Value.Count}");
                foreach (var planets in planet.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planets}");
                }
            }

        }
    }
}
