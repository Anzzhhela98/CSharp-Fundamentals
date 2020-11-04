using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n ; i++)
            {
                int digitSum = 0;
                int number = i;
                while (number>0)
                {
                    digitSum += number % 10;
                    number /=10;
                }
              
                bool isSpecial = digitSum == 5 || digitSum == 7 || digitSum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
           
        }
    }
}
