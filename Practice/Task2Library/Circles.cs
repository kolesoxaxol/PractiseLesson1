using System;
using System.Collections.Generic;

namespace Task2Library
{
    public static class Circles
    {
        private static List<Circle> circles = new List<Circle>();
        public static void Add(Circle circle)
        {
            if(circles.Count < 2)
                circles.Add(circle);
        }

        public static bool EqualArea()
        {
            if (Math.Abs(circles[0].Area() - circles[1].Area()) < 0.01)
            {
                return true;
            }
            return false;
        }
    }
}
