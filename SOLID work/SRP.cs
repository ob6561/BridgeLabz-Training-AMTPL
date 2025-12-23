using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    class UserService
    {
        public void CreateUser(string name)
        {
            Console.WriteLine($"User {name} created");
        }
    }

    class EmailService
    {
        public void SendEmail(string name)
        {
            Console.WriteLine($"Email sent to {name}");
        }
    }

    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
    internal class SRP
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            EmailService emailService = new EmailService();
            Logger logger = new Logger();
            userService.CreateUser("Om");
            emailService.SendEmail("ob6561@srmist.edu.in");
            logger.Log("User creation");
        }
    }
}
