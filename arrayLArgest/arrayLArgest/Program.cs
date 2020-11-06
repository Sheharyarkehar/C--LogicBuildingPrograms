using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace arrayLArgest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
        
           
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
             
            }
            Console.WriteLine(largest);
            int smallest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <smallest)
                {
                    smallest = a[i];
                }

            }
            Console.WriteLine(smallest);
     
        }
    }
}
