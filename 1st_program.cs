using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{
    internal class _1st_program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 5, 3, 12, 9, 78 };
            var query = num
                        .Where(n => n > 10)
                        .Where(n => n % 2 == 0)
                        .Select(n => n * n)
                        .OrderBy(n => n);
            Console.WriteLine("Squares of even numbers > 10 (sorted):");
            foreach (var v in query)
                Console.WriteLine(v);
            var q2 =
                from n in num
                where n > 10 && n % 2 == 0
                orderby n
                select n * n;
            Console.WriteLine("\n(Using query syntax) Results:");
            foreach (var v in q2)
                Console.WriteLine(v);
        }
    }
}
