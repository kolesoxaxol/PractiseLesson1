using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            CarList carList = new CarList();

            Console.WriteLine("1-if you want to add car \n");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("Put name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Put color: ");
                    string color = Console.ReadLine();
                    Console.WriteLine("Put coast: \n");
                    int cena = int.Parse(Console.ReadLine());

                    ClassLibrary1.Car car = new ClassLibrary1.Car(name, color, cena);
                    
                    
                    if (car.Color == "green")
                    {
                        car.Cena = carList.Sale(car);
                    }
                    carList.AddCar(car);

                }
                
                var carsss = carList.GetCarList();
                foreach (ClassLibrary1.Car cars in carsss)
                {
                    Console.WriteLine($"Name:{cars.Name},Color:{cars.Color},Cena:{cars.Cena}");
                }
            }
            else Console.WriteLine("Error try again.");

           
           

        }
    }
}
