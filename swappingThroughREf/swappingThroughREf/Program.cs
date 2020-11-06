using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swappingThroughREf
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=2;
            int y = 5;
             
            swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
          
        }
        static void swap(ref int l,ref int p)
    {
        int temp=l;
         l=p;
         p = temp;
        
            
    }
    }
}
