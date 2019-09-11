namespace Task4Library
{
    public class RawMaterials : BaseProduct
    {
        public RawMaterials(double[] Dimensions) : base(Dimensions)
        {
        }

        public override string ShowInfo()
        {
            string mat = "";
            foreach(var a in Dimensions)
            {
                mat += $"{a} x ";
            }

            return $"Raw materials dimensions: {mat.TrimEnd(' ').TrimEnd('x')}";
        }
    }
}
