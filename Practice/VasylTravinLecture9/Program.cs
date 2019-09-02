using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsManagement.Cars;
using CarsManagement.Stock;

namespace VasylTravinLecture9
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfTrucks = 3;

            Console.WriteLine($"Welcome! Please, define {amountOfTrucks} trucks!");

            for (int i = 0; i < amountOfTrucks; i++)
            {
                TruckStock.AddTruck();
            }

            Truck truck = TruckStock.Discount();

            Console.WriteLine($"Original price: {truck.Price}, Buying price: {truck.DiscountPrice}");

            Console.ReadKey();
        }
    }
}
