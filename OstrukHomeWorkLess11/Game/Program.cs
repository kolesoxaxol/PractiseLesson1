using System;
using System.Collections.Generic;
using System.Linq;
using Library;
using Library.Players;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer[] BasePlayers = new IPlayer[]{
                new SimplePlayer("SimplePlayer"),
                new NotepadPlayer("NotepadPlayer"),
                new UberPlayer("UberPlayer"),
                new Cheater("Cheater"),
                new UberCheater("UberCheater")
            };
            FruitBasket fruitBasket = new FruitBasket();
            List<IPlayer> players = new List<IPlayer>();
            List<int> attempts = new List<int>();

            string quest = "";
            int choise = 0;
            while (quest != "exit")
            {
                Menu();
                quest = Console.ReadLine();
                Random random = new Random();
                if (quest == "1")
                {
                    string choiseStr = "";
                    Console.Write($"Enter a number of players between 2 and 8: ");
                    do
                    {
                        choiseStr = Console.ReadLine();
                        int.TryParse(choiseStr, out choise);
                        for(int i = 0; i < choise; i++)
                        {
                            players.Add(BasePlayers[random.Next(0, 4)]);
                        }
                    }
                    while (choise == 0
                    && choise >= 8
                    && choise <= 2);
                    Console.WriteLine($"{choise} players added!");
                    Console.WriteLine();
                    Console.WriteLine("Players:");
                    foreach (var a in players)
                    {
                        Console.WriteLine(a);
                    }

                    Console.WriteLine();
                    Console.WriteLine($"Basket weight: {fruitBasket.Weight}");
                    Console.WriteLine();

                    int attempt = 100;
                    string win = "";
                    while (attempt > 0)
                    {
                        foreach (var a in players)
                        {
                            if (a.Name == "Cheater")
                            {
                                foreach (var player in players.Where(s => s.Name != "Cheater"))
                                {
                                    a.Numbers.AddRange(player.Numbers);
                                }
                            }
                            if (a.Name == "UberCheater")
                            {
                                foreach (var player in players.Where(s => s.Name != "Cheater"))
                                {
                                    a.Numbers.AddRange(player.Numbers);
                                }
                            }
                            if (a.Guess(fruitBasket))
                            {
                                win = $"Game win: {a}";
                                break;
                            }
                        }
                        if (win != "")
                        {
                            break;
                        }
                        attempt--;
                    }

                    if (win != "")
                    {
                        Console.WriteLine(win);
                    }
                    else
                    {
                        Console.WriteLine("No one wins!");
                    }
                }
                else if (quest == "2")
                {
                    Console.Clear();
                }
                else if (quest == "3")
                {
                    quest = "exit";
                    Console.WriteLine("Good bye!");
                }
            }

            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("Choise quantity players for start the game: press 1");
            Console.WriteLine("Clear: press 2");
            Console.WriteLine("Exit: press 3");
            Console.Write("Make your choise: ");
        }
    }
}
