using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	public class CarCreator
	{
		public CarCreator(string name, string color, int price)
		{
			Name = name;
			Color = color;
			Price = price;

		}

		public string Name { get;  }
		public string Color { get; }
		public int Price { get; }

		public int discount = 10;

		public int Discount
		{
			get
			{
				if(this.Color.ToLower().Equals("black"))
				{
					return discount + 50;
				}
				else if (this.Color.ToLower().Equals("red"))
				{
					return discount + 30;
				}
				else
				{
					return discount;
				}
			}
		}
	}
}
