using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charSentense = str.ToCharArray();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < charSentense.Length; i++)
            {
                if (charSentense[i] == ' ')
                {
                    continue;
                }
                else if (!count.ContainsKey(charSentense[i]))
                {
                    count.Add(charSentense[i], 1);
                }
                else
                {
                    count[charSentense[i]]++;
                }
            }
            foreach (var letter in count)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
