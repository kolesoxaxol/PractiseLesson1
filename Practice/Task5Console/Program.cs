using System;
using Task5Library;

namespace Task5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet.Add(new Rose("Rose 1", 15.5));
            Bouquet.Add(new Rose("Rose 2", 25.5));
            Bouquet.Add(new Tulip("Tulip 1", 35.5));
            Bouquet.Add(new Tulip("Tulip 2", 45.5));
            Bouquet.Add(new Clove("Clove 1", 55.5));
            Bouquet.Add(new Clove("Clove 2", 65.5));

            Console.WriteLine("Bouquet contains: " + Bouquet.Contains());
            Console.WriteLine($"Total cost: {Bouquet.TotalCost()}");

            Console.ReadKey();
        }
    }
}
