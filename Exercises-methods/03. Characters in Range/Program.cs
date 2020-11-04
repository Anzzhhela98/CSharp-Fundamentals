using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintASCIICharacters(start, end);
        }
        static void PrintASCIICharacters(char start, char end)
        {
            if (end < start)
            {
                for (int i = end +1 ; i < start; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }       
        }
    }
}
