using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Urooba";
            char[] x = name.ToCharArray();
            for (int i = 0; i <x.Length; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(x[j]);
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
