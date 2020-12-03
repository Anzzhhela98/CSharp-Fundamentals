using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int leftAmount = startingYield;
            int availbleAmount = 0;
            int days = 0;
            while (startingYield >= 100)
            {
                leftAmount -= 26;
                availbleAmount += leftAmount;
                startingYield -= 10;
                days++;
                leftAmount = startingYield;
                if (startingYield<100)
                {
                    availbleAmount -= 26;
                    
                    
                }

            }
            Console.WriteLine(days);
            Console.WriteLine(availbleAmount);

        }
    }
}
