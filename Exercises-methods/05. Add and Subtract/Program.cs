using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3= int.Parse(Console.ReadLine());
            Console.WriteLine(SubstractTrhird(num1,num2,num3));

        }
        static int SumFirstAndSecond(int num1, int num2)
        {
            int sum = num2 + num1;
            return sum;
        }
        static int SubstractTrhird( int num1,int num2, int num3)
        {
            
            return SumFirstAndSecond(num1, num2)-num3;
        }
    }
}
