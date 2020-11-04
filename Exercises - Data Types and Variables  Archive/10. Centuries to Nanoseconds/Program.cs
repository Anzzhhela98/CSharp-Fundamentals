using System;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
           int years = centuries * 100;
          double days = (int)(years * 365.2422);
            int hours = (int)days * 24;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal miliseconds = seconds * 1000M;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
