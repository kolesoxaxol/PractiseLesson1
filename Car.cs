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
        public int Discont { get; private set; }
        internal void SetDiscont()
        {
            Random random = new Random();
            Discont = random.Next(0, 50);
        }
        public uint GetPriceWithDiscont()
        {
            return Price - (uint)(Price * Discont) / 100;
        }

    }
}
