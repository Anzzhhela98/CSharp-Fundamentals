using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            KeepTrackOfGuests(count);
        }
        static void KeepTrackOfGuests(int count)
        {

            List<string> nameList = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command.Length==3) // going 
                {
                    if (nameList.Contains(command[0]))
                    {
                       
                        Console.WriteLine($"{command[0]} is already in the list!");

                    }
                    else
                    {
                        nameList.Add(command[0]);
                    }
                }
                else // is not going
                {
                    if (nameList.Contains(command[0]))
                    {
                        nameList.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, nameList));
        }
    }
}
