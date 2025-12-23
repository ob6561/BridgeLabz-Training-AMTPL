using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IPayment
    {
        void Pay();
    }
    class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paid using Card");
        }
    }
    class UpiPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paid using UPI");
        }
    }
    class PaymentProcessor
    {
        public void ProcessPayment(IPayment payment)
        {
            payment.Pay();
        }
    }
    internal class OCP_payment
    {
        static void Main()
        {
            PaymentProcessor processor = new PaymentProcessor();
            processor.ProcessPayment(new CardPayment());
            processor.ProcessPayment(new UpiPayment());
        }
    }
}
