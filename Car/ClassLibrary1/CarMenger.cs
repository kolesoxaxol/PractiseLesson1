using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;

namespace ClassLibrary1
{
    

    public class CarList
    {
        private static List<Car> listCar;

        public  List<Car> GetCarList()
        {
            return listCar;
        }

       public CarList()
        {
            listCar = new List<Car>();
        }

        public  void AddCar(Car newCar)
        {
            listCar.Add(newCar);
        }

        public  int Sale(Car newCar)
        {
          return newCar.Cena/2;
        }

    }
}

   
