using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;


            while (input != "special" && input != "regular")
            {

                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPrice += price;

                }

                input = Console.ReadLine();
            }

            double taxes = totalPrice * 0.20;
            double finalPrice = taxes + totalPrice;
            if (input == "special")
            {
                finalPrice *= 0.90;

            }
            if (finalPrice == 0d)
            {
                Console.WriteLine("Invalid order!");
            }

            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$ ");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");

            }

        }
    }
}