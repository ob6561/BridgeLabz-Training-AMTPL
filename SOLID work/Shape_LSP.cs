using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IShape
    {
        double Area();
    }
    class Rectangle : IShape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public double Area() => Width * Height;
    }
    class Square : IShape
    {
        public double Side {  get; set; }
        public double Area() => Side * Side;

    }
    internal class Shape_LSP
    {
        static void Main()
        {
            IShape rect = new Rectangle { Width = 5, Height = 4 };
            Console.WriteLine(rect.Area());

            IShape square = new Square { Side = 4 };
            Console.WriteLine(square.Area());
        }
    }
}
