using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (comand == "add")
            {
                Add(firstNum, secondNum);
            }
            else if (comand == "subtract")
            {
                Subtract(firstNum, secondNum);
            }
            else if (comand == "divide")
            {
                Divide(firstNum, secondNum);
            }
            else if (comand == "multiply")
            {
                Multiply(firstNum, secondNum);
            }
        }
        static void Add(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void Subtract(int first, int second)
        {
            Console.WriteLine(first - second);
        }
        static void Divide(int first, int second)
        {
            Console.WriteLine(first / second);
        }
        static void Multiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }
    }
}
