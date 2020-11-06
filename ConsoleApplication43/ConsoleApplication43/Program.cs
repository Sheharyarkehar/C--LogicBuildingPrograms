using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            ADD();
        }
        static void ADD(int a = 10, float b = 5.5f)
        {
            float sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
