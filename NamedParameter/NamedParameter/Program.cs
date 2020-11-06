using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            ABC(x:4,age:8);
            ABD(4);
        }
        static void ABC(int age,int x)
    {
        Console.WriteLine(age+""+x);
    }
        static void ABD(int x,int age=56)
        {
            
            Console.WriteLine(age + "" + x);
        }
    }
}
