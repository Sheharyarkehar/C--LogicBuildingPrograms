using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 1050;
            int c1 = N % 100;
            int d1 = N / 100;
            int c2 = c1 % 50;
            int d2 = c1 / 50;
            int c3 = c2 % 20;
            int d3 = c2 / 20;
            int c4 = c3 %10;
            int d4 = c3 / 10;
            int c5 = c4 % 5;
            int d5 = c4 / 5;
            int c6 = c5 % 2;
            int d6 = c5 / 2;
            int c7 = c6 % 2;
            int d7 = c6 / 2;
            int c8 = c7 % 1;
            int d8 = c7 / 1;
            Console.WriteLine("Note of Rs.100="+d1);

            Console.WriteLine("Note of Rs.50=" + d2);

            Console.WriteLine("Note of Rs.20=" + d3);

            Console.WriteLine("Note of Rs.10=" + d4);

            Console.WriteLine("Note of Rs.5=" + d5);

            Console.WriteLine("Note of Rs.2=" + d6);

            Console.WriteLine("Note of Rs.1=" + d7);
        }
    }
}