using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9
{
    class Truck:Car
    {
        public uint CarryingCapacity { get; set; }
        public uint Mileage { get; set; }
        public uint Insurance { get; set; }
        private int PermDiscont { get; }

        public Truck(string name, string color, uint price,uint carry,uint mileag,uint inst):base(name,color,price)
        {
            CarryingCapacity = carry;
            Insurance = inst;
            Mileage = mileag;
            PermDiscont = 30;

        }
        internal override void SetDiscont()
        {
            base.SetDiscont(PermDiscont);
        }
    }
}
