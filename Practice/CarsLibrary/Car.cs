using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class Car
    {
        public int discount;
        public Car(string name, int price, string color)
        {
            this.Name = name;
            this.Price = price;
            this.Color = color;
        }

        public string Name { get; }
        public int Price { get; }
        public string Color { get; }


    }
}
