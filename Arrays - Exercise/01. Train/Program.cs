using System;
using System.Linq;

namespace CheckExam
{
    class Program
    {
        static void Main(string[] args)
        {

            int wagons = int.Parse(Console.ReadLine());

            int[] countPeople = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                countPeople[i] = int.Parse(Console.ReadLine());

            }
            Console.Write(string.Join(" ", countPeople));
            Console.WriteLine();
            Console.WriteLine(countPeople.Sum());


        }
    }
}
