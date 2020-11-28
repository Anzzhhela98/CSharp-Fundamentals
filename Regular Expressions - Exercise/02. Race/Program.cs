using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = "[A-Za-z]+";
            Regex nameRegex = new Regex(patternName);

            string patternDigit = @"\d";
            Regex digitRegex = new Regex(patternDigit);

            Dictionary<string, int> dictionaryInfo = new Dictionary<string, int>();

            List<string> allNames = Console
                         .ReadLine()
                         .Split(", ")
                         .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection nameIsMach = nameRegex.Matches(input);
                string name = string.Join("", nameIsMach);
                int score = 0;
                if (allNames.Contains(name))
                {
                    MatchCollection digitIsMach = digitRegex.Matches(input);
                    foreach (Match digit in digitIsMach)
                    {
                        score += int.Parse(digit.Value);
                    }

                    if (!dictionaryInfo.ContainsKey(name))
                    {
                        dictionaryInfo.Add(name, 0);
                    }
                    dictionaryInfo[name] += score;
                };


            }
            dictionaryInfo = dictionaryInfo
                .OrderByDescending(c => c.Value)
                .ToDictionary(x => x.Key, v => v.Value);
            int count = 1;
            foreach (var kvp in dictionaryInfo)
            {
            string type = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{type} place: {kvp.Key}");
                count++;
                if (count == 4)
                {
                    break;
                }
            }

        }
    }
}
