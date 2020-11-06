using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Run_time_
{
    class B:A
    {
        public int b;
        
        public B()
        {
 
            Console.WriteLine("B");

        }
        public override void GetSleepAt()
        {
            Console.WriteLine("I am at B");
        }
        public void Display()
        {
           
            Console.WriteLine("I am Displaying B");
        }
    }
}
