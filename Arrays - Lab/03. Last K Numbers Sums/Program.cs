using System;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            LastKNumbersSumsSequence(n, k);
        }

        static void LastKNumbersSumsSequence(int n, int k)
        {

            var num = new long[n];
            num[0] = 1;
            for (int i = 0; i < n; i++)
            {
                long sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                {

                    if (prev >= 0)
                    {
                        sum += num[prev];
                        num[i] = sum;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(num[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
