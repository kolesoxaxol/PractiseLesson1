using System;

namespace Task3Library
{
    public class Circle : IShape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        double AB = 0;
        double AC = 0;
        double Perimeter = 0;

        public Circle(Point A, Point B)
        {
            this.A = A;
            this.B = B;
            AB = Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2);
            Perimeter = Math.Round(2 * Math.PI * AB, 2);
        }
        public Circle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            AB = Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2);
            AC = Math.Round(Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2)), 2);
            Perimeter = Math.Round(2 * Math.PI * AB, 2);
        }
        public double Area()
        {
            return Math.Round(2 * Math.PI * Math.Pow((AC > AB ? AC : AB), 2), 2);
        }
        public string ShapeInfo()
        {
            return $"Shape - {(AC != 0 && (AC < AB) || (AC > AB) ? "Ellipse" : "Circle")}, R = {(AC > AB ? AC : AB)}, P = {Perimeter}, Area = {Area()}";
        }
    }
}
