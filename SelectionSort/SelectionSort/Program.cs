using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 22, 3, 5, 100, 1, 4, 0 };
            int temp = 0;
            for (int i = 0; i <a.Length; i++)
            {
                for (int j =0; j <a.Length; j++)
                {
                    if (a[j] > a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        

                    }
                  
                }
            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(" " + a[k]);

            }
            Console.WriteLine();
            
        }
    }
}
