using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structsss
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MYstruct ms=new MYstruct();
            ms.a = 5;
            ms.a = 67;
            Console.WriteLine(ms.a);
           
        }
        struct MYstruct
        {
            public int a;
            public float b;
            public char c;
        }
        
    }
}
