using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHas = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());


            double costLightsaber = lightsabersPrice * (Math.Ceiling(countStudents * 1.1));
            double costRobes = robesPrice * countStudents;
            double costBelts = beltsPrice * countStudents;
            for (int i = 1; i <= countStudents; i++)
            {
                if (i % 6 == 0)
                {
                    costBelts -= beltsPrice;
                }
            }

            double neededMoney = costBelts + costLightsaber + costRobes;

            if (moneyHas >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else if (moneyHas < neededMoney)
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney - moneyHas:F2}lv more.");
            }

        }
    }
}
