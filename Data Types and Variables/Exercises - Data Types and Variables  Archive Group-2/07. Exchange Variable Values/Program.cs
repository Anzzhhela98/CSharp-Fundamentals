using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            a = 5;
            b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            byte a2 = b;
            byte b2 = a;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a2}");
            Console.WriteLine($"b = {b2}");
        }
    }
}
