using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> squares = Enumerable.Range(-10, 21).Select(x => x);
            foreach (int item in squares)
            {
                Console.WriteLine(item);
            }
        }
    }
}
