using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsManagement.Cars;

namespace CarsManagement.Stock
{
    public class TruckStock
    {
        static List<Truck> _truckList;


        static TruckStock()
        {
            _truckList = new List<Truck>();
        }

        public static void AddTruck()
        {
            Console.WriteLine("Write down a model of a car:");
            string name = Console.ReadLine();

            Console.WriteLine("Write down original price!");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Write down a color!");
            string color = Console.ReadLine();

            _truckList.Add(new Truck(name, price, color));
        }

        public static Truck[] GetTrucks()
        {
            return _truckList.ToArray();
        }

        //Providing discount. If original price minus discount is less than a specific treshold -> user gets a notification.
        public static Truck Discount()
        {

            Console.WriteLine("=====================================");
            ShowTrucks();
            Console.WriteLine("=====================================");

            Console.WriteLine("Enter a number of a truck you want to get discount for:");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter desired discount in percents:");

            Truck truck = GetTrucks()[numb];

            truck.DiscountPrice = decimal.Parse(Console.ReadLine());

            return truck;
        }

        public static void ShowTrucks()
        {
            for (int i = 0; i < _truckList.Count; i++)
            {
                Console.WriteLine($"Number: {i}, Name: {_truckList[i].Name}, Color: {_truckList[i].Color}, Price: {_truckList[i].Price}.");
            }
        }
    }
}
