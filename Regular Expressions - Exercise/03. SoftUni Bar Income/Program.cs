using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @"%([A-Z][a-z]+)%[^.%$|]*<(\w+)>[^.%$|]*\|(\d+)\|[^.%$|]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);
            double totalIncome = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match infoSale = regex.Match(input);

                if (infoSale.Success)
                {
                    double price = int.Parse(infoSale.Groups[3].Value) *
                        double.Parse(infoSale.Groups[4].Value);

                    totalIncome += price;

                    Console.WriteLine($"{infoSale.Groups[1].Value}:" +
                        $" {infoSale.Groups[2].Value} - {price:f2}");
                };
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
