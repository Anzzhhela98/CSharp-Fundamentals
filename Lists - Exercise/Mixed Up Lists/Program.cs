using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_Up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console
                       .ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToList();
            List<int> secondList = Console
                      .ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            List<int> curentList = new List<int>();

            List<int> numsInRange = new List<int>();
            bool isFirstLenght = false;
            bool isSecondLenght = false;
            int minList;

            if (firstList.Count < secondList.Count)
            {
                minList = firstList.Count;
                isSecondLenght = true;  // ако втория е по дълъг взимаме  послдените две цифри
            }
            else
            {
                minList = secondList.Count;
                isFirstLenght = true; // ако първия е по дълъг взимаме послдените две цифри
            }
            secondList.Reverse();
            for (int i = 0; i < minList; i++)
            {
                curentList.Add(firstList[i]);
                curentList.Add(secondList[i]);
            }
            numsInRange = new List<int>();
            if (isFirstLenght)
            {
                for (int i = 0; i < 2; i++)
                {
                    numsInRange.Add(firstList[firstList.Count - 1]);
                    firstList.RemoveAt(firstList.Count - 1);
                }
            }
            else if (isSecondLenght)
            {
                for (int i = 0; i < 2; i++)
                {
                    numsInRange.Add(secondList[secondList.Count - 1]);
                    secondList.RemoveAt(secondList.Count - 1);
                }
            }

            curentList.RemoveAll(x => x <= numsInRange[0]);
            curentList.RemoveAll(x => x >= numsInRange[1]);
            curentList.Sort();
            Console.WriteLine(string.Join(" ", curentList));
        }

    }

}

