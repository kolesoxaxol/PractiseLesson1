using System;
using System.Linq;
using Task1Library;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapeze[] trapezes = new Trapeze[] {
                new Trapeze(new Point[] { new Point(2, 4), new Point(6, 10), new Point(12, 10), new Point(6, 4)}),
                new Trapeze(new Point[] { new Point(3, 5), new Point(6, 12), new Point(9, 7), new Point(5, 12)}),
                new Trapeze(new Point[] { new Point(12, 45), new Point(16, 10), new Point(11, 10), new Point(3, 7)}),
                new Trapeze(new Point[] { new Point(2, 4), new Point(6, 9), new Point(5, 7), new Point(3, 7)}),
            };

            foreach(var a in trapezes)
            {
                Console.WriteLine(a.Perimeter);
                Console.WriteLine(a.Area);
                Console.WriteLine(a.IsIsosceles);
            }

            int AverageAreaTrapeze = 0;
            double AverageArea = trapezes.ToList().Select(s => s.Area).Sum() / trapezes.Length;

            foreach (var a in trapezes)
            {
                if(a.Area > AverageArea)
                {
                    AverageAreaTrapeze++;
                }
            }

            Console.WriteLine($"Number of trapezoids with an area larger than the average area: {AverageAreaTrapeze}");
            Console.ReadKey();
        }
    }
}
