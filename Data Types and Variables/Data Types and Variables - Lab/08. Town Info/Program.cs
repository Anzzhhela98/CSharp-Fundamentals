using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            double populationTown = double.Parse(Console.ReadLine());
            double areaTown = double.Parse(Console.ReadLine());
            Console.WriteLine($"Town {nameOfTown} has population of {populationTown} and area {areaTown} square km.");


        }
    }
}
