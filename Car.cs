using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        private uint price;
        public int Discont { get; private set; }
        public uint Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                SetDiscont();
            }
        }
        public Car(string name,string color,uint price)
        {
            Name = name;
            Color = color;
            this.price = price;
        }
        
        internal virtual void SetDiscont()
        {
            
            Discont = Random;
        }
        public uint GetPriceWithDiscont()
        {
            return Price - (uint)(Price * Discont) / 100;
        }

    }
}
