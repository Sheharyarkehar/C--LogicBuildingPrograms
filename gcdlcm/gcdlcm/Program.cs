using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcdlcm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y, t, gcd, lcm;
 
  Console.Write("Enter no1:");
  x=Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter no2:");
  y=Convert.ToInt32(Console.ReadLine());
 
  a = x;
  b = y;
 
  while (b != 0) 
  {
    t = b;
    b = a % b;
    a = t;
  }
 
  gcd = a;
  lcm = (x*y)/gcd;
 
  Console.Write("Greatest common divisor of {0} and {1} = {2}\n", x, y, gcd);
  Console.Write("Least common Multiple of {0} and {1} = {2}\n", x, y, lcm);

        }
    }
}
