using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            char symbol = (char)0;
            for (int i = start; i <=finish; i++)
            {
                symbol = (char)i;
                Console.Write(symbol + " ");
            }

        }
    }
}
