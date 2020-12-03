using System;

namespace _09._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int value = 0; 
            int number = 0;
            bool isTrue = false;

            for (int i = 1; i <= n; i++)
            {
                number = i;

                while (i > 0)
                {
                    value += i % 10;

                    i = i / 10;
                }

                i isTrue = (value == 5) || (value == 7) || (value == 11);

                Console.WriteLine($"{number} -> {isTrue}");

                value = 0;

                i = number;

            }
        }
    }
}
