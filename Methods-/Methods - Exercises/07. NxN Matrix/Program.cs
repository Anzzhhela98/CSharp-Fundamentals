using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNbyNnumbers(n);
        }
        static void PrintNbyNnumbers(int num)
        {
            for (int i = 0; i < num; i++)
            {               
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
