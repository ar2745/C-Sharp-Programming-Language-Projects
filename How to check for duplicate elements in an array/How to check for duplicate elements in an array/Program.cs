using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Number_of_Duplicate_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[500]; 
            int[] arr2 = new int[500]; 
            int[] arr3 = new int[500];
            int x, y, z = 1, c = 0, i, j;

            Console.Write("Enter range of array elemets: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} number of elements: ", x);
            for(i = 0; i < x; i++)
            {
                Console.Write("Element {0}: ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for(i = 0; i < x; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }

            for(i = 0; i < x; i++)
            {
                for(j = 0; j < x; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = z;
                        z++;
                    }
                }
                z = 1;
            }
            for(i = 0; i < x; i++)
            {
                if (arr3[i] == 2)
                {
                    c++;
                }
            }
            Console.Write("The duplicate element is: {0}", c);
        }
    }
}
