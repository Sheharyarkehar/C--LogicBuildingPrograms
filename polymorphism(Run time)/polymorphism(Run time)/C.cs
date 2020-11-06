using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Run_time_
{
    class C:A
    {
        public int c;
        public int d;
        public C()
        {

        }
        public override void GetSleepAt()
        {
            Console.WriteLine("I am in Class C");
        }

    }
}
