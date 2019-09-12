using System;

namespace Task2Library
{
    public class Circle
    {
        private Point _point;
        private double _r;
        public Circle(Point Point, double R)
        {
            this._point = Point;
            this._r = R;
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(_r, 2), 2);
        }
    }
}
