using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Legendary_Farming_
{
    class Program
    {
        static void Main(string[] args)
        {

            string activationKey = Console.ReadLine();
            StringBuilder keys = new StringBuilder();
            keys = keys.Append(activationKey);
            string input;

            int startIndex = 0;
            int endIndex = 0;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] splitted = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                switch (splitted[0])
                {
                    case "Contains":
                        string substring = splitted[1];   //?
                        activationKey = keys.ToString();
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        startIndex = int.Parse(splitted[2]);
                        endIndex = int.Parse(splitted[3]);
                        if (splitted.Contains("Upper"))
                        {
                            ChangeToUpper(keys, startIndex, endIndex);
                        }
                        else
                        {
                            ChangeToLower(keys, startIndex, endIndex);
                        }
                        Console.WriteLine(keys);
                        break;
                    case "Slice":
                        startIndex = int.Parse(splitted[1]);
                        endIndex = int.Parse(splitted[2]);
                        int legth = endIndex - startIndex;
                        keys.Remove(startIndex, legth);
                        Console.WriteLine(keys);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {keys}");

        }

        private static void ChangeToLower(StringBuilder keys, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                char currWord = keys[i];
                keys.Remove(i, 1);
                keys.Insert(i, Char.ToLower(currWord));
            }
        }

        private static void ChangeToUpper(StringBuilder keys, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                char currWord = keys[i];
                keys.Remove(i, 1);
                keys.Insert(i, Char.ToUpper(currWord));
            }
        }
    }
}

