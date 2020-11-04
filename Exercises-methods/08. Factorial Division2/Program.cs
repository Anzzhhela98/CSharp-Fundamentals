using System;
using System.Linq;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();
            CheckCharacters(inputPass);
            CheckToContainsWithLettersAndDigits(inputPass);
            CheckHowMuchDigitsHave(inputPass);
        }
        static void CheckCharacters(string givenPass)
        {
            bool invalid = false;
            if ((givenPass.Length < 6 || givenPass.Length > 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (CheckToContainsWithLettersAndDigits(givenPass) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits ");
                invalid = true;
            }
            if (CheckHowMuchDigitsHave(givenPass) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckToContainsWithLettersAndDigits(string givenPass)
        {
            for (int i = 0; i < givenPass.Length; i++)
            {
                if (!((givenPass[i] >= 48 && givenPass[i] <= 57) ||
                    (givenPass[i] >= 65 && givenPass[i] <= 90) ||
                    (givenPass[i] >= 97 && givenPass[i] <= 122)))
                {
                    return false;
                }
            }
            return true;
        }
        static int CheckHowMuchDigitsHave(string givenPass)
        {
            int count = 0;
            for (int i = 0; i < givenPass.Length; i++)
            {
                if (givenPass[i] >= 48 && givenPass[i] <= 57)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

