using System;
using System.Globalization;
using System.Linq;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();


            DateTime day =
            DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            
            Console.WriteLine(day.DayOfWeek);

        }
    }
}
