using System;
using Task2Library;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Circles.Add(new Circle(new Point(0, 0), 12));
            Circles.Add(new Circle(new Point(3, 5), 11));

            if (Circles.EqualArea())
            {
                Console.WriteLine("Circles is equals");
            }
            else
                Console.WriteLine("Circles is not equals");

            Console.ReadKey();
        }
    }
}
