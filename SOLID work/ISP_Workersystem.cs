using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IWorkable
    {
        void Work();
    }
    interface IEatable
    {
        void Eat();
    }
    class Human : IWorkable, IEatable
    {
        public void Work() => Console.WriteLine("Human working");
        public void Eat() => Console.WriteLine("Human eating");
    }
    class Robot : IWorkable
    {
        public void Work() => Console.WriteLine("Robot working");
    }
    internal interface ISP_Workersystem
    {
        static void Main()
        {
            IWorkable human = new Human();
            human.Work();

            IWorkable robot = new Robot();
            robot.Work();
        }
    }
}
