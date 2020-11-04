using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> train = Console
                       .ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengers <= maxCapacity)
                        {
                            train[i] += (passengers);
                            break;

                        }
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
