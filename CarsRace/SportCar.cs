using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    class SportCar : Car
    {
        public string Name = "ВАЗ-2108";

        public void Drive()
        {
            Race(Name, CarSpeed(new Random(), 50, 80));
        }
    }
}
