using System;
using System.Linq;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                //abv>1>1>2>2asdasd
                if (curr.Equals('>'))
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(curr);
                }
                else if (power == 0)
                {
                    sb.Append(curr);
                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
