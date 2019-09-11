using System;

namespace Task3Library
{
    public class Rectangle : IShape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        double AB;
        double BC;
        double AD;
        double CD;

        public Rectangle(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;

            AB = Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2);
            CD = AB;
            AD = Math.Round(Math.Sqrt(Math.Pow(D.X - A.X, 2) + Math.Pow(D.Y - A.Y, 2)), 2);
            BC = AD;
        }
        public double Area()
        {
            return AB * AD;
        }
        public string ShapeInfo()
        {
            return $"Shape - {(AB == AD ? "Square" : "Rectangle")}, A = {AB}, B = {AD}, C = {CD}, D = {BC}, Area = {Area()}";
        }
    }
}
