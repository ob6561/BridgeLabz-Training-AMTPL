using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Abstraction
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }
    internal class Shapes
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}
