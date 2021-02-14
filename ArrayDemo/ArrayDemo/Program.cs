using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i;
            int n;

            Console.WriteLine("Input the number of elements ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array : ", n);
            for (i = 0; i < n; i++)

            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.Write("\n stored elements   :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }


            Console.WriteLine("\n\n copied elements   :\n");

            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");
        }

    }
}

