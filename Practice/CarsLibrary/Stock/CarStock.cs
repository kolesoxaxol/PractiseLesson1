using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsManagement.Cars;

namespace CarsManagementStock
{
    public class TruckStock
    {
        static List<Truck> _truckList;
        

        static TruckStock()
        {
            _truckList = new List<Truck>();
        }

        public static  void AddTruck(Truck truck)
        {
            _truckList.Add(truck);
        }

        public static Truck[] GetTrucks()
        {
            return _truckList.ToArray();
        }

        //Providing discount. If original price minus discount is less than a specific treshold -> user gets a notification.
        public static Truck Discount(int numb, int discount)
        {
            Truck truck = GetTrucks()[numb];

            _truckList[numb].DiscountPrice = discount;

            return truck;
        }

        public static void ShowTrucks()
        {
            for (int i = 0;i< _truckList.Count;i++)
            {
                Console.WriteLine($"Number: {i}, Name: {_truckList[i].Name}, Color: {_truckList[i].Color}, Price: {_truckList[i].Price}.");
            }
        }
    }
}
