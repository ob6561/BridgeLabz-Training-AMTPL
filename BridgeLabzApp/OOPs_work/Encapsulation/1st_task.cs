using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Encapsulation
{
    internal class Red()
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            Console.WriteLine(mycar.color);
            Console.WriteLine(mycar.speed);
        }
    }

    class Car
    {
        public int speed = 200;
        public string color = "Red";
    }
}
