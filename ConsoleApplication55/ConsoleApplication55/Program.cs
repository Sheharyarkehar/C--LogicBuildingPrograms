using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int c = a-- + ++a;
            Console.WriteLine(c);
        }
    }
}
