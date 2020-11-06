using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            String []a={"Shery","Ali","Zulfiqar","Hamza"};
       Array.Sort(a);
       for (int i = 0; i < a.Length; i++)
       {
           Console.WriteLine(a[i]);
       }
        }
    }
}
