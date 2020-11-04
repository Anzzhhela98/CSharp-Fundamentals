using System;

namespace _01._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double  area= (r * r) *pi;
            Console.WriteLine($"{area:f12}");


        }
    }
}
