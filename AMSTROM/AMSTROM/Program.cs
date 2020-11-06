using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSTROM
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,a, num = 153;
         //   Console.WriteLine("Hundred\ten\unit");
            while (num != 0)
            {
                a = num % 10;
                num++;

                Console.WriteLine(a);
                Console.WriteLine(a * a);
                Console.WriteLine(a * a * a);
            }
                
        }
    }
}
