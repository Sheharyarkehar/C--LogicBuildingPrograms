using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i < 5; i++)
            {
                for (k = 0; k <= 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (j = i; j > 1; j--)
                {
                    Console.Write("{0}", j);
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                Console.WriteLine();
            }
            //for (i = 5; i >= 1; i--)
            //{
            //    for (k = 0; k >= i - 5; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (j = i; j > 1; j--)
            //    {
            //        Console.Write("{0}", j);
            //    }

            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}", j);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
