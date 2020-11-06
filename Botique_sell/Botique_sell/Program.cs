using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botique_sell
{
    class Program
    {
        static void Main(string[] args)
        {
            double op = 20.00;
            double sp;
            int i=0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    Botique Shop   ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    Original Price={0:c}",op);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("   Sale Price Per Day");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("****************************");
            Console.WriteLine();
            while (i <= 5)
            {
                sp = op - (op * (10.0 / 100));
                op = sp;
                i++;
                if (i == 1)
                {
                    Console.WriteLine("  Monday price={0:C}",sp);
                }
                else if (i == 2)
                {
                    Console.WriteLine("  Tuesday price={0:c}", sp);
                }
                else if (i == 3)
                {
                    Console.WriteLine("  Wednesday price={0:c}", sp);
                }
                else if (i == 4)
                {
                    Console.WriteLine("  Thursday price={0:c}", sp);
                }
                else if (i == 5)
                {
                    Console.WriteLine("  Friday price={0:c}", sp);
                }
              
            
            
            }
            Console.WriteLine("****************************");
        }
    }
}
