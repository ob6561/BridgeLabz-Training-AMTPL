using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Inheritance
{
    class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle constructor called for {brand}");
        }

        public void ShowBrand()
        {
            Console.WriteLine($"Brand: {Brand}");
        }
    }
    class Car : Vehicle
    {
        public string Model { get; set; }

        
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car constructor called for model {model}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car Details → Brand: {Brand}, Model: {Model}");
        }
    }
    internal class ConstInhert
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Tesla", "Model 3");
            car1.DisplayInfo();

            Console.ReadLine();
        }
    }
}
