using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", CS);
            Department d2 = new Department(" Science", s);
            Student s1 = new Student("Natasha", "a102", 2.4f);
            Student s2 = new Student("Asha", "b102", 2.6f);

            d1.AddStudent(s1, s2);

            d2.AddStudent(s2);

            d1.AllStudents();
            Console.WriteLine("*********************************");
            d2.AllStudent();

        }
    }
}
