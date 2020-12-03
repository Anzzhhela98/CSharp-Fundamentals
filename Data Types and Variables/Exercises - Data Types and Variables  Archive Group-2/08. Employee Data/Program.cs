using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char femaleOrMale = char.Parse(Console.ReadLine());
            ulong ID = ulong.Parse(Console.ReadLine());
            int uniqueNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {femaleOrMale}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee number: {uniqueNumber}");



        }
    }
}
