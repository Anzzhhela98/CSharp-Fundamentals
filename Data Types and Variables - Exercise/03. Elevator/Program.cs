using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses =(int) Math.Ceiling(numberOfPeople / (double)elevatorCapacity);
            Console.WriteLine(courses);
        }
    }
}
