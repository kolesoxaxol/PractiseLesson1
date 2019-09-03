using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9
{
    class Minivan:Car
    {
        public int CountSeats { get; set; }


        public Minivan(string name, string color, uint price,int countSeats) : base(name, color, price)
        {
            CountSeats = countSeats;
        }
        internal override void SetDiscont()
        {

            base.SetDiscont(disc);
        }
    }
}
