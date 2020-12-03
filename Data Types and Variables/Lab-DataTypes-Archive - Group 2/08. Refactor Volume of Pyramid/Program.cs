using System;

namespace _08._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Length: ");
            decimal lenght = decimal.Parse(Console.ReadLine());
            Console.Write("Width: ");
            decimal widht  = decimal.Parse(Console.ReadLine());
            Console.Write("Height: ");
            decimal height = decimal.Parse(Console.ReadLine());
         
            decimal volume = (lenght * widht * height) /3;

            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
