using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VountVowels(text) ); 
        }
        static int VountVowels(string text)
        {
            int sum = 0; 
            string vowels = "EeUuIiOoAa";
            for (int j = 0; j < text.Length; j++)
            {
                char letter = text[j];
                if (vowels.Contains(letter))
                {
                    sum++;
                }
               
            }
            return sum;
        }
    }
}
