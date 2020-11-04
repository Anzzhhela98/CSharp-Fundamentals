using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();

            double availableBalance = balance;
            double costGame = 0;

            while (gameName != "Game Time")
            {

               
                if (gameName == "OutFall 4")
                {
                    costGame = 39.99;
                    if (availableBalance < costGame)
                    {
                        Console.WriteLine("Too Expensive");
                   
                    }
                    else
                    {
                        availableBalance -= costGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                }
                else if (gameName == "CS: OG")
                {
                    costGame = 15.99;
                    if (availableBalance < costGame)
                    {
                        Console.WriteLine("Too Expensive");
                     
                    }
                    else
                    {
                        availableBalance -= costGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                }
                else if (gameName == "Zplinter Zell")
                {
                    costGame = 19.99;
                    if (availableBalance < costGame)
                    {
                        Console.WriteLine("Too Expensive");
                   
                    }
                    else
                    {
                        availableBalance -= costGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                }
                else if (gameName == "Honored 2")
                {
                    costGame = 59.99;
                    if (availableBalance < costGame)
                    {
                        Console.WriteLine("Too Expensive");
                     
                    }
                    else
                    {
                        availableBalance -= costGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                }
                else if (gameName == "RoverWatch")
                {
                    costGame = 29.99;
                    if (availableBalance < costGame)
                    {
                        Console.WriteLine("Too Expensive");
                        
                    }
                    else
                    {
                        availableBalance -= costGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    costGame = 39.99;
                    if (availableBalance < costGame)
                    {
                        Console.WriteLine("Too Expensive");
                      
                    }
                    else
                    {
                        availableBalance -= costGame;
                        Console.WriteLine($"Bought {gameName}");
                    }

                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (availableBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                gameName = Console.ReadLine();

            }
            if (gameName == "Game Time" && availableBalance > 0)
            {
                Console.WriteLine($"Total spent: ${balance - availableBalance:F2}. Remaining: ${availableBalance:F2}");
            }
        }
    }
}
