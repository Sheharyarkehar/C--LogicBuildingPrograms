using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            int a = 1;
            Console.WriteLine("a   a^2      a^3");
            Console.WriteLine("----------------");
            Console.WriteLine("{0}     {1}        {2}",a,a*a,a*a*a);
            a = 2;
            Console.WriteLine("{0}     {1}        {2}", a, a * a, a * a * a);
            a = 3;
            Console.WriteLine("{0}     {1}       {2}", a, a * a, a * a * a);
            a = 4;
            Console.WriteLine("{0}    {1}       {2}", a, a * a, a * a * a);
            a = 5;
            Console.WriteLine("{0}    {1}       {2}", a, a * a, a * a * a);
            a = 6;
            Console.WriteLine("{0}    {1}       {2}", a, a * a, a * a * a);
        }
    }
}
