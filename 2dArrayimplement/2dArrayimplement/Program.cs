using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrayimplement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 2]{{ 1, 3},{ 3,5 },{5,4}};
            Console.WriteLine();
            for (int i = 0; i <=a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=a.GetUpperBound(1); j++)
                {
                    Console.Write(" " + a[i, j]);

                }

                Console.WriteLine();

            }
        }
    }
}
