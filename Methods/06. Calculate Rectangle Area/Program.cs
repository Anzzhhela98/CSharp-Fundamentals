using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            PrintRectangleArea(width, height);
        }
        static void PrintRectangleArea(int width, int height)
        {
            Console.WriteLine(width * height);
        }
       
    }
}
