using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "abaaAabaa";
            char[]check = {'a','b','a','a',' '};
            string[] x = name.Split('a');
            int count = 0;
            for (int i = 0; i <x.Length; i++)
            {
                Console.WriteLine(x[i]);
              
            }
            Console.WriteLine(count);
        }
    }
}
