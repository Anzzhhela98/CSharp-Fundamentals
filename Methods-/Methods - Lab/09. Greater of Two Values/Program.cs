using System;
using System.Linq;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString,secondString));
            }
            else if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNum, secondNum));
            }
            else
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter= char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstLetter, secondLetter));
            }

        }
        static string GetMax(string firstString, string secondString)
        {
            if (String.Compare(firstString,secondString) == 0 || String.Compare(firstString, secondString) > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
        static char GetMax(char firstLetter, char secondLetter)
        {
            if ((int)firstLetter > (int)secondLetter)
            {
                return firstLetter;
            }
            else
            {
                return secondLetter;
            }
        }
        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum>secondNum)
            {
                return firstNum;
            }
            else 
            {
                return secondNum;
            }
        }


    }
}
