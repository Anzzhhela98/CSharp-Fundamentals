using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int starts = int.Parse(Console.ReadLine());
            int ends = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = starts; i <= ends; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
