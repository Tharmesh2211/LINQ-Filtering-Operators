using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_FILTERING_OPERATORS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Student> students = StudentList.whereQuery();
            StudentList.PrintDetail(students);

            students = StudentList.WhereMethod();
            StudentList.PrintDetail(students);

            students = StudentList.OfType();
            StudentList.PrintDetail(students);

        }
    }
}
