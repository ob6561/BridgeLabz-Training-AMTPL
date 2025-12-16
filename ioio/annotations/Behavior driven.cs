using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ioio.annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class SecureAttribute : Attribute
    {
        public string Role { get; }

        public SecureAttribute(string role)
        {
            Role = role;
        }
    }

    class AdminTasks
    {
        [Secure("Admin")]
        public void DeleteUser()
        {
            Console.WriteLine("User Deleted");
        }

        [Secure("User")]
        public void ViewProfile()
        {
            Console.WriteLine("Profile Viewed");
        }
    }
    internal class Behavior_driven
    {
        static void Main()
        {
            AdminTasks tasks = new AdminTasks();

            foreach (MethodInfo m in typeof(AdminTasks).GetMethods())
            {
                SecureAttribute attr =
                    (SecureAttribute)Attribute.GetCustomAttribute(
                        m, typeof(SecureAttribute));

                if (attr != null && attr.Role == "Admin")
                {
                    m.Invoke(tasks, null);
                }
            }
        }
    }
}
