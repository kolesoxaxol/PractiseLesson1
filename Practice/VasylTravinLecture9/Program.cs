using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsLibrary;

namespace VasylTravinLecture9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please, define 3 cars!");

            //generating library of 3 cars;
            int cycleInd = 0;
            while(cycleInd<3)
            {
                Console.WriteLine("Name of a car:");
                string name = Console.ReadLine();
                Console.WriteLine("Price of a car:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Color:");
                string color = Console.ReadLine();
                var tempCar = new Car(name, price, color);
                CarStock.AddCarr(tempCar);
                cycleInd++;
            }

            //showing all cars;

            CarStock.ShowCars();

            //giving discount;

            Console.WriteLine("\nProvide an exact discount:");
            int disc = int.Parse(Console.ReadLine());
            Console.WriteLine("What car from the list do you want to buy with this discount? Please, select \"N\" from the list.");
            int carNum = int.Parse(Console.ReadLine());
            Car discCar = CarStock.Discount(carNum, disc);
            Console.WriteLine($"You sell the car of model {discCar.Name}, of color {discCar.Color} with a price of {discCar.Price}. Original price is {CarStock.GetCars()[carNum].Price}.");

            Console.WriteLine("\nTesting for changes in original CarStock list.\n");
            CarStock.ShowCars();

            //testing for manual changes of car's price in original CarStock;
            //CarStock.GetCars()[1].Price = 100;

            Console.ReadKey();
        }
    }
}
