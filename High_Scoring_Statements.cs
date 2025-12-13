using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{
    class Student
    {
        public string Name {  get; set; }
        public int Marks { get; set; }
    }
    internal class High_Scoring_Statements
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Riya", Marks = 90 },
                new Student { Name = "Asha", Marks = 85 },
                new Student { Name = "Bala", Marks = 70 }
            };

            var result = students
                .Where(s => s.Marks > 80)
                .Select(s => s.Name)
                .OrderBy(name => name);

            foreach( var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
