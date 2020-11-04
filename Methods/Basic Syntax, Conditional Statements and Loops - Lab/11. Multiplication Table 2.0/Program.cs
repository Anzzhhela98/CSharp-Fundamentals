using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int Startimes = int.Parse(Console.ReadLine());

            int sum = 0;
            if (Startimes > 10)
            {
                Console.WriteLine($"{num} X {Startimes} = {num * Startimes}");
                return;
            }
            for (int i = Startimes; i <= 10; i++)
            {



                Console.WriteLine($"{num} X {i} = {num * i}");




            }
        }
    }
}
