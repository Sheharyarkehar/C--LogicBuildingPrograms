using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] even = new int[10];
            int[] odd = new int[10];
            int j = 0, k = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {

                    even[j] = myArray[i];
                    j++;
                    // Console.WriteLine(even[j]);
                }

                else if (myArray[i] % 2 != 0)
                {

                    odd[k] = myArray[i];
                    k++;
                    //Console.WriteLine(odd[i]);
                }

            }
            Console.WriteLine("Even Array");
            for (int i = 0; i <even.Length; i++)
            {
                Console.WriteLine(even[i]);
                
            }
            Console.WriteLine("ODD Array");
            for (int i = 0; i < odd.Length; i++)
            {
               
                Console.WriteLine(odd[i]);
            }
        }
    }
}
