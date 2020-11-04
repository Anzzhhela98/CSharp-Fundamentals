using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savingMoney = double.Parse(Console.ReadLine());
            List<int> drumSet = Console
                            .ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            List<int> newDrumSet = new List<int>(drumSet);
            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {

               
                int hitPower = int.Parse(command);
                newDrumSet = newDrumSet
                   .Select(d => d -= hitPower)
                   .ToList();

                while (newDrumSet.Any(d => d <= 0))
                {
                    int index = newDrumSet.FindIndex(d => d <= 0);
                    int newDrumPrice = drumSet[index] * 3;
                    if (newDrumPrice <= savingMoney)
                    {
                        newDrumSet[index] = drumSet[index];
                        savingMoney -= newDrumPrice;
                    }
                    else
                    {
                        drumSet.Remove(drumSet[index]);
                        newDrumSet.Remove(newDrumSet[index]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", newDrumSet));
            Console.WriteLine($"Gabsy has {savingMoney:F2}lv.");
        }
    }
}
