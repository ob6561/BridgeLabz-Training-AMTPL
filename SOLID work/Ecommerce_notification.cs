using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface INotifier
    {
        void Notify(string message);
    }

    class SmsNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }

    class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
    class OrderProcessor
    {
        private readonly INotifier _notifier;

        public OrderProcessor(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void Process()
        {
            _notifier.Notify("Order processed");
        }
    }
    internal class Ecommerce_notification
    {
        static void Main()
        {
            OrderProcessor processor = new OrderProcessor(new EmailNotifier());
            processor.Process();
        }
    }
}
