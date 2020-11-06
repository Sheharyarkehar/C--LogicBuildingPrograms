using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rand
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int b=0;
            int inp=Convert.ToInt32(Console.ReadLine());
          int c=0;
        while(b!=inp)
        {
            b = a.Next(0, 10);
             inp = Convert.ToInt32(Console.ReadLine());
            
            
             if (b == inp)
             {
                 Console.WriteLine("You win:");
             }
             else if (b > inp)
             {
                 Console.WriteLine("Too low:");
             }
             else if (b < inp)
             {
                 Console.WriteLine("Too High:");
             }
             
            
           
            c++;
           
         
        }
       
            
         
         
        }
    }
}
