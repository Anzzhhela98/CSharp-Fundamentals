using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequencesOfChar = Console.ReadLine();

            string patternSymbols = @"(?<word>[^0-9]+)";
            string patternDigits = @"(?<number>[0-9]+)";

            MatchCollection symbols = Regex.Matches(sequencesOfChar, patternSymbols);
            MatchCollection digits = Regex.Matches(sequencesOfChar, patternDigits);

            StringBuilder uniqueSymbols = new StringBuilder();
            List<int> listNum = new List<int>();

            foreach (Match num in digits)
            {
                int number = int.Parse(num.Groups["number"].Value);

                listNum.Add(number);

            };
            int tempCount = 0;
            foreach (Match word in symbols)
            {
                for (int i = 0; i < listNum[tempCount]; i++)
                {
                    uniqueSymbols.Append(word.Value.ToUpper());
                }
                tempCount++;
                if (tempCount == listNum.Count)
                {
                    break;
                }
            }
            int counter = uniqueSymbols.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {counter}");
            Console.WriteLine($"{uniqueSymbols}");
        }



    }
}

