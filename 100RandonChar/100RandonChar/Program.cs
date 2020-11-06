using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100RandonChar
{
    class Program
    {
        static char[] a = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v', 'w', 'x', 'y', 'z'};
        static Random r = new Random();
       //static int count = 0;
       static int c = 0;
       static int p = 0;
       static void Main(string[] args)
       {
           int[] counter = new int[10];
           char[] ans = new char[10];
           char[] x = new char[10];
           GenerateRandom(ans);
           countCharacters(ans, counter,x);
           for (int i = 0; i <ans.Length; i++)
           {
               Console.WriteLine(ans[i]);
           }
           Console.WriteLine();
           for (int i = 0; i < p; i++)
           {
               Console.WriteLine(x[i]);
           }
           Console.WriteLine("Count it");
           for (int i = 0; i <c; i++)
           {
               Console.WriteLine(counter[i]);
           }
       
         
       }
           
               

           
     
        
       static public void GenerateRandom(char[]b)
        {
            int ind = 0;

            for (int i = 0; i < b.Length; i++)
            {
                ind = r.Next() % 25;
                b[i] = a[ind];
            }
        }
       static public void countCharacters(char[]d,int[]l,char[]y)
       {
           int count = 0;
           
           for (int i = 0; i < d.Length; i++)
           {
               count = 0;
               for (int j = 0; j < d.Length; j++)
               {
                   if (d[j] == a[i])
                   {
                       count++;
                       //  Console.WriteLine(d[j]);

                       y[p] = a[i];
                       p++;


                   }







               }

               if (count > 0)
               {
                   l[c] = count;
                   c++;
               }
           }
       }

    }
}
