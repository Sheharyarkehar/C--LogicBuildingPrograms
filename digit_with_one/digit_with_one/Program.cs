using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_with_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=12391;
            int r1 = n % 10;
            int d1 = n / 10;
            int r2 = d1 % 10;
            int d2 = d1 / 10;
            int r3 = d2 % 10;
            int d3 = d2 / 10;
            int r4 = d3 % 10;
            int d4 = d3 / 10;
            Console.WriteLine(d4+1);
            Console.WriteLine(r4+1);
            Console.WriteLine(r3+1);
            Console.WriteLine((r2+1)%10);
            Console.WriteLine(r1+1);
            
  

        }
    }
}
