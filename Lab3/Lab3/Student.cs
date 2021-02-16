using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        private string name;
        private int id;
        private string department;
        private float cgpa;
        public Student()
        {
        }
        public Student(string name, int id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);

            Console.WriteLine("ID: " + id);

            Console.WriteLine("Department: " + department);

            Console.WriteLine("CGPA: " + cgpa);

            Console.ReadLine();
        }
        public static void Main (string[] arg)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s2.name = "Natasha";
            s2.id = 18-39059-3;
            s2.ShowInfo();
        }
        
    }   
 }
   

