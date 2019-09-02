using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	public class Truck : CarCreator
	{
		public int CarryWeight { get; set; }
		public bool Warranty { get; set; }
		public int Mileage { get; set; }

		public Truck(string name, string color, int price, int weight, bool warranty, int mileage) : base (name, color, price)
		{
			CarryWeight = weight;
			Warranty = warranty;
			Mileage = mileage;
			discount = 30;
		}

	}
}
