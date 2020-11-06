using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloopaddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1234, a, sum = 0;
            while (num!=0)
            {
                a = num % 10;
                sum = sum + a;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
