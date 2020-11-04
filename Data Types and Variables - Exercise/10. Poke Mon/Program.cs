using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());
            int pokeCountPoints = 0;
            int originalNValue = n;
            while (n>=m)
            {
               
                n -= m;
                pokeCountPoints++;
                if (n == originalNValue / 2)
                {
                    if (y != 0)
                    {
                        n /= y;
                    }
                }
            }
            Console.WriteLine($"{n}");
            Console.WriteLine(pokeCountPoints);

        }
    }
}
