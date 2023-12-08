using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_FILTERING_OPERATORS
{
    public static class StudentList
    {
        static StudentList()
        {
            Console.WriteLine("Program started Running ....");
        }
        static IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 14 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 10} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 25 }
    };

        public static IEnumerable<Student> whereQuery()
        {
            Console.WriteLine("Using Where Query : \n");
            return from s in studentList
                   where CheckAge(s.Age)
                   select s;
        }

        public static IEnumerable<Student> WhereMethod()
        {
            Console.WriteLine("\nUsing Where Method : \n");

            return studentList.Where(s => CheckAge(s.Age));
        }

        public static IEnumerable<Student> OfType()
        {
            Console.WriteLine("\nUsing OfType Query :\n");
            List<object> allTypeList = new List<object>
            {
                new Student {StudentID = 10, StudentName = "Tharmesh", Age = 20 },
                "Some string",
                42,
                new Student { StudentID = 20,StudentName = "Allwyn", Age = 22 },
                42.5,
                new Student {StudentID = 30, StudentName = "Sairam", Age = 14 },
                'Z'
            };

            //var students = allTypeList
            //    .Where(item => item is Student)
            //    .Where(item => CheckAge( ( ( Student )item ).Age ) )     // Correct Code //
            //    .Select(item => (Student)item);

            var std =  allTypeList.OfType<Student>();
            
            var check = from s in std
                        where CheckAge(s.Age)
                        select s;
            return check;

        }
        public static bool CheckAge(int age)
        {
            return age > 18;
        }

        public static void PrintDetail(IEnumerable<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.StudentID + "     " + student.StudentName + "     " + student.Age);
            }
            Console.WriteLine("\nThese Peoples are Eligible to Vote !\n");
            Console.ReadKey();
        }

    }
}
