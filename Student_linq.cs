using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{
    internal class Student_linq
    {
        class Student
        {
            public string Name { get; set; }
            public int Marks { get; set; }
            public string Class {  get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Asha", Marks = 80, Class = "10A" },
                new Student { Name = "Bala", Marks = 45, Class = "10B" },
                new Student { Name = "Riya", Marks = 92, Class = "10A" },
                new Student { Name = "Deep", Marks = 76, Class = "10C" },
                new Student { Name = "Karan", Marks = 92, Class = "10B" },
                new Student { Name = "Mina", Marks = 66, Class = "10C" }
            };
            var top3 = students
                       .OrderByDescending(s => s.Marks)
                       .ThenBy(s => s.Name)
                       .Take(3)
                       .Select(s => new { s.Name, s.Marks });
            Console.WriteLine("Top 3 students:");
            foreach (var t in top3)
                Console.WriteLine($"{t.Name} - {t.Marks}");
            var best = students.OrderByDescending(s => s.Marks).FirstOrDefault();
            if (best != null)
                Console.WriteLine($"\nBest student: {best.Name} with {best.Marks} marks");
            else
                Console.WriteLine("No students found.");
        }
    }
}
