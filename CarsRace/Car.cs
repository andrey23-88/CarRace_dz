using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    abstract class Car
    {
        public delegate void Start();
        public delegate void Finish();
        public event Finish OnFinish;

        public int CarSpeed(Random random, int rnd1, int rnd2)
        {
            int carSpeed;
            return carSpeed = random.Next(rnd1, rnd2 + 1);
        }
        
        public void Race(string name, int carSpeed)
        {
            int raceLength = 0;
            OnFinish += () => Winner(name);

            for (int i = 0; i < 110; i += 10, raceLength += 10)
            {
                Thread.Sleep(carSpeed);
                if(raceLength == 100)
                {
                    OnFinish();
                }
            }
        }
        
        public void Winner(string name)
        {
            Console.WriteLine($"[BOT]:{name} пересёк финишную линию!");
        }
    }
}
