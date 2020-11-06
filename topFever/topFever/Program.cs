using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topFever
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ODD String:");
            string name = Console.ReadLine();
            int l = name.Length/2 ;
            for (int i = 0; i<name.Length; i++)
            {
                for (int j = 0; j <name.Length; j++)
                { 
                    if(i==l)
                    {
                        Console.Write(" " + name[j]);
                     }
                    else if (j == l)
                    {
                        Console.Write(" " + name[i]);
                    }
                    else
                    {
                        Console.Write(" X");
                    }
               
                    }
                Console.WriteLine();
                }
               
                
            }
        }
    
}
