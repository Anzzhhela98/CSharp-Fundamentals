using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNum,operators,secondNum));
        }
          static double Calculate (int firstNum, char operators, int secondNum)
        {
            double result =0;
            if (operators == '+')
            {
                result = firstNum + secondNum;
            }
            else if (operators == '*')
            {
                result = firstNum * secondNum;
            }
            else if (operators == '/')
            {
                result = firstNum / secondNum;
            }
            else
            {
                result = firstNum - secondNum;
               
            }
            return  result;
            
        }
    }
}
