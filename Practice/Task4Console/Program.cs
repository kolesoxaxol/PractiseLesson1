using System;
using Task4Library;

namespace Task4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFurnitureStore.Add(new Furniture("Ikea"));
            DBFurnitureStore.Add(new RawMaterials(new[] { 25.5, 15.5, 17.5 }));

            foreach(var a in DBFurnitureStore.Products())
            {
                Console.WriteLine(a.ShowInfo());
            }

            Console.ReadKey();
        }
    }
}
