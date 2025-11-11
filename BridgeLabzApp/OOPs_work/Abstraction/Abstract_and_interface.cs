using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Abstraction
{
    abstract class Appliance
    {
        public abstract void TurnOn();
    }

    interface IRemoteControl
    {
        void TurnOff();
    }
    class SmartTV : Appliance, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart TV turned ON using power button.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Smart TV turned OFF using remote control.");
        }
    }
    internal class Abstract_and_interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5: Abstract Class + Interface Together");

            Appliance tvAppliance = new SmartTV();
            tvAppliance.TurnOn();

            // Casting to interface to call TurnOff()
            IRemoteControl tvRemote = (IRemoteControl)tvAppliance;
            tvRemote.TurnOff();

            Console.ReadLine();
        }
    }
}
