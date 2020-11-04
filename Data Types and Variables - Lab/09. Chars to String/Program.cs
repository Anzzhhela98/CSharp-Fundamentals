using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterSecon = char.Parse(Console.ReadLine());
            char letterThird = char.Parse(Console.ReadLine());
            string first = "" + letterOne;
            string second = "" + letterSecon;
            string third = "" + letterThird;
            string result = first + second + third;
            Console.WriteLine($"{result}");

            


        }
    }
}
