
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {

        static void Main(string[] args)
        {
            A a = new A();
            B b=new B();
            if(b is A)
                Console.WriteLine("Yes");
            //Console.WriteLine(b is A? "A": "B");
        }
    }
}
