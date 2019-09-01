using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCar;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarMove carList = new CarMove();
            Console.WriteLine(" 1-add; 2-all;3-exit; ");
            int answer = Convert.ToInt32(Console.ReadLine());
            while (answer == 1 || answer == 2 || answer == 3 || answer == 4)
            {
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Enter price of car:");
                        int pricecar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter color of car:");
                        string colorcar = Console.ReadLine();

                        Console.WriteLine("Enter name of car:");
                        string namecar = Console.ReadLine();

                        carList.NewCarAdd(new CarDescr(Convert.ToInt32(pricecar), colorcar, namecar,10));
                        break;
                    case 2:
                        var cars = CarMove.ViewCarList;
                        foreach (CarDescr c in CarMove.ViewCarList)

                        {
                            Console.Write(string.Format("{{0, -{0}}}|", 7), c.Price-c.Discount);
                            Console.Write(string.Format("{{0, -{0}}}|", 7), c.Color);
                            Console.Write(string.Format("{{0, -{0}}}|", 7), c.Name);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;


                }
                Console.WriteLine(" 1-add; 2-all;3-exit; ");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();








            }
        }
    }
}

