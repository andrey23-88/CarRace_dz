using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    class Bus : Car
    {
        public string Name = "ПАЗ-4305";

        public void Drive()
        {
            Race(Name, CarSpeed(new Random(), 120, 140));
        }
    }
}
