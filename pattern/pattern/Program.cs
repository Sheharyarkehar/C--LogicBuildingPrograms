using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=6; i++)
            {
                for (int j = 1; j <=6; j++)
                {
                    if ((i == 1 && j == 1) || (i == 1 && j == 2) || (i == 1 && j == 3) || (i == 1 && j == 4) || (i == 1 && j == 5) || (i == 1 && j == 6) || (i == 1 && j == 7) || (i == 2 && j == 1)|| (i == 3 && j == 1) || (i == 4 && j == 1) || (i == 5 && j == 1) || (i == 6 && j == 1) || (i == 6 && j == 2) || (i == 6 && j == 3) || (i == 6 && j == 4) || (i == 6 && j == 5) || (i == 6 && j == 6) || (i == 2 && j == 6) || (i == 3 && j == 6) || (i == 4 && j == 6) || (i == 5 && j == 6) || (i == 6 && j == 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
              
                
                }
                Console.WriteLine();
           
            }
        }
    }
}
