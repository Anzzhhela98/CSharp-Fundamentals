using System;

namespace _02._Practice_Floating_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            //3.141592653589793238

            double num2 = double.Parse(Console.ReadLine());
            //1.60217657

            decimal num3 = decimal.Parse(Console.ReadLine());
            //7.8184261974584555216535342341
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
