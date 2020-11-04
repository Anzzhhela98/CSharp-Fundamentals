using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            int rightCount = 0;
            int leftCount = 0;
            int maxCount = 0;

            for (int i = 0; i < firstInput.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    if (firstInput[i]==secondInput[j])
                    {
                        leftCount++;
                    }
                }
                for (int k = 0; k < firstInput.Length; k++)
                {
                    if (firstInput[i] == secondInput[k])
                    {
                        rightCount++;
                    }
                    
                }
                if (maxCount<leftCount||maxCount<rightCount)
                {
                    if (leftCount>rightCount)
                    {
                        maxCount = leftCount;
                    }
                    else
                    {
                        maxCount = rightCount;
                    }
                  
                }
                
            }
            if (rightCount > 0)
            {
                Console.WriteLine(rightCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        }
    }
}
