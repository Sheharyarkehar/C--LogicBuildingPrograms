using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            Console.WriteLine(a.ToString("c",CultureInfo.CreateSpecificCulture("ur-pk")));
        }
    }
}
