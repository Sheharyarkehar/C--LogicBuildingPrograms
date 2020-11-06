using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "Missipi";
            //int largest = n[0];
            //int j = 0;
           char []a=new char[100];
           char[] p = new char[100];
            for (int i = 0; i < n.Length; i++)
            {
                if (n.IndexOf(n[i]) != n.LastIndexOf(n[i]))
                {
                   a[i]=n[i];
                       
                    
                }
             
            }
            for (int j = 0; j < a.Length; j++)
            {
                p = a.Distinct().ToArray();
                
            }
            for (int l = 0; l < p.Length; l++)
            {
                Console.Write(p[l]);
            }
            Console.WriteLine();


        }

    }
}
