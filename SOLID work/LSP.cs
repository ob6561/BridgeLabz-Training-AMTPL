using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IEngineVehicle
    {
        void StartEngine();
    }

    class Car : IEngineVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }

    class Bicycle
    {
        public void Pedal()
        {
            Console.WriteLine("Bicycle pedaling");
        }
    }

    internal class LSP
    {
        static void Main()
        {
            IEngineVehicle car = new Car();
            car.StartEngine();

            Bicycle bicycle = new Bicycle();
            bicycle.Pedal();
        }
    }
}
