using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1024;
            int N1 = N / 100;
            int R1 = N % 100;
            int N2 = R1 / 50;
            int R2 = R1 % 50;
            int N3 = R2 / 20;
            int R3 = R2 % 20;
            int N4 = R3 / 10;
            int R4 = R3 % 10;
            int N5 = R4 / 5;
            int R5 = R4 % 5;
            int N6 = R5 / 2;
            int R6 = R5 % 2;
            int N7 = R6/ 1;
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);
            Console.WriteLine(N5);
            Console.WriteLine(N6);
            Console.WriteLine(N7);
            int sum = N1*100 + N2*50 + N3*20 + N4*10 + N5*5 + N6*2 + N7;
            Console.WriteLine(sum);
       
        }
    }
}