using System;
using System.Collections.Generic;

namespace Library.Players
{
    public class Cheater : IPlayer
    {
        public string Name { get; set; }
        public int[] Numbers { get; set; }
        private List<IPlayer> players;

        public Cheater(string Name, List<IPlayer> Players)
        {
            players = Players;
            this.Name = Name;
            Numbers = new int[100];
        }

        public bool Guess(FruitBasket basket)
        {
            int i = 0;
            Random random = new Random();

            while (i < 100)
            {
                Numbers[i] = random.Next(0, 1000);
                foreach (var a in players)
                {
                    for(int j = 0; j < a.Numbers.Length; j++)
                    {
                        if (a.Numbers[j] == Numbers[i])
                        {
                            Numbers[i] = random.Next(0, 100000);
                            break;
                        }
                    }
                }
                if (Numbers[i] == basket.Weight)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Player {Name}";
        }
    }
}
