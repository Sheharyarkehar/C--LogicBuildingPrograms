using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, ans=0, i,c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            for ( i = 0; i <=5; i++)
            {

             
                ans=a+b;
                b = a;
                a  = ans;
                
                Console.WriteLine(ans);
                
                }
            Console.ReadKey();
        }
    }
}
