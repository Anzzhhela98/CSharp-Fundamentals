using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            BigInteger highestValuev = int.MinValue;
            short higestSnow = 0;
            short higestTime = 0;
            short higestQuality = 0;
            
            for (int i = 0; i < n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow ((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue>highestValuev)
                {
                    highestValuev = snowballValue;
                    higestSnow = snowballSnow;
                    higestQuality = snowballQuality;
                    higestTime = snowballTime;
                }
         

            }
            Console.WriteLine($"{ higestSnow} : { higestTime} = { highestValuev} ({ higestQuality})");
            
        }
    }
}
