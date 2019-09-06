using System.Collections.Generic;

namespace Library.Players
{
    public class UberCheater : IPlayer
    {
        public string Name { get; set; }
        public int[] Numbers { get; set; }
        private List<IPlayer> players;

        public UberCheater(string Name, List<IPlayer> Players)
        {
            players = Players;
            this.Name = Name;
            Numbers = new int[100];
        }

        public bool Guess(FruitBasket basket)
        {
            int i = 0;
            int check = 40;

            while (i < 100)
            {
                Numbers[i] = check;
                foreach (var a in players)
                {
                    for (int j = 0; j < a.Numbers.Length; j++)
                    {
                        if (a.Numbers[j] == Numbers[i])
                        {
                            Numbers[i] = check++;
                            break;
                        }
                    }
                }
                if (Numbers[i] == basket.Weight)
                {
                    return true;
                }
                check++;
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
