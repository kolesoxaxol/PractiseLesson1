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
        public uint Price { get; set; }
        public int Discont { get; private set; }
        public void SetDiscont()
        {
            Random random = new Random();
            Discont = random.Next(0, 50);
        }
        public uint GetPriceWithDiscont()
        {
            return (uint)(Price * Discont) / 100;
        }

    }
}
