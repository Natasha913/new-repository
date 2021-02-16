using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, j, k, size, Unique;

            Console.WriteLine("Size of array: ");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements : ");


            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < size; i++)
            {
                Unique = 1;

                for (j=i+1; j<size; j++)
                {
                    if (arr[i] == arr[j])
                    { 
                        for(k=j; k < size-1; k++ )
                        {
                            arr[k] = arr[k + 1];
                        }
                        size--;
                        j--;
                        Unique = 0;

                    }
                }

                if (Unique != 1)
                {
                    for (j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    size--;
                    i--;
                }
            }

           
           Console.WriteLine("All unique elements in the array are: "+ size );
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
           }
            Console.ReadLine();
        }

    }

} 
        

       
    

