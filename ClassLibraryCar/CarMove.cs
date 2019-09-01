using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCar;


namespace ClassLibraryCar
{
    public class CarMove
    {
        public static List<CarDescr> _carList;
        public CarMove()
        {
            _carList = new List<CarDescr>();
        }
        public static CarDescr[] ViewCarList
        {
            get
            {
                return _carList.ToArray();

            }
        }
        public void NewCarAdd(CarDescr people)
        {

            _carList.Add(people);

        }
    }
}
