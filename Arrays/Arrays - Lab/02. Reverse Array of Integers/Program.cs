using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ReverseIntegersInArray(n);
        }
        static void ReverseIntegersInArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int first = int.Parse(Console.ReadLine());
                arr[i] = first;
            }
            Array.Reverse(arr);
            Console.WriteLine(String.Join(" ", arr));
        }

       
    }
}
