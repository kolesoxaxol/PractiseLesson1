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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                Console.Clear();
                Console.Write("Введите количство машин:");
            } while (!uint.TryParse(Console.ReadLine(), out count));

            Car[] carMagaz = new Car[count];
            for (int i = 0; i < carMagaz.Length; i++)
            {
                carMagaz[i] = new Car();
                Console.Clear();
                Console.WriteLine($"Лот№ {i=1}"); 
                Console.Write("Введите название машины:");
                carMagaz[i].Name = Console.ReadLine();
                Console.Write("Введите цвет машины:");
                carMagaz[i].Color = Console.ReadLine();
                uint price;
                int clear = 0;
                do
                {
                    ClearLine(0);
                    Console.Write("Введите цену машины:");
                    clear = 1;
                } while (!uint.TryParse(Console.ReadLine(),out price));
                carMagaz[i].Price = price;
                carMagaz[i].SetDiscont();

            }
           
            bool exit = false;
            int select;
            do
            {
                Console.Clear();
                select = Menu(new List<string>() { "Просмотреть", "Выход" });
                switch(select)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                }


            } while (!exit);

        }
        static void Print(Car[]car)
        {
            for(int i = 0;i<car.Length;i++)
            {

            }
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
                Console.Write("Selected (1-{0}):", menu.Count);

                while (!int.TryParse(Console.ReadLine(), out selectType))
                {
                    ClearLine(1);
                    Console.Write($"Selected (1-{menu.Count}):");
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
