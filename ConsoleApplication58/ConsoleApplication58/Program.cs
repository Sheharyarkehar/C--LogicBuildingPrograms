using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mehboob Shah Qasim";
            int []z=new int[100];
            int c=0;
            string []x=name.Split(' ');
            for (int i = 0; i <x.Length; i++)
            {   if(i==0)
                Console.WriteLine("First name="+x[i]);
               else if (i == 1)
                Console.WriteLine("Mid name=" + x[i]);
            else if (i == 2)
                Console.WriteLine("Last name=" + x[i]);
            }
            
            
        }
    }
}
