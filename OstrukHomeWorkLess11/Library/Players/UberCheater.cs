using System.Collections.Generic;

namespace Library.Players
{
    public class UberCheater : IPlayer
    {
        public string Name { get; set; }
        public List<int> Numbers { get; set; }
        private static int i = 40;

        public UberCheater(string Name)
        {
            this.Name = Name;
            Numbers = new List<int>();
        }

        public bool Guess(FruitBasket basket)
        {
            int tmp = i;

            if (tmp == basket.Weight)
            {
                return true;
            }
            Numbers.Add(tmp);
            foreach (var a in Numbers)
            {
                if (a == tmp)
                {
                    tmp = i++;
                }
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
