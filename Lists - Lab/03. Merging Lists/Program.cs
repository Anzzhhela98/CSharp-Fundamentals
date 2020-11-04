using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> first = Console
                       .ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();

            List<int> second = Console
                      .ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();
           

            
            MergingLists(first, second);
        }
        static void MergingLists(List<int> first, List<int> second)
        {
            int gotrough = Math.Min(first.Count, second.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            
            for (int i = Math.Min(first.Count, second.Count); i < Math.Max(first.Count, second.Count); i++)
            {
                if (i>=first.Count)
                {
                    result.Add(second[i]);
                }
                else
                {
                    result.Add(first[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
