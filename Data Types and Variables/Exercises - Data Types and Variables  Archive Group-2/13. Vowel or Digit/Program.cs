using System;
namespace

Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            char.GetNumericValue(letter);

            if (letter == 'a' || letter == 'o' || letter == 'u' || letter == 'e' || letter == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (letter >= 48 && letter <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
