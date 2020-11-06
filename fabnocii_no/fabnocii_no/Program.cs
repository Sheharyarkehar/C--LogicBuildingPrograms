using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabnocii_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = 0; i <= n - 2; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
              

            }
            Console.WriteLine("F({0})={1}",n,sum);
        }
    }
}
