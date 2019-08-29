using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class CarStock
    {
        static List<Car> _carList;
        

        static CarStock()
        {
            _carList = new List<Car>();
        }

        public static  void AddCarr(Car car)
        {
            _carList.Add(car);
        }

        public static Car[] GetCars()
        {
            return _carList.ToArray();
        }

        //Providing discount. If original price minus discount is less than a specific treshold -> user gets a notification.
        public static Car Discount(int numb, int discount)
        {
            if(_carList[numb].Price-discount>=_carList[numb].Price/8)
            {
                var temCar = new Car(_carList[numb].Name, _carList[numb].Price-discount, _carList[numb].Color);
                return temCar;

            }
            else
            {
                Console.WriteLine("Discount is way to big!");
                var temCar = new Car(_carList[numb].Name, _carList[numb].Price, _carList[numb].Color);
                return temCar;
            }
        }

        public static void ShowCars()
        {
            for (int i = 0;i<_carList.Count;i++)
            {
                Console.WriteLine($"Number: {i}, Name: {_carList[i].Name}, Color: {_carList[i].Color}, Price: {_carList[i].Price}.");
            }
        }
    }
}
