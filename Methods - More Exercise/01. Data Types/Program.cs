using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ManipulationDiferentTypes(input);

        }
        static void ManipulationDiferentTypes(string input)
        {
            if (input == "string")
            {
                StringManipulation(input);
            }
            static void StringManipulation(string input)
            {
                string typeString = Console.ReadLine();
                Console.WriteLine("$" + typeString + "$");
            }

            if (input == "real")
            {
                DoubleManipulation(input);
            }
            static void DoubleManipulation(string input)
            {
                double numReal = double.Parse(Console.ReadLine());
                Console.WriteLine($"{numReal * 1.5:F2}");
            }

            if (input == "int")
            {
                IntManipulation(input);
            }
            static void IntManipulation(string input)
            {
                int numInt = int.Parse(Console.ReadLine());
                Console.WriteLine(numInt * 2);
            }
        }
    }
}