using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputTickets = Console
                      .ReadLine()
                      .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(x => x.Trim())
                      .ToArray();
            string patternSymbol = @"(\@{6,}|\#{6,}|\^{6,}|\${6,})";
            string countSymbol = @".{10}";
            foreach (var ticket in inputTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                MatchCollection match = Regex.Matches(ticket, countSymbol);
                string left = string.Empty;
                string right = string.Empty;
                for (int i = 0; i < 2; i++)
                {
                    Match matches = Regex.Match(match[i].Value.ToString(), patternSymbol);
                    if (i == 0)
                    {
                        left = matches.Value;
                    }
                    else 
                    {
                        right = matches.Value;
                    }
                }
                int length = Math.Min(left.Length, right.Length);
                left = left.Substring(0, length);
                right = right.Substring(0, length);
                if (length >= 6 && left.Equals(right))
                {
                    char symbol = (char)left[0];

                    if (length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
                        continue;
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
