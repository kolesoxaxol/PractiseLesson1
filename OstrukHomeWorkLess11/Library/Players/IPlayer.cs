namespace Library.Players
{
    public interface IPlayer
    {
        string Name { get; set; }
        int[] Numbers { get; set; }
        bool Guess(FruitBasket basket);
    }
}
