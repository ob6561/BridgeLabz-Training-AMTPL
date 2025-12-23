using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ioio.annotations
{
    [AttributeUsage(AttributeTargets.Property)]
    class ExportAttribute : Attribute
    {
        public string ColumnName { get; }

        public ExportAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }

    class Student
    {
        [Export("Student ID")]
        public int Id { get; set; }

        [Export("Student Name")]
        public string Name { get; set; }

        public int Age { get; set; }   // Not exported
    }
    internal class Attr
    {
        static void Main()
        {
            Student s = new Student { Id = 1, Name = "Ravi", Age = 20 };

            using (StreamWriter sw = new StreamWriter("student.txt"))
            {
                foreach (PropertyInfo p in typeof(Student).GetProperties())
                {
                    ExportAttribute attr =
                        (ExportAttribute)Attribute.GetCustomAttribute(
                            p, typeof(ExportAttribute));

                    if (attr != null)
                    {
                        sw.WriteLine($"{attr.ColumnName} : {p.GetValue(s)}");
                    }
                }
            }

            Console.WriteLine("Student data exported using annotations.");
        }
    }
}
