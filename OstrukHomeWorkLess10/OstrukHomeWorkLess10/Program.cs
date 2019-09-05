using Library;
using System;

namespace OstrukHomeWorkLess10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock.Products.Add(new Product("Sand", 25.5, 5));
            Stock.Products.Add(new Product("Wire", 45.3, 3));
            Stock.Products.Add(new Product("Milk", 12.7, 20));

            Stock.Print();

            DateTime[] dateTimes = new DateTime[3] { new DateTime(2019, 9, 5), new DateTime(2019, 9, 1), new DateTime(2019, 9, 1) };
            int i = 0;

            foreach(var a in Stock.Products)
            {
                a.PrintDelay(dateTimes[i]);
                i++;
            }

            Console.ReadKey();
        }
    }
}
