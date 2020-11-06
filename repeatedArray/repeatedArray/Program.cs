using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int j,i;
            int[] a = { 1, 2, 3, 1, 2 };
            int[] b = { 3, 2, 1, 4, 6 };
            int[] c = new int[5];
            int[] u = new int[10];
            int count = 0;
           
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < a.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        c[i] = a[j];

                    }

                }
                int []trmp=c[0];
                
                for (i = 0; i < c.Length; i++)
                {
                    if (trmp[i] != c[i])
                    {
                        trmp[i] = c[i];
                    }
                    else
                    {
                        continue;
                    }
                }


            }
            for ( i = 0; i <trmp.Length; i++)
            {
                Console.WriteLine(trmp[i]);
                
            }
            
        }
    }
}
