using System;
using System.Linq;

namespace CheckExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = Console
                           .ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            while (arrNum.Length != 1)
            {
                int[] condensed = new int[arrNum.Length - 1];
                for (int i = 0; i < arrNum.Length - 1; i++)
                {

                    condensed[i] = arrNum[i] + arrNum[i + 1];

                }
                arrNum = condensed;
            }
            Console.WriteLine(String.Join(" ", arrNum));



        }
    }
}
