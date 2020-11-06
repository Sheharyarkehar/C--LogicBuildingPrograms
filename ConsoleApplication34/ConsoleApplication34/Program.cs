using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Progra
    {
        static void Main(string[] args)
        {
            int a = 5;
            for (int i = 5; i>=1; i--)
            {
                for (int k = 1; k <=6-i; k++)
                {
                    Console.Write(" ");
                    
                }
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();

                
            }
        }
    }
}
