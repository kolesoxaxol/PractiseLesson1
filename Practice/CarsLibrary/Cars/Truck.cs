using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.Cars
{
    public class Truck : Car
    {

        public Truck(string name, int price, string color) : base(name, price, color)
        {
        }

        public new int DiscountPrice
        {
            get
            {
                DateTime date = new DateTime();
                return this.Price*(1 - 2 * date.Month / 100);
            }
        }
    }
}
