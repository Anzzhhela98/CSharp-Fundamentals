using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            Regex regex = new Regex
                (@"(?<day>\d{2})(?<delimiter>[-.\/])(?<month>[A-Za-z]{3})\k<delimiter>(?<year>\d{4})");
            var rezult = regex.Matches(inputDate);

            foreach (Match info in rezult)
            {
                Console.WriteLine($"Day: " +
                    $"{info.Groups["day"]}, Month: {info.Groups["month"]}, Year: {info.Groups["year"]}");
            }
        }
    }
}
