using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsManagement.Cars;

namespace CarsManagement.Stock
{
    public class MinivanStock
    {
        static List<Minivan> _minivanList;


        static MinivanStock()
        {
            _minivanList = new List<Minivan>();
        }

        public static void AddMinivan()
        {
            Minivan minivan = new Minivan();

            Console.WriteLine("Write down a model of a car:");
            minivan.Name = Console.ReadLine();

            Console.WriteLine("Write down original price!");
            minivan.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Write down a color!");
            minivan.Color = Console.ReadLine();

            Console.WriteLine("Write down seats amount!");
            minivan.Seats = int.Parse(Console.ReadLine());

            _minivanList.Add(minivan);
        }

        public static Minivan[] GetMinivans()
        {
            return _minivanList.ToArray();
        }

        //Providing discount. If original price minus discount is less than a specific treshold -> user gets a notification.
        public static Minivan Discount()
        {

            Console.WriteLine("=====================================");
            ShowMinivans();
            Console.WriteLine("=====================================");

            Console.WriteLine("Enter a number of a minivan you want to get discount for:");
            int numb = int.Parse(Console.ReadLine());

            Minivan minivan = GetMinivans()[numb];

            return minivan;
        }

        public static void ShowMinivans()
        {
            for (int i = 0; i < _minivanList.Count; i++)
            {
                Console.WriteLine($"Number: {i}, Name: {_minivanList[i].Name}, Color: {_minivanList[i].Color}, Price: {_minivanList[i].Price}.");
            }
        }
    }
}
