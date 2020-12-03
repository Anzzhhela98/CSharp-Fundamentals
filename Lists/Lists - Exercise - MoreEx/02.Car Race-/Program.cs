using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> time = Console
                      .ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();
            double leftWinner = 0;
            double rightWinner = 0;
            int leftTime = time.Count - 1;
            while (leftTime != 0)
            {
                for (int i = 0; i < time.Count / 2; i++) // left winner
                {
                    if (time[i] == 0)
                    {
                        leftWinner *= 0.8;
                    }
                    else
                    {
                        leftWinner += time[i];
                    }
                    leftTime--;

                }
                for (int j = time.Count - 1; j > time.Count / 2; j--) // right winner 
                {
                    if (time[j] == 0)
                    {
                        rightWinner *= 0.8;
                    }
                    else
                    {
                        rightWinner += time[j];
                    }
                    leftTime--;
                }
            }
            if (rightWinner > leftWinner)
            {
                Console.WriteLine($"The winner is left with total time: {leftWinner}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightWinner}");
            }
        }
    }
}
