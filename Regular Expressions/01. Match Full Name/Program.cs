using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b(?<FirstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)\b");

            string names = Console.ReadLine();
            var matches = pattern.Matches(names);
            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
