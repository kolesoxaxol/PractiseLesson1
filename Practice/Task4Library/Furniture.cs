namespace Task4Library
{
    public class Furniture : BaseProduct
    {
        public Furniture(string Manufacturer) : base(Manufacturer)
        {
        }

        public override string ShowInfo()
        {
            return $"This furniture made by {Manufacturer}";
        }
    }
}
