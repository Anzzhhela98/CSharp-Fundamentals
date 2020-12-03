using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> list = Console
                      .ReadLine()
                      .Split("|")
                      .Reverse()
                      .ToList();

            List<string> result = new List<string>();
            foreach (string curentItem in list)
            {
                string[] numbers = curentItem
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var numberstToAdd in numbers)
                {
                    result.Add(numberstToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));



        }
    }
}
