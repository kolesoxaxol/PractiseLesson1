namespace Task1Library
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    public abstract class Figure
    {
        protected abstract Point[] Points { get; set; }
        protected Figure(Point[] Points)
        {
            this.Points = Points;
        }

        public virtual bool IsIsosceles
        {
            get
            {
                return false;
            }
        }

        public virtual double Area
        {
            get
            {
                return 0.0;
            }
        }

        public virtual double Perimeter
        {
            get
            {
                return 0.0;
            }
        }

        public virtual double[] SideLengths
        {
            get
            {
                return new double[0];
            }
        }
    }
}
