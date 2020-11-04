using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           
        
            for (int i = 1; i <= n; i++)
            {

                int digitOfSum = 0;
                int number = i;
                while (number > 0)

                {
                    digitOfSum += number % 10;
                    number /= 10;
                }
               
               bool isTrue = digitOfSum == 5 || digitOfSum == 7 || digitOfSum == 11;

                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}
