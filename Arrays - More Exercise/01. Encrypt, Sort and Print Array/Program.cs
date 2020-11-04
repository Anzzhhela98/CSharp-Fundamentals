using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string vowels = "EeUuIiOoAa";
            int sum = 0;

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    char letter = input[j];
                    if (vowels.Contains(letter))
                    {
                        sum += letter * input.Length;
                    }
                    else
                    {
                        sum += letter / input.Length;
                    }
                }
                arr[i] = sum;
                sum = 0;
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
