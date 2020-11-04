using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            CheckNumbers(first, second, third);
        }
        static void CheckNumbers(int first, int second, int third)
        {

            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((first > 0 && second > 0 && third > 0) ||
                    (first < 0 && second < 0 && third > 0) ||
                    (first < 0 && second > 0 && third < 0) ||
                    (first > 0 && second < 0 && third < 0))
            {
                Console.WriteLine("positive");
            }
            else if(first<0||second<0||third<0)
            {
                Console.WriteLine("negative");
            }
        }
    }
}
