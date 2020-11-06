using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroToHero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int c = 0;
            for (int i = 0; i <=a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=a.GetUpperBound(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i,j]);
                    if (a[i, j] == 0)
                    {
                        c++;
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("No of Zeros="+c);
        }
    }
}
