using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console
                          .ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
            bool isNotContains = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                       
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        isNotContains = true;
                    }
                    

                }

            }
            if (!isNotContains)
            {
                Console.WriteLine("No");
            }
        }
    }
}
