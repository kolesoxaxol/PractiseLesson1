using System.Collections.Generic;

namespace Library.Players
{
    public interface IPlayer
    {
        string Name { get; set; }
        List<int> Numbers { get; set; }
        bool Guess(FruitBasket basket);
    }
}
