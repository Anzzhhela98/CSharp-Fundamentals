using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1)
                {
                    sum += coins;
                }
                else if (coins == 0.2)
                {
                    sum += coins;
                }
                else if (coins == 0.5)
                {
                    sum += coins;
                }
                else if (coins == 1)
                {
                    sum += coins;
                }
                else if (coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();


            }
            string item = Console.ReadLine();
            double productMoney = 0;

            while (item != "End")
            {
                if (item == "Nuts")
                {
                    productMoney = 2;

                }
                else if (item == "Water")
                {
                    productMoney = 0.7;


                }
                else if (item == "Soda")
                {
                    productMoney = 0.8;


                }
                else if (item == "Coke")
                {
                    productMoney = 1.0;


                }
                else if (item == "Crisps")
                {
                    productMoney = 1.5;

                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                if (sum >= productMoney)
                {
                    sum -= productMoney;
                    Console.WriteLine($"Purchased {item.ToLower()}");

                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                item = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
