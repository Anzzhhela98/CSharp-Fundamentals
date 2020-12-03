using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> text = Console
                       .ReadLine()
                       .Split(new char[] {'.','\\',})
                       .TakeLast(2)
                       .ToList();


            Console.WriteLine($"File name: {text[0]}");
            Console.WriteLine($"File extension: {text[1]}");
        }
    }
}
