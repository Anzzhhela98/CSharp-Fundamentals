using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSeconds = (hours + minutes + minutes / 60.0f) + (seconds/3600.0f);

            float metersPerSecond = (distanceInMeters / 1000) / totalSeconds;
            float kmPerHer = metersPerSecond / 3.6f;
            float milesPerHour = (distanceInMeters / 1609.0f) / totalSeconds;
        }
    }
}
