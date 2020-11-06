using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_loop
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i=Convert.ToInt32(Console.ReadLine());
            int r = i;
            char a;
            int sum = 0;
            Console.WriteLine("Do you want to continue");
            a = Convert.ToChar(Console.ReadLine());
            while (i>=0)
            {
                while ((a != 'N')&&(a=='Y'))
                {
                    sum += i;
                    i = Convert.ToInt32(Console.ReadLine());
                 
                    Console.WriteLine("Do you want to continue");
                    a = Convert.ToChar(Console.ReadLine());
                    
                    
                }
                if (a == 'N')
                {
                    break;
                }
             

              
            }
            Console.WriteLine(sum+r);

        }
    }
}
