using System;

namespace Task3Library
{
    public class Triangle : IShape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        private Point C { get; set; }
        double AB;
        double BC;
        double AC;

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;

            AB = Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2);
            BC = Math.Round(Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2)), 2);
            AC = Math.Round(Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2)), 2);
        }
        public double Area()
        {
            double perimeter = (AB + BC + AC) / 2;
            return Math.Round(Math.Sqrt(perimeter * (perimeter - AB) * (perimeter - BC) * (perimeter - AC)), 2);
        }
        public string ShapeInfo()
        {
            return $"Shape - {nameof(Triangle)}, A = {AB}, B = {BC}, A = {AC}, Area = {Area()}";
        }
    }
}
