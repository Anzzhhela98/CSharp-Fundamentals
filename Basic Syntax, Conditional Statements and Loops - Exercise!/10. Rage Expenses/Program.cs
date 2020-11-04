using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displaPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    rageExpenses += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    rageExpenses += displaPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");


        }
    }
}
