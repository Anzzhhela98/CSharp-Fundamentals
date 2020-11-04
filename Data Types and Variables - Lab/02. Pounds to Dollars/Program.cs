using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pouds = decimal.Parse(Console.ReadLine());
            decimal leva = pouds *(decimal) 1.31;
            Console.WriteLine($"{leva:f3}");
        }
    }
}
