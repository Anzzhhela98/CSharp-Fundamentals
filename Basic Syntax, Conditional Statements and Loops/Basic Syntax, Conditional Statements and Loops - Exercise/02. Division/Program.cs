using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int value = 0;
            if (num%10==0)
            {
                value = 10;
            }
            else if (num % 7 == 0)
            {
                value = 7;
            }
            else if (num % 6 == 0)
            {
                value = 6;
            }
            else if (num % 3 == 0)
            {
                value = 3;
            }
            else if (num % 2 == 0)
            {
                value = 2;
            }
            if (value>0)
            {
                Console.WriteLine($"The number is divisible by {value}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            
        }
    }
}
