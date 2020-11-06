using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int[] a = { 1, 2, 3, 1, 2 };
            int[] b = { 3, 2, 1, 4, 6 };
            int[] c = new int[5];
            int[] u = new int[10];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (j = 0; j < a.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        c[i] = a[j];

                    }
                    
                }

            }
            for (int i = 0; i <a.Length; i++)
            {
                u[i] = a[i];
            }
            for (int i = a.Length,l=0; i <u.Length ||l<a.Length; i++,l++)
            {
                u[i] = b[l];
                
            }
            int []k=new int[5];
            for (int i = 0; i < c.Length; i++)
            {
                
                k = c.Distinct().ToArray();

            }
            Console.Write("Intersetion of Two Arrays=");
            Console.Write("{");
            for (int i = 0; i <k.Length; i++)
            {
                Console.Write(k[i]);
                count++;
            }
            Console.Write("}");
            Console.WriteLine();
      
            Console.WriteLine();
            Console.WriteLine("Length of Maximum repeted nos in both arrays="+count);
            int[] p = new int[10];
            for (int i = 0; i <u.Length; i++)
            {
                p = u.Distinct().ToArray();
                
            }
            Console.WriteLine();
            Console.Write("Intersetion of Two Arrays=");
            Console.Write("{");
            for (int i = 0; i <p.Length; i++)
            {
                Console.Write(p[i]);
                
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine();
        }
       
       
       
    }
}
