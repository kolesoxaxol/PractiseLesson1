using System;
using System.Collections.Generic;
using Library;
using Library.Players;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitBasket fruitBasket = new FruitBasket();
            List<IPlayer> players = new List<IPlayer>();
            players.Add(new SimplePlayer("SimplePlayer"));
            players.Add(new NotepadPlayer("NotepadPlayer"));
            players.Add(new UberPlayer("UberPlayer"));
            players.Add(new Cheater("Cheater", players));
            players.Add(new UberCheater("UberCheater", players));

            Console.WriteLine("Players:");
            foreach(var a in players)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            Console.WriteLine($"Basket weight: {fruitBasket.Weight}");
            Console.WriteLine();

            string win = "";
            foreach (var a in players)
            {
                if (a.Guess(fruitBasket))
                {
                    win = $"Game win: {a}";
                    break;
                }
            }

            if(win != "")
            {
                Console.WriteLine(win);
            }
            else
            {
                Console.WriteLine("No one wins!");
            }

            Console.ReadKey();
        }
    }
}
