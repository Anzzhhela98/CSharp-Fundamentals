using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

           

            if (numbers%10==1)
            {
                Console.WriteLine("one");
            }
            if (numbers % 10 == 2)
            {
                Console.WriteLine("two");
            }
            if (numbers % 10 == 3)
            {
                Console.WriteLine("three");
            }
            if (numbers % 10 == 4)
            {
                Console.WriteLine("four");
            }if (numbers%10==5)
            {
                Console.WriteLine("five");
            }
            if (numbers % 10 == 6)
            {
                Console.WriteLine("six");
            }
            if (numbers % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            if (numbers % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            if (numbers % 10 == 9)
            {
                Console.WriteLine("nien");
            }
            if (numbers%10==0)
            {
                Console.WriteLine("zero");
            }


        }
    }
}
