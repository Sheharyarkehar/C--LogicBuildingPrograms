using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "Shery", "Ali", "Zulfiqar", "Owais" };
            char[] a1=new char[50];
            char[] a2 = new char[50]; ;
            //Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j=i+1;j<a.Length;j++)
                {
                  a1=a[j].ToString().ToCharArray();
                  a2=a[i].ToString().ToCharArray();    
                   
                }
                for (int k=0;k<a.Length;k++)
                {
                    if (a1[k] < a2[k])
                    {
                        string t = a1[k];
                    }

                }

            }
        }
    }
}
