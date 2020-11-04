using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] weekDaysCounter = new string[7]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday",
                  "Friday", "Saturday", "Sunday"
            };
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine(days);
            if (days < 1 || days > 7)
            {
                Console.WriteLine("Invalid day!");

            }
            else
            {
                Console.WriteLine(weekDaysCounter[days - 1]);
            }
        
             
                   
        }
    }
}
