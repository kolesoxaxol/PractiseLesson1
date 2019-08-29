using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsConsole
{
    class Program
    {
        // car operation
        enum CarsOperation { AddNew = 1, Show, MakeDiscount, Exit };
        static void Main(string[] args)
        {

            bool isWorking = true;
            // garage for cars
            List<Car> myCarList = new List<Car>();

            // no input check, be carefully this the values
            do
            {
                Console.WriteLine($"Choose operation to do: {(int)CarsOperation.AddNew} - Add New Car , {(int)CarsOperation.Show} - Show all Cars, " +
                    $"{(int)CarsOperation.MakeDiscount} - Make discount for all {(int)CarsOperation.Exit}-Exit");
                int action = int.Parse(Console.ReadLine());
                CarsOperation curOp = (CarsOperation)action;

                // menu works here
                switch (curOp)
                {
                    case CarsOperation.AddNew:
                        {

                            Console.WriteLine("Enter car name");
                            string carName = Console.ReadLine();
                            Console.WriteLine("Enter car color");
                            string carColor = Console.ReadLine();
                            Console.WriteLine("Enter car price");
                            int carPrice = int.Parse(Console.ReadLine());
                            Car tempCar = new Car(carName, carColor, carPrice);
                            myCarList.Add(tempCar);
                            break;
                        }
                    case CarsOperation.Show:
                        {
                            if (myCarList.Count!=0)
                            {
                                foreach (var tempCar in myCarList)
                                {
                                    Console.WriteLine(tempCar.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("No cars in garage");
                            }
                            break;
                        }
                    case CarsOperation.MakeDiscount:
                        {
                            if (myCarList.Count != 0)
                            {
                                foreach (var tempCar in myCarList)
                                {
                                    Console.WriteLine($"Discount for {tempCar.CarName,20} is {tempCar.MakeDiscount(),3}");
                                }
                                Console.WriteLine("You are cheater");
                            }
                            else
                            {
                                Console.WriteLine("No cars in garage");
                            }
                            break;
                        }
                    case CarsOperation.Exit:
                        {
                            isWorking = false;
                            break;
                        }
                }


            } while (isWorking);

            
        }
    }
}
