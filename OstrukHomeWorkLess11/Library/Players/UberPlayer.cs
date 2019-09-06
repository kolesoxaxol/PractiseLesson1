namespace Library.Players
{
    public class UberPlayer : IPlayer
    {
        public string Name { get; set; }
        public int[] Numbers { get; set; }

        public UberPlayer(string Name)
        {
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
