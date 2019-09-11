using System;
using Task3Library;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[] {
                new Triangle(new Point(4, 2), new Point(8, 6), new Point(8, 2)),
                new Rectangle(new Point(4, 5), new Point(4, 10), new Point(8, 10), new Point(8, 5)),
                new Rectangle(new Point(4, 5), new Point(4, 10), new Point(8, 10), new Point(4, 10)),
                new Circle(new Point(4, 5), new Point(10, 5)),
                new Circle(new Point(4, 5), new Point(10, 5), new Point(4, 10))
            };

            foreach (var a in shapes) {
                Console.WriteLine(a.ShapeInfo());
            }

            Console.ReadKey();
        }
    }
}
