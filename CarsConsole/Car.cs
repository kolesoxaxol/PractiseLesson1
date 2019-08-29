using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsConsole
{
   public class Car
    {
        public Car(string _carName, string _carcolor, int _carPrice)
        {
            this.CarName = _carName;
            this.CarColor = _carcolor;

            if (this.CarPrice>0)
            {
                CarPrice = _carPrice;
            }
            else
            {
                this.CarPrice = 10;
            }
            
        }

        public string CarName
        { get; }

        public string CarColor
        { get; }

        public int CarPrice
        { get; private set; }
        /// <summary>
        /// Make discount and change price
        /// </summary>
        /// <returns></returns>
        public int MakeDiscount()
        {
            Random rnd = new Random();
            int discount = rnd.Next(0, 10);
            int oldPrice = this.CarPrice;
            this.CarPrice = (this.CarPrice > discount) ? (this.CarPrice-discount) : this.CarPrice;
            return oldPrice - this.CarPrice;

        }
        public override string ToString()
        {
           return String.Format("car name: {0,10} car color: {1,10} car price {2,10}", CarName, CarColor, CarPrice); ;
        }

    }
}
