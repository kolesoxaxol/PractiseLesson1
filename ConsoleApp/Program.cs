using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car;

namespace ConsoleApp
{
	class Program
	{
		static void Main()
		{

			Console.WriteLine("Enter information about 3 cars");
			List<CarCreator> listOfCars = new List<CarCreator>();
			int i = 0;
			//adding new cars;
			do
			{
				Console.Write($"{i+1}st car name:");
				string name = Console.ReadLine();
				Console.Write($"{i+1}st car colour:");
				string colour = Console.ReadLine();
				int price = 0;
				do
				{
					Console.Write($"{i+1}st car price:");

				} while (int.TryParse(Console.ReadLine(), out price) && price == 0);
				listOfCars.Add(new CarCreator(name, colour, price));
				i++;
				Console.WriteLine();
			} while (i < 3);

			foreach(CarCreator car in listOfCars)
			{
				Console.WriteLine($"U can buy car {car.Name} in {car.Color} just for {car.Price}$ (ur discont will be {car.Discount}$ for this car)");
			}

			Console.ReadKey();
		}
	}
}
