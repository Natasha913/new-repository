using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, j, num;
            int count = 0;

            Console.WriteLine("Enter the size : ");
            num = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Enter elements : ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n  Duplicate elements found :" + count);
            Console.ReadLine();
        }
    }
}
