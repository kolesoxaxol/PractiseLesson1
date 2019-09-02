using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    
        public class Car
        {
            public Car(string name, string color, int cena)

            {
                Name = name;
                Color = color;
                Cena = cena;
            }

            public string Name { get; set; }
            public string Color { get; set; }
            public int Cena { get; set; }


        }
    }
}
