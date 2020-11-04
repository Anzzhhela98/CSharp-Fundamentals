using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int decValue = Convert.ToInt32(num, 16);
            Console.WriteLine($"{decValue}");

        }
    }
}
