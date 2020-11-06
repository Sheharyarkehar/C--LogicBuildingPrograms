using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newd
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 1; space <= 6-i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
             
            }
            for (int i = 5; i >= 1; i--)
            {
                for (int space = 1; space <= 6 - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
