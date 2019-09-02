using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsManagement.Cars
{
    public class Minivan : Car
    {
        private int _seats;
        private int _seatsLowerLimit = 5;
        private int _seatsUpperLimit = 10;
        public Minivan(string name, int price, string color, int seats) : base(name, price, color)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return _seats;
            }

            internal set
            {
                int tempSeats = value;

                bool seatsInRange =   _seatsLowerLimit <= tempSeats && tempSeats <= _seatsUpperLimit;

                do
                {
                    Console.WriteLine($"TPlease, select another amount. Min: {_seatsLowerLimit}; Max: {_seatsUpperLimit}");
                    tempSeats = int.Parse(Console.ReadLine());
                }
                while (!seatsInRange);

                _seats = tempSeats;
            }
        }
    }
}
