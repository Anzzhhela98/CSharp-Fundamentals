using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ushort giveLiters= 0;
            for (int i = 0; i < n; i++)
            {
                ushort quantities = ushort.Parse(Console.ReadLine());
                
                
                if (giveLiters + quantities> 255)
                {
                   
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    giveLiters += quantities;
                }

            }
            Console.WriteLine(giveLiters);

        }
    }
}
