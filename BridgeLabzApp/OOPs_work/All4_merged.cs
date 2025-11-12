using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work
{
    abstract class Vehicle
    {
        // ---------- Encapsulation ----------
        private string _brand;
        private int _speed;

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Brand cannot be empty!");
                _brand = value;
            }
        }

        public int Speed
        {
            get => _speed;
            set => _speed = value < 0 ? 0 : value;  // protect invalid value
        }

        // Constructor
        public Vehicle(string brand)
        {
            Brand = brand;
        }

        // Abstract method (forces child to define its own version)
        public abstract void Move();

        // Virtual method (can be overridden, but has a default)
        public virtual void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }
    }

    // ---------- Inheritance ----------
    class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }

        // ---------- Runtime Polymorphism (Overriding) ----------
        public override void Move()
        {
            Speed += 20;
            Console.WriteLine($"{Brand} car is moving at {Speed} km/h");
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} car engine roars to life!");
        }

        // ---------- Compile-time Polymorphism (Overloading) ----------
        public void Honk()
        {
            Console.WriteLine($"{Brand} says: Beep!");
        }

        public void Honk(string pattern)
        {
            Console.WriteLine($"{Brand} honks: {pattern}");
        }
    }
    internal class All4_merged
    {
        static void Main()
        {
            // Base reference → Derived object (polymorphism)
            Vehicle myCar = new Car("Toyota");

            myCar.StartEngine();  // runtime polymorphism (override)
            myCar.Move();         // runtime polymorphism (override)

            // Need to cast to access Car-specific method
            Car car = (Car)myCar;
            car.Honk();           // compile-time polymorphism (method overloading)
            car.Honk("Beep-Beep!");

            // Encapsulation in action
            try
            {
                car.Brand = "";   // triggers validation
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
