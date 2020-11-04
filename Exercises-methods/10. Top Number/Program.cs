using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMasterNumber(n);
        }
        static void PrintMasterNumber(int n)
        {
            for (int i = 17; i < n; i++)
            {
                string curentNum = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var curr in curentNum)
                {
                    int parseNum = (int)curr;
                    if (parseNum % 2 == 1)
                    {
                        isOddDigit = true;

                    }
                    sumOfDigits += parseNum;

                }
                if (isOddDigit && sumOfDigits % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
