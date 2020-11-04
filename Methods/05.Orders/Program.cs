using System;

namespace _01.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            
            if (item == "coffee")
            {
                CoffePrice(quantity);
            }
            else if (item == "water")
            {
                WaterPrice(quantity);
            }
            else if (item == "coke ")
            {
                CokePrice(quantity);
            }
            else if(item=="snacks")
            {
                SnackPrice(quantity);
            }

        }
        static void CoffePrice(double quantity)
        {
            Console.WriteLine($"{quantity * 1.5:F2}");
        }
        static void WaterPrice(double quantity)
        {
            Console.WriteLine($"{quantity * 1.00:F2}");
            
        }
        static void CokePrice(double quantity)
        {
            Console.WriteLine($"{quantity * 1.4:F2}");
        }
        static void SnackPrice(double quantity)
        {
            Console.WriteLine($"{quantity * 2:F2}");
        }
    }
}
