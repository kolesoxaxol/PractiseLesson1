using System;

namespace Task1Library
{
    public static class MathLength
    {
        public static double GetLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }
    }
}
