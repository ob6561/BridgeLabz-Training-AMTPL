using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Polymorphism
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
    internal class Drawshapes
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Circle();
            s.Draw();  
            s = new Square();
            s.Draw();  
        }
    }
}
