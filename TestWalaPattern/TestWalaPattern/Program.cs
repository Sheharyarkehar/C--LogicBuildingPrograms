using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWalaPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=32;i=i*2)    
{  
    for(int k=32;k>=i;k=k/2)
    {
        Console.Write("  ");
    }
    for(int l=1;l<=i;l=l*2)
    { 
        if(i==l)
    { 
        continue;
    }
 
       Console.Write(l+" ");
    }
    for(int j=i;j>=1;j=j/2)
    {
   
        Console.Write(j+" ");
    }
   Console.WriteLine();
    
    
}
            }
        }
    }

