using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication62
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
           
            for (int i = 1; i<=10; i++)
            {
                int x = r1.Next(0, 10 + 1);
                Console.WriteLine(x);
            }
        }
    }
}
