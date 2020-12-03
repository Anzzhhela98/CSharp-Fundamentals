using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();


            List<char> curentChar = new List<char>();
            int lenght = text.Length;
            for (int i = 0; i < numbers.Count; i++)
            {
                int index = 0;
                while (numbers[i] != 0)
                {
                    int currentNumber = numbers[i] % 10;
                    index += currentNumber;
                    numbers[i] /= 10;
                }
                if (lenght < index)
                {
                    index = Math.Abs(lenght - index);
                }

                curentChar.Add(text[index]);
                text = text.Remove(index, 1);
                lenght = text.Length;
            }

            Console.WriteLine(String.Join("", curentChar));

        }
    }
}
