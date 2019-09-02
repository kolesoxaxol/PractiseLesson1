using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	public class Minivan : CarCreator
	{
		public int SeatingPlaces { get; set; }
		public Minivan(int seatingPlace, string name, string color, int price) : base (name, color, price)
		{
			SeatingPlaces = seatingPlace;
		}
	}
}
