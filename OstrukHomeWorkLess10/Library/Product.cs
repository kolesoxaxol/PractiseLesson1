using System;

namespace Library
{
    public class Product : BaseProduct
    {
        private string name;
        private double price;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public Product(string Name, double Price, int shelfLife)
        {
            this.name = Name;
            this.price = Price;
            this.ShelfLife = shelfLife;
        }

        public override string ToString()
        {
            return $"Product: {name}, price: {price}, shelf life: {ShelfLife}";
        }

        public void PrintDelay(DateTime date)
        {
            Console.WriteLine("{0}, date of delay: {1}", this.name, DelayEmulator(date));
        }
    }
}
