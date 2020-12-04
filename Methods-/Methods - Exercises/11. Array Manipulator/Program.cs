using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console
                          .ReadLine()
                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {

                string[] command = input.Split();//exchange, 1 

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(arr, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(arr));
                    }
                    else
                    {
                        if (MaxEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(arr));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(arr));
                    }
                    else
                    {
                        if (MinOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinOdd(arr));
                    }
                }
                else if (command[0] == "firs")
                {
                    int count = int.Parse(command[1]);
                    if (count > arr.Length-1)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        ReturnFirstEven(arr, count);
                    }
                    else
                    {
                        ReturnFirstOdd(arr, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count > arr.Length-1)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        ReturnLastEven(arr, count);
                    }
                    else
                    {
                        ReturnLastOdd(arr, count);
                    }
                }
            }
            Console.WriteLine("[" + String.Join(", ", arr)+"]");
        }

        static void Exchange(int[] arr, int index)
        {
            //1 3 5 7 9 
            // firsArr= 5 7 9
            int firsArrCounter = 0;
            int[] firstArr = new int[arr.Length - index - 1];
            int[] secondArr = new int[index + 1];
            for (int i = index + 1; i < arr.Length; i++)
            {

                firstArr[firsArrCounter] = arr[i];
                firsArrCounter++;
            }
            for (int i = 0; i < index + 1; i++)
            {
                secondArr[i] = arr[i];
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                arr[i] = firstArr[i];
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                arr[firstArr.Length+i] = secondArr[i];
            }
        }

        static int MaxEven(int[] arr)
        {
            int maxEvenNum = int.MinValue;
            int indexMaxEven = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) 
                {
                    if (arr[i] >= maxEvenNum)
                    {
                        maxEvenNum = arr[i];
                        indexMaxEven = i;
                    }
                  ;
                }
            }
            return indexMaxEven;
        }
        static int MaxOdd(int[] arr)
        {
            int maxOddNum = int.MinValue;
            int indexMaxOdd = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 )
                {
                    if (arr[i] >= maxOddNum)
                    {
                        maxOddNum = arr[i];
                        indexMaxOdd = i;
                    }
                   
                }

            }
            return indexMaxOdd;
        }

        static int MinEven(int[] arr)
        {
            int minEvenNum = int.MaxValue;
            int indexMinEven = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 ) 
                {
                    if (arr[i] <= minEvenNum)
                    {
                        minEvenNum = arr[i];
                        indexMinEven = i;
                    }
                  
                }
            }
            return indexMinEven;
        }
        static int MinOdd(int[] arr)
        {
            int minOddNum = int.MaxValue;
            int indexMinOdd = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 ) 
                {
                    if (arr[i] <= minOddNum)
                    {
                        minOddNum = arr[i];
                        indexMinOdd = i;
                    }
                    
                }
            }
            return indexMinOdd;
        }

        static void ReturnFirstEven(int[] arr, int count)
        {
            string numbers = String.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {

                    numbers += arr[i] + " ";
                    counter++;
                    if (count == counter)
                    {
                        break;
                    }
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }

        }
        static void ReturnFirstOdd(int[] arr, int count)
        {
            string numbers = String.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {

                    numbers += arr[i] + " ";
                    counter++;
                    if (count == counter)
                    {
                        break;
                    }
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

        static void ReturnLastEven(int[] arr, int count)
        {
            int counter = 0;
            string numbers = String.Empty;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    numbers += arr[i] + " ";
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        static void ReturnLastOdd(int[] arr, int count)
        {
            int counter = 0;
            string numbers = String.Empty;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    numbers += arr[i] + " ";
                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
    }
}
