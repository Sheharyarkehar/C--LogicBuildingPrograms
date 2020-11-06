using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            for (int i = 1; i <=2; i++)
            {
                for (int j = 1; j<=a; j++)
                {
                    if (a==5)
                    {
                        Console.Write("  ");
                    }
                    if (a == 7)
                    {
                        Console.Write(" ");
                    }
                  
                    Console.Write(" *");
                    
                   
                }
                Console.WriteLine();
                a += 2;
                
            }
            Console.WriteLine(" ****************");
        }
    }
}
