using System;
using System.Linq;

namespace Task1Library
{
    public class Trapeze : Figure
    {
        protected override Point[] Points { get; set; }

        public Trapeze(Point[] points) : base(points)
        {
        }
        public bool IsIsosceles
        {
            get
            {
                if (MathLength.GetLength(Points[0], Points[2]) == MathLength.GetLength(Points[1], Points[3]))
                {
                    return true;
                }
                return false;
            }
        }

        private double H
        {
            get
            {
                if (Points.Length > 3)
                {
                    return Math.Round(
                        Math.Sqrt(
                            Math.Pow(MathLength.GetLength(Points[0], Points[1]), 2) -
                        (
                        (Math.Pow(MathLength.GetLength(Points[0], Points[3]) - 
                        MathLength.GetLength(Points[1], Points[2]), 2)
                        + Math.Pow(MathLength.GetLength(Points[0], Points[1]), 2) - 
                        Math.Pow(MathLength.GetLength(Points[2], Points[3]), 2))
                        / 2 * (MathLength.GetLength(Points[0], Points[3]) - 
                        MathLength.GetLength(Points[1], Points[2])))), 2);
                }
                return 0.0;
            }
        }

        public override double Perimeter
        {
            get
            {
                return Math.Round(SideLengths.Sum(), 2);
            }
        }

        public override double Area
        {
            get
            {
                return Math.Round(0.5 * (MathLength.GetLength(Points[1], Points[2]) + MathLength.GetLength(Points[0], Points[3]) * H), 2);
            }
        }

        public override double[] SideLengths {
            get
            {
                if (Points.Length > 3)
                {
                    return new[] {
                        MathLength.GetLength(Points[0], Points[1]),
                        MathLength.GetLength(Points[1], Points[2]),
                        MathLength.GetLength(Points[2], Points[3]),
                        MathLength.GetLength(Points[0], Points[3])
                    };
                }
                return new double[0];
            }
        }
    }
}
