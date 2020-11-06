using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chirst
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int p=1;p<=3; p++)
            {
                if (p == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (p == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                if (p == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen; ;
                }
             

                for (int i = 1; i <= 6; i++)
                {
                    for (int s = 1; s <= 7 - i; s++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                       
                            Console.Write(" *");
                      
                    }
                    Console.WriteLine();
                 
                }
               
            }
           Console.ForegroundColor = ConsoleColor.Black;
           Console.WriteLine();
            
          
        }
    }
}
