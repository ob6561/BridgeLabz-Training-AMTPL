using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Abstraction
{
    
    internal abstract class Vehicle
    {
        
        protected string Brand { get; }       
        public int Year { get; set; }         
        public const int MaxSpeed = 200;

        
        protected Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
            Console.WriteLine("Vehicle Constructor Called");
        }

        
        public string GetInfo()
        {
            return $"Brand: {Brand}, Year: {Year}";
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Starting the vehicle engine...");
        }

        
        public abstract void Move();

        public abstract int CurrentSpeed { get; set; }
    }

    internal class Car : Vehicle
    {
        private int speed;

        public Car(string brand, int year) : base(brand, year)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Brand} car is driving on the road");
        }

        public override int CurrentSpeed
        {
            get { return speed; }
            set
            {
                if (value <= MaxSpeed)
                    speed = value;
                else
                    speed = MaxSpeed;
            }
        }

        
        public override void StartEngine()
        {
            base.StartEngine(); 
            Console.WriteLine("Car engine started!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 2024);
            car.StartEngine();
            car.Move();
            car.CurrentSpeed = 220; 
            Console.WriteLine($"Current speed: {car.CurrentSpeed}");
            Console.WriteLine(car.GetInfo());
        }
    }
}
