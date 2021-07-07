using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9
{
    class Program
    {
        static void Main(string[] args)
        {
            uint count;
            CarMagazinE carMagazin = new CarMagazinE();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                Console.Clear();
                Console.Write("Введите количество машин:");
            } while (!uint.TryParse(Console.ReadLine(), out count));
            
            for (uint i = 0; i < count; i++)
            {
                
                Console.Clear();
                Console.WriteLine($"Лот№ {i+1}"); 
                Console.Write("Введите название машины:");
                string Name = Console.ReadLine();
                Console.Write("Введите цвет машины:");
                string Color = Console.ReadLine();
                uint price;
                int clear = 0;
                do
                {
                    ClearLine(clear);
                    Console.Write("Введите цену машины:");
                    clear = 1;
                } while (!uint.TryParse(Console.ReadLine(),out price));
               
                Car car = new Car(Name,Color, price);
                carMagazin.AddCar(car);
            }

            bool exit = false;
            int select;
            do
            {
                Console.Clear();
                select = Menu(new List<string>() { "Просмотреть ассортимент", "Выход" });
                switch(select)
                {
                    case 1:
                        PrintMagaz(carMagazin.GetAssortmentLst());
                        break;
                    case 2:
                        exit = true;
                        break;
                }
            } while (!exit);
        }
        static public void PrintMagaz(List<string> magaz)
        {
            Console.Clear();
            foreach(var car in magaz)
            {
                Console.WriteLine(car);
            }
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            Console.WriteLine("Для возврата нажмите любую кнопку");
            Console.ReadKey(true);
        }
        static int Menu( List<string> menu)
        {

            int selectType = 0;
            do
            {
                Console.Clear();
               
                int count = 1;
                foreach (var m in menu)
                {
                    Console.WriteLine($"{count}){m}");
                    count++;
                }
                Console.Write("Введите (1-{0}):", menu.Count);

                while (!int.TryParse(Console.ReadLine(), out selectType))
                {
                    ClearLine(1);
                    Console.Write($"Введите (1-{menu.Count}):");
                }

            } while (!(selectType >= 1 && selectType <= menu.Count));
            return selectType;
        }
        static void ClearLine(int clear = 0)
        {
            int cursor = Console.CursorTop - clear;
            Console.SetCursorPosition(0, cursor);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, cursor);
        }
    }
}
