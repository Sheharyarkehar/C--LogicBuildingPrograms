using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1234,i=1, a, add = 0;
            for(;num!=0;)
            {
                a=num%10;
                add=add+a;
                num=num/10;
                i++;
            }
            Console.WriteLine(add);

        }
    }
}
