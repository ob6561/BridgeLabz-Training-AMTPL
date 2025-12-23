using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_tasks.LINQ_works
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime JoiningDate { get; set; }
    }

    internal class Employees
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Amit", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-3) },
                new Employee { Name = "Ravi", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-8) },
                new Employee { Name = "Neha", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-2) }
            };

            string dept = "IT";

            var result = employees
                .Where(e => e.Department == dept &&
                            e.JoiningDate >= DateTime.Now.AddMonths(-6));

            foreach (var e in result)
            {
                Console.WriteLine(e.Name);
            }
        }
    }
}
