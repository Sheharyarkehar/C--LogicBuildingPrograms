using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patt1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j<=i; j++,ch++)
                {
                    Console.Write(Convert.ToChar(ch));
                }
                Console.WriteLine();
            }
        }
    }
}
