using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace great
{
    class Program
    {
        static void Main(string[] args)
        {
            int large = 0;
            string name;
            string a=" ";
            int n=int.Parse(Console.ReadLine());
            while (n > 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
               
                    break;
                }
                 name = Console.ReadLine();
           
               

                if (n > large)
                {
                    large=n;
                    a = name;
                }
               

                
            }
            Console.WriteLine(large+a);
        }
    }
}
