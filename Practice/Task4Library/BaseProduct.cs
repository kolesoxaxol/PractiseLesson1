namespace Task4Library
{
    public abstract class BaseProduct
    {
        public string Manufacturer { get; set; }
        public double[] Dimensions { get; set; }

        public BaseProduct(string Manufacturer)
        {
            this.Manufacturer = Manufacturer;
        }

        public BaseProduct(double[] Dimensions)
        {
            this.Dimensions = Dimensions;
        }

        public virtual string ShowInfo()
        {
            return $"";
        }
    }
}
