using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_checking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4631;
            int r1 = a % 10;
            int d1 = a / 10;
            int r2 = d1 % 10;
            int d2 = d1 / 10;
            int r3 = d2 % 10;
            int d3 = d2 / 10;
            int r4 = d3 % 10;
            int d4= d3 / 10;
            int sum = r1 + r2 + r3 + r4;
            if (sum % 2 == 0)
            {
                a = a * 10;
                Console.WriteLine(a);
            }
            else if (sum % 2 != 0)
            {
                a = a* 10;
                int b = a + 1;
                Console.WriteLine(b);
            }


        }
    }
}
