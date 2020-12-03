using System;
using System.Linq;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            Console.WriteLine(MultiplyEvenAndOddDigits(num));
        }
        static int MultiplyEvenAndOddDigits(int num)
        {
            return CalculateDigitsSum(num, 0) * (CalculateDigitsSum(num, 1));
        }
        static int CalculateDigitsSum(int num, int isOdd)
        {
            int sum = 0;
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                int curentDigits = int.Parse(number[i].ToString());
                if (curentDigits % 2 == isOdd)
                {
                    sum += curentDigits;
                }
            }
            return sum;

        }
        //static void Main(string[] args)
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    num = Math.Abs(num);
        //    string result = num.ToString();
        //    GetSumOfEvenOrOddsDigit(result);

        //}
        //static int GetSumOfEvenOrOddsDigit(string number)

        //{
        //    int sumEven = 0;
        //    int sumOdd = 0;
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (int.Parse(number[i].ToString()) % 2 == 0)
        //        {
        //            sumEven += int.Parse(number[i].ToString());
        //        }
        //        else
        //        {
        //            sumOdd += int.Parse(number[i].ToString());
        //        }
        //    }
        //    return GetMultiplyOfEvenAndOdds(sumEven, sumOdd);
        //}
        //static int GetMultiplyOfEvenAndOdds(int resultOne, int resultTwo)
        //{

        //    int result = resultOne * resultTwo;
        //    Console.WriteLine(result);
        //    return result;
        //}

    }
}
