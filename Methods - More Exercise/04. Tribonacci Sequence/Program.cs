using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
                FindFibonacci(n);
            
        }
        static void FindFibonacci(int n)
        {
            int start = 0;
            int firstStart = 0;
            int secondStart = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = start + firstStart + secondStart;
                start = secondStart;
                Console.Write(sum + " ");
            }
          
        }
    
    }
}
