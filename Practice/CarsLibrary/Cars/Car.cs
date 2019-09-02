using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.Cars
{
    public abstract class Car
    {
        private int _discountPrice;

        public Car(string name, int price, string color)
        {
            this.Name = name;
            this.Price = price;
            this.Color = color;
        }

        public string Name { get; internal set; }
        public string Color { get; internal set; }
        public int Price { get; internal set; }
        public int DiscountPrice
        {
            get
            {
                return _discountPrice;
            }
            internal set
            {
                int discount = value;

                int newPrice = this.Price*(1 - discount/100);

                bool discountTooBig =  newPrice < this.Price * 0.7;

                if(discountTooBig)
                {
                    Console.WriteLine("This discount is too big! Price is set to default.");
                    _discountPrice = this.Price;
                }
                else
                {
                    _discountPrice = newPrice;
                }

            }
        }

    }
}
