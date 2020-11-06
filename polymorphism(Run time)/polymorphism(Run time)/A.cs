using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Run_time_
{
    class A
    {
        public int a;
        public A()
        {
            Console.WriteLine("A");

        }
        public virtual void GetSleepAt()
        {
            Console.WriteLine("I am in Class A");
        }
    }
}
