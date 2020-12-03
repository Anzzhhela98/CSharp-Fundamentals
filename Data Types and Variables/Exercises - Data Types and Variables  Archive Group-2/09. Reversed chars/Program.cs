using System;

namespace _09._Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            
            Console.WriteLine($"{thirdLetter}{secondLetter}{firstLetter}");

        }
    }
}
