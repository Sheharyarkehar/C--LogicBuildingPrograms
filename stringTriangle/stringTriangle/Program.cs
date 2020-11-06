using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = 0; i <a.Length;i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(a[j]);
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
