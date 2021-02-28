using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        string myFirstName;
        string myLastName;
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");

            Console.WriteLine("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName+ " "+myLastName );
            Console.ReadLine();
        }
    }
}