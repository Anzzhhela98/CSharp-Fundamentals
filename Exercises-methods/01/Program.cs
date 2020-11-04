using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                       .ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();

            string[] command = Console.ReadLine().Split(" ");
            while (command[0].ToUpper()!="End")
            {
                switch (command[0])
                {
                    case "exchange":
                        int exchangeIndex = int.Parse(command[1]);
                        int firsArrCounter = 0;
                        for (int i = 0; i < exchangeIndex; i++)
                        {
                            int firstElement = numbers[0];
                            List<int> temp = new List<int>();

                            for (int j = 1; j < numbers.Count; j++)
                            {
                                temp[j - 1] = numbers[j];
                            }
                            temp[temp.Count - 1] = firstElement;
                            numbers = temp;
                        }
                        Console.WriteLine(string.Join(" ", numbers));

                        break;
                    default:
                        break;
                }


                command = Console.ReadLine().Split(" ");
            }
        }
       
    }
}
