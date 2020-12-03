using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
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
            ManipulateList(list);
        }
        static void ManipulateList(List<int> list)
        {
            string[] command = Console.ReadLine().Split(" ");
            while (command[0] != "end")
            {
                int curentNum = int.Parse(command[1]);
                if (command[0] == "Delete")
                {
                    if (list.Contains(curentNum))
                    {
                       list.RemoveAll(x=>x ==curentNum);
                    }
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }


                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
