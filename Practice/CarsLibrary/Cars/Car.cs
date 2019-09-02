using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.Cars
{
    public abstract class Car
    {
        private decimal _discountPrice;

        public Car()
        {

        }

        public Car(string name, int price, string color)
        {
            this.Name = name;
            this.Price = price;
            this.Color = color;
        }

        public string Name { get; internal set; }
        public string Color { get; internal set; }
        public decimal Price { get; internal set; }
        public decimal DiscountPrice
        {
            get
            {
                return _discountPrice;
            }
            internal set
            {
                decimal discount = value;

                decimal limitDiscount = 0.3m;

                bool discountTooBig =  discount/100 > limitDiscount;

                if(discountTooBig)
                {
                    Console.WriteLine("This discount is too big! Price is set to default.");
                    _discountPrice = this.Price;
                }
                else
                {
                    _discountPrice = this.Price*(100-discount)/100;
                }

            }
        }

    }
}
