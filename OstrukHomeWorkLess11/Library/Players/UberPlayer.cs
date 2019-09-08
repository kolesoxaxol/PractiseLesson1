using System.Collections.Generic;

namespace Library.Players
{
    public class UberPlayer : IPlayer
    {
        public string Name { get; set; }
        public List<int> Numbers { get; set; }
        private static int i = 40;
        public UberPlayer(string Name)
        {
            this.Name = Name;
            Numbers = new List<int>();
        }

        public bool Guess(FruitBasket basket)
        {
            int tmp = i;
            Numbers.Add(tmp);
            if (tmp == basket.Weight)
            {
                return true;
            }
            i++;
            return false;
        }

        public override string ToString()
        {
            return $"Player {Name}";
        }
    }
}
