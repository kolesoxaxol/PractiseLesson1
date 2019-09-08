using System;
using System.Collections.Generic;

namespace Library.Players
{
    public class Cheater : IPlayer
    {
        public string Name { get; set; }
        public List<int>Numbers { get; set; }
        private Random random;

        public Cheater(string Name)
        {
            this.Name = Name;
            random = new Random();
            Numbers = new List<int>();
        }

        public bool Guess(FruitBasket basket)
        {
            int tmp = random.Next(0, 1000);
            Numbers.Add(tmp);

            foreach (var a in Numbers)
            {
                if (a == tmp)
                {
                    tmp = random.Next(0, 1000);
                }
            }

            if (tmp == basket.Weight)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Player {Name}";
        }
    }
}
