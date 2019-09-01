using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
   public  class CarDescr
    {
      
        public CarDescr(int price, string color, string name,int discount)
        {
            Price = price;
            Color = color;
            Name = name;
           

        }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        private int discount = 10;

        public int Discount
        {
            
            get
            {
                return discount*2;
            }
       
            private set
            {
                if (value <= 60)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("wrong discount size you are fraud");
                    discount = 0;
                }
            }
        }
    }
}

