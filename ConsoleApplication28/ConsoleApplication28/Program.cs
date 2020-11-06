using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int largest = 0;
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    largest = array[i];
                }
            }
            Console.WriteLine(largest);
        }
    }
}
