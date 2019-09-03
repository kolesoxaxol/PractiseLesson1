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
            //int amountOfTrucks = 3;
            int amountOfMinivans = 3;

            //Console.WriteLine($"Welcome! Please, define {amountOfTrucks} trucks!");

            //for (int i = 0; i < amountOfTrucks; i++)
            //{
            //    TruckStock.AddTruck();
            //}

            Console.WriteLine($"Welcome! Please, define {amountOfMinivans} minivans!");

            for (int i = 0; i < amountOfMinivans; i++)
            {
                MinivanStock.AddMinivan();
            }

            Minivan minivan = MinivanStock.Discount();

            Console.WriteLine($"Original price: {minivan.Price}, Buying price: {minivan.DiscountPrice}");


            Console.ReadKey();
        }
    }
}
