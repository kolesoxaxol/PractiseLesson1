namespace Task5Library
{
    public abstract class Flower
    {
        protected string name { get; set; }
        protected double price { get; set; }

        public Flower(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string Show()
        {
            return $"{name}, price - {price}";
        }

        public double Price()
        {
            return this.price;
        }
    }
}
