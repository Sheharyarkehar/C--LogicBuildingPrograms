using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGcd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b= 24, c = 34;
            int big;
            int gcd=0;
            if ((a >= b) && (a >= c))
            {
                big = a;
            }
            else if ((b >= a) && (b >= c))
            {
                big = b;
            }
            else
            {
                big = c;
            }
            for (int i = 1; i <=big; i++)
            {
                if ((a % i == 0) && (b % i == 0) && (c % i == 0))
                {
                  
                    gcd = i;

                }
            }
            if (gcd == 1)
            {
                Console.WriteLine("No Gcd Found Enter Correct Nos");
            }
            else
            {
                Console.WriteLine(gcd);
            }
        }
    }
}
