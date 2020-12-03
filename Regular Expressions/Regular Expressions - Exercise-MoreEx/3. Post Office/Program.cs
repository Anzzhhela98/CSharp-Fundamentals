using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"(\$[A-Z]+\$|#[A-Z]+#|\*[A-Z]+\*|&[A-Z]+&|%[A-Z]+%)";
            string secondPattern = @"(?<asciCode>[0-9]{2}):(?<lenght>[0-9]{2})";
            string thirdPattern = @"[A-Za-z]+";

            List<string> text = Console
                      .ReadLine()
                      .Split("|")
                      .ToList();
            Match firstPart = Regex.Match(text[0], firstPattern);
            MatchCollection secondPart = Regex.Matches(text[1], secondPattern);
            MatchCollection thirdPart = Regex.Matches(text[2], thirdPattern);

            List<int> num = new List<int>();
            Dictionary<string, int> dictionaries = new Dictionary<string, int>();

            StringBuilder letter = new StringBuilder();
            foreach (Match item in secondPart)
            {

                letter.Append(((char)int.Parse(item.Groups["asciCode"].Value)));
                num.Add(int.Parse(item.Groups["lenght"].Value));
            };
            for (int i = 0; i < letter.Length; i++)
            {
                foreach (Match word in thirdPart)
                {
                    char[] arrayWord = word.Value.ToCharArray();
                    if (letter[i] == arrayWord[0] && word.Value.Length == num[i])
                    {

                    }
                }
            }

        }
    }
}
