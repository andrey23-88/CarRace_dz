using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    class Program
    {
        static void Main(string[] crsr)
        {
            SportCar sportCar = new SportCar();
            MotorCar motorCar = new MotorCar();
            Truck truck = new Truck();
            Bus bus = new Bus();

            List<Thread> vehicles = new List<Thread>() //Массив потоков
            {
                // Четыре потока, выполняющих метод Drive
                new Thread(sportCar.Drive),
                new Thread(motorCar.Drive),
                new Thread(truck.Drive),
                new Thread(bus.Drive)
            };

            foreach (Thread cars in vehicles)
            {
                // Запуск потоков
                cars.Start();
            }
            Console.ReadKey();
        }
    }
}