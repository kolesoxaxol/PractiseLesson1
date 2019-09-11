using System;
using System.Collections.Generic;

namespace Task4Library
{
    public static class DBFurnitureStore
    {
        private static List<BaseProduct> products = new List<BaseProduct>();
        public static void Add(BaseProduct product)
        {
            products.Add(product);
        }

        public static void Remove(BaseProduct product)
        {
            products.Remove(product);
        }

        public static void ClearDB()
        {
            products.RemoveAll(new Predicate<BaseProduct>(product => product.Manufacturer != ""));
        }

        public static List<BaseProduct> Products()
        {
            return products;
        }
    }
}
