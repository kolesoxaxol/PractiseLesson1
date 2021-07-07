using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9
{
    class CarMagazinE
    {
        List<Car> itemsCar;
        public int GetCountCars
        {
            get
            {
                return itemsCar?.Count() ?? -1;
            }
        }
        public CarMagazinE()
        {
            itemsCar = new List<Car>();
        }
        public void AddCar(Car car)
        {
            itemsCar.Add(car);
        }
        public bool RemoveCar(Car car)
        {
            return itemsCar.Remove(car);
        }
        public List<string> GetAssortmentLst()
        {
            List<string> lst = new List<string>();
            int count = 1;
            foreach(var items in itemsCar)
            {
                lst.Add($"{count} Название: {items.Name}, Цвет: {items.Color}, Цена: {items.Price}, Скидка: {items.Discont}%, Цена со скидкой:{items.GetPriceWithDiscont()}.");
            }
            return lst;
        }

    }
}
