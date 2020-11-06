using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateofbirth = new DateTime(1997, 11, 14);
            DateTime newYears =DateTime.Now;
            TimeSpan span = newYears.Subtract(dateofbirth);
            Console.WriteLine("i'm {0:f0} years old now", span.TotalDays/365);

  
        }
    }
}
