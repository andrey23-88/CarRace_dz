using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarsRace
{
    class Truck : Car
    {
        public string Name = "ЗИЛ-130";

        public void Drive()
        {
            Race(Name, CarSpeed(new Random(), 100, 120));
        }
    }
}
    
