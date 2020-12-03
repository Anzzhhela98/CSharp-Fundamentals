using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console
                        .ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
            ListOperations(list);
        }
        static void ListOperations(List<int> list)
        {
            string[] command = Console.ReadLine().Split(" ");
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < list.Count)
                        {
                            list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < list.Count)
                        {
                            list.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++) //  shift left => first num becomes lasts
                            {
                                int firstNum = list[0];
                                list.Add(firstNum);
                                list.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++) //Shift right  – last number becomes first
                            {
                                int lastNum = list[list.Count - 1];
                                list.Insert(0, lastNum);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;

                }
                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
