using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonomous_Func
{
    class Program
    { 
        delegate int A(int a);
    

   
        static void Main(string[] args)
        {
            A mydel = x => { return x * x; };
            Console.WriteLine(mydel(5));
        }
    }
}
