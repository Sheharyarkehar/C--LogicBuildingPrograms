using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <=n; i++)
            {
                if (n % i == 0)
                {
                    count++;



                }
            }
                if (count == 2)
                {
                    Console.WriteLine("No is Prime");
                }
                else
                {
                    Console.WriteLine("no is not prime");
                }
            }
        }
    }
