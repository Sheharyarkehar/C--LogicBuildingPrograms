using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Program
    {
        public static void Main(String[] args)
        {

            new A();
         new B();
        }
      
    }
    public class A
    {
         public int i = 7;
        public A()
        {
            setI(20);
            Console.WriteLine("i from A is " + i);
        }
        public virtual void setI(int i)
        {
            this.i = 2 * i;
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("i from B is " + i);
        }
        public override void setI(int i)
        {
            this.i = 3 * i;
        }
    }
}

       