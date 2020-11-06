using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i++ <5)
            {
                Console.WriteLine(i);
            }
            i = 0;
            while (++i < 5)
            {
                Console.WriteLine(i);
            }
            
            
        }
    }
}
