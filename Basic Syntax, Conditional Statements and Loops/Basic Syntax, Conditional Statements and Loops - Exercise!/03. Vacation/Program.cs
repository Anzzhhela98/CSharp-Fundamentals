using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double sum = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price += 8.45;
                }
                else if (day == "Saturday")
                {
                    price += 9.80;
                }
                else if (day == "Sunday")
                {
                    price += 10.46;
                }
                sum = price * group;
                if (group >= 30)
                {
                    sum *= 0.85;
                }
            }
            if (type == "Business")
            {
                if (day == "Friday")
                {
                    price += 10.9;
                }
                else if (day == "Saturday")
                {
                    price += 15.6;
                }
                else if (day == "Sunday")
                {
                    price += 16;
                }
                if (group >= 100)
                {
                    group -= 10;
                }
                sum = price * group;
            }
            if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price += 15;
                }
                else if (day == "Saturday")
                {
                    price += 20;
                }
                else if (day == "Sunday")
                {
                    price += 22.5;
                }
                sum = price * group;
                if (group >= 10 && group <= 20)
                {
                    sum *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {sum:F2}");


        }
    }
}
