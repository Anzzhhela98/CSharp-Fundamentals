using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int tempNum = num;
            string strNum = "";
            strNum += num;
            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = tempNum / 10;

                int factorial = 1;

                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
