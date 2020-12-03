using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split();
            StringBuilder rezult = new StringBuilder();

            foreach (var word in words)
            {
                int lenght = word.Length;
                for (int i = 0; i < lenght; i++)
                {
                    rezult.Append(word);
                }

            }
            Console.WriteLine(rezult);
        }
    }
}
