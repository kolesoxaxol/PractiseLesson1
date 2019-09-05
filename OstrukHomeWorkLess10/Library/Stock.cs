using System;
using System.Collections.Generic;

namespace Library
{
    public static class Stock
    {
        public static List<Product> Products = new List<Product>();

        public static void Print()
        {
            foreach(var product in Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
