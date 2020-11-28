using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine();

            Regex regex = new Regex
                (@"\+([359]+)([ |-])2(\2)(\d{3})(\2)(\d{4})\b");

            var matchesNumber = regex.Matches(phoneNumbers);
            var matchedPhones = matchesNumber
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));


        }
    }
}
