using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uroosa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; int j;
            //upper wala hissa outer loop ek 4 inner loops
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                

                Console.WriteLine();
            }
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (j = 5; j>=i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }
    }
}
