using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IMessageService
    {
        void Send();
    }

    class EmailServic : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }
    }

    class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify()
        {
            _messageService.Send();
        }
    }
    internal class DIP_notification
    {
        static void Main()
        {
            IMessageService service = new EmailServic();
            Notification notification = new Notification(service);
            notification.Notify();
        }
    }
}
