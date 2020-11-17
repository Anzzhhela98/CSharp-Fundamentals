using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] inputArg = input.Split(new string[] { " | ", " -> " },
                                     StringSplitOptions.RemoveEmptyEntries)
                                     .ToArray();
                if (input.Contains("|"))
                {
                    string side = inputArg[0];
                    string user = inputArg[1];
                    AddUserToSide(book, side, user);
                }
                else if (input.Contains("->"))
                {
                    string side = inputArg[1];
                    string user = inputArg[0];
                    MoveUserToSidee(book, side, user);
                }
            }
            PrintOutPut(book);
        }

        private static void PrintOutPut(Dictionary<string, List<string>> book)
        {
            Dictionary<string, List<string>> orderedBook = book
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in orderedBook)
            {
                string currSide = kvp.Key;
                List<string> currSideUsers = kvp.Value
                    .OrderBy(u => u)
                    .ToList();
                Console.WriteLine($"Side: {currSide}, Members: {currSideUsers.Count} ");
                foreach (var name in currSideUsers)
                {
                    Console.WriteLine($"! {name}");
                }
            }
        }

        private static void MoveUserToSidee(Dictionary<string, List<string>> book, string side, string user)
        {
            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(user))
                {
                    kvp.Value.Remove(user);
                }
            }
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();

            }
            book[side].Add(user);
            Console.WriteLine($"{user} joins the {side} side!");
        }

        private static void AddUserToSide(Dictionary<string, List<string>> book, string side, string user)
        {
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }
            if (!book.Values.Any(x => x.Contains(user)))
            {
                book[side].Add(user);
            }
        }
    }
}
