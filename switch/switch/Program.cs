using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char option=Convert.ToChar(Console.ReadLine());

            switch (option)
            { 
                case '+':

                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine(c);
                    break;

                case '-':

                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine(c);
                    break;
                case '*':

                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine(c);
                    break;
                case '/':

                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine(c);
                    break;
                case '%':

                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a % b;
                    Console.WriteLine(c);
                    break;

                default:
                    { Console.WriteLine("PONKA");
                    break;
                    }
            }
        }
    }
}
