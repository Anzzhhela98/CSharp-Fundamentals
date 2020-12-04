using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int countText = int.Parse(Console.ReadLine());
            string[] Phrases = {"Excellent product.",
                                "Such a great product.", "I always use that product.",
                                "Best product of its category.", "Exceptional product.",
                                "I can’t live without this product." };
            string[] Events = { "Now I feel good.",
                                 "I have succeeded with this product.",
                                 "Makes miracles. I am happy of the results!",
                                 "I cannot believe but now I feel awesome.",
                                 "Try it yourself, " +
                                 "I am very satisfied.",
                                 "I feel great!" };
            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < countText; i++)
            {
                Random rnd = new Random();
                int indexPharses = rnd.Next(0, Phrases.Length);
                int indexEvents = rnd.Next(0, Events.Length);
                int indexAuthors = rnd.Next(0, Authors.Length);
                int indexCities = rnd.Next(0, Cities.Length);
                Console.WriteLine($"{Phrases[indexPharses]} {Events[indexEvents]} " +
                    $"{Authors[indexAuthors]} – {Cities[indexCities]}.");
            }
        }

    }
}
