using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            string result=Console.ReadLine();
            bool x = Char.TryParse(result, out a);
            if (x)
            {
                a++;
                Console.WriteLine(a);
                   
            }
            else { Console.WriteLine("Invalid input"); }
            
           
        }
    }
}
