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
            int substrac = int.Parse(Console.ReadLine());
            string input = string.Empty;
            StringBuilder message = new StringBuilder();

            string pattern = @"@(?<name>[A-Za-z]+)[^\@\!\:\>\-]*!(?<type>[G|N]{1})!";

            List<string> names = new List<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                foreach (var character in input)
                {
                    message.Append((char)(character - substrac));
                }


                Match match = Regex.Match(message.ToString(), pattern);

                if (match.Groups["type"].Value == "G")
                {
                    names.Add(match.Groups["name"].Value);
                }

                message.Clear();


            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
