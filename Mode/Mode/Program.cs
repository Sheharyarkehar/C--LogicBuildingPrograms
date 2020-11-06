using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 22, 1, 3, 5, 3, 2,3,3,222,100};
            int[] b = new int[20];
            int count=0;
            int count2=0;
            int l = 0;
            for (int i = 0; i<a.Length; i++)
            {
               
                for (int j=i+1;j<a.Length; j++)
                { 
                    if (a[i] == a[j])
                    {
                        b[count] = a[i];
                        if (b[count] == a[i])
                        {
                            count++;
                        }
                       
                        
                    }
                    
                }
              
                 
                  
                }
            //for (int i = 0; i <count; i++)
            //{
            //    for (int j = i+1; j <count; j++)
            //    {
            //        if (b[i] == a[i])
            //        {
            //            count2++;
            //        }
            //    }
            //}

            Console.WriteLine(count2);

        }
    }
}
