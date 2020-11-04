using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int givenNumber = int.Parse(Console.ReadLine());

            int[] firstArr = new int[givenNumber];
            int[] secondArr = new int[givenNumber];
            //1      5 
            //9     10 
            for (int i = 0; i < givenNumber; i++)
            {

                int[] arr = Console
                          .ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = arr[0];
                    secondArr[i] = arr[1];
                }
                else
                {
                    firstArr[i] = arr[1];
                    secondArr[i] = arr[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));


        }
    }
}
