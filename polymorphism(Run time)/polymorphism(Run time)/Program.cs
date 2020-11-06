using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Run_time_
{
    class Program
    {
        static void Main(string[] args)
        {
           A a = new A();
           C c = new C();
            //Console.WriteLine(a is A);
           if (a is B)
           {
               B b = (B)new A();
               b.GetSleepAt();
           }
          
            
            //c.GetSleepAt();
        }
    }
}
