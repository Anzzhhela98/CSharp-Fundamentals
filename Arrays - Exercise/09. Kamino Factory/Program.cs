using System;
using System.Linq;

namespace CheckExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int DnaLength = int.Parse(Console.ReadLine());

            int bestLength = 1;

            int bestIndex = 0;
            int bestSequenceIndex = 0;
            int bestSum = 0;
            int sequenceCounter = 0;


            int[] bestSequence = new int[DnaLength];

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int curentSum = 0;
                int curentLength = 1;
                int topLength = 1;

                int topIndex = 0;

                int[] arr = input
                          .Split('!', StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
                sequenceCounter++;
                for (int i = 0; i < arr.Length - 1; i++)
                {

                    curentSum += arr[i];
                    if (arr[i] == arr[i + 1])
                    {
                        curentLength++;
                    }
                    else
                    {
                        curentLength = 1;
                    }
                    if (curentLength > topLength)
                    {
                        topLength = curentLength;
                        topIndex = i - 1;
                    }
                }
                curentSum += arr[DnaLength - 1];//?
                if (topLength > bestLength)
                {
                    bestLength = topLength;
                    bestSum = curentSum;
                    bestIndex = topIndex;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = arr.ToArray();
                }
                else if (topLength == bestLength)
                {
                    if (topIndex < bestIndex)
                    {
                        bestLength = topLength;
                        bestSum = curentSum;
                        bestIndex = topIndex;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = arr.ToArray();
                    }
                    else if (topIndex == bestIndex)
                    {
                        if (curentSum > bestSum)
                        {
                            bestLength = topLength;
                            bestSum = curentSum;
                            bestIndex = topIndex;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = arr.ToArray();
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestSequence));




        }
    }
}






