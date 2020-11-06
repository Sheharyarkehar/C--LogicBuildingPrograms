using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Sin(90);
            double asq = Math.Pow(a, 2);
            double b = Math.Cos(90);
            double bsq = Math.Pow(b, 2);
            double sum = asq + bsq;
            if (Convert.ToInt32(sum) == 1)
            {
                Console.WriteLine("Hence Proved");
            }
            else
            {
                Console.WriteLine("Not proved");
            }
    
    
        }
    }
}
