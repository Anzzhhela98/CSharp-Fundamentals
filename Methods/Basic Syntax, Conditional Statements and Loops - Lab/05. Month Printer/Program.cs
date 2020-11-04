using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounts = int.Parse(Console.ReadLine());
            if (mounts == 1)
            {
                Console.WriteLine("January");
            }
            else if (mounts == 2)
            {
                Console.WriteLine("February");
            }
            else if (mounts == 3)
            {
                Console.WriteLine("March");
            }
            else if (mounts == 4)
            {
                Console.WriteLine("April");
            }
            else if (mounts == 5)
            {
                Console.WriteLine("May");
            }
            else if (mounts == 6)
            {
                Console.WriteLine("June");
            }
            else if (mounts == 7)
            {
                Console.WriteLine("July");
            }
            else if (mounts == 8)
            {
                Console.WriteLine("August");
            }
            else if (mounts == 9)
            {
                Console.WriteLine("September");
            }

            else if (mounts == 10)
            {
                Console.WriteLine("October");
            }
            else if (mounts == 11)
            {
                Console.WriteLine("November");
            }
            else if (mounts == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Ërror!");
            }

        }
    }
}
