using System;

namespace Library
{
    public class FruitBasket
    {
        public int Weight
        {
            get
            {
                Random random = new Random();
                return random.Next(40, 140);
            }
            private set
            {

            }
        }
    }
}
