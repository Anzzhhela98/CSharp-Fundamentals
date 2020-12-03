using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<item>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quatity>\d+)";
            Regex regex = new Regex(pattern);

            string input = string.Empty;
            double spendMoney = 0;
            List<string> item = new List<string>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match rezult = regex.Match(input);

                if (rezult.Success)
                {
                    spendMoney += double.Parse(rezult.Groups[2].Value)
                                   * int.Parse(rezult.Groups[3].Value);
                    item.Add(rezult.Groups["item"].Value);
                }

            }
            Console.WriteLine($"Bought furniture:");
            foreach (var items in item)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine($"Total money spend: {spendMoney:f2}");
        }
    }
}
