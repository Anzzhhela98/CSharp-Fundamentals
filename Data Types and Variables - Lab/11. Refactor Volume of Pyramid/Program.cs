using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            decimal   length = decimal.Parse(Console.ReadLine());
            Console.Write("Width: ");
            decimal  width = decimal.Parse(Console.ReadLine());
            Console.Write("Height: ");
            decimal  heigth = decimal.Parse(Console.ReadLine());
           
           decimal result = (length* width * heigth)/3;

            Console.Write($"Pyramid Volume: {result:f2}");
        }
    }
}
