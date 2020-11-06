using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_change
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 24; i++)
            {
                Console.Write(i);
                if ((i == 4)||(i==9)||(i==14)||(i==19)||(i==24))
                { 
                    Console.WriteLine();
                }
                 

            }
        }
    }
}
