using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binTodec
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 64;
            int i = 1;
            int rem;
            int bin = 0;
            while (n != 0)
            {
                rem = n % 2;
                n = n / 2;
                bin = bin + (rem * i);
                i = i * 10;



            }



            Console.WriteLine(bin);
        }
    }
}
