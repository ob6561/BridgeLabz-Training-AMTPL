using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzApp.OOPs_work.Polymorphism
{
    class Employee
    {
        public string Name { get; set; }
        public int EmpID { get; set; }
        public Employee(string name, int empID)
        {
            Name = name;
            EmpID = empID;
        }
        public virtual double CalculateSalary()
        {
            return 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {EmpID}, Name: {Name}");
        }
    }
    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, int empID, double monthlySalary)
            : base(name, empID)
        {
            MonthlySalary = monthlySalary;
        }

        
        public override double CalculateSalary()
        {
            Console.WriteLine($"{Name} (Full-Time) Salary Calculated");
            return MonthlySalary; 
        }
    }
    class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public PartTimeEmployee(string name, int empID, int hoursWorked, double hourlyRate)
            : base(name, empID)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        
        public override double CalculateSalary()
        {
            Console.WriteLine($"{Name} (Part-Time) Salary Calculated");
            return HoursWorked * HourlyRate;
        }
    }
    internal class Salary_calcc
    {
        static void Main(string[] args)
        {
            
            Employee emp1 = new FullTimeEmployee("Adithya", 101, 50000);
            Employee emp2 = new PartTimeEmployee("Om", 102, 120, 300);

            Console.WriteLine(" Employee Salary Calculator \n");

            emp1.DisplayInfo();
            Console.WriteLine($"Salary: {emp1.CalculateSalary()}\n");

            emp2.DisplayInfo();
            Console.WriteLine($"Salary: {emp2.CalculateSalary()}\n");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
