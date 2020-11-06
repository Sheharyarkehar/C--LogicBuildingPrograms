using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPwe
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abc abc bb";
            string[] b = a.Split(' ');

            for (int i = 0; i < b.Length; i++)
            { 
              
			    if(b[i]==b[i+1])
                {
                    Console.WriteLine(b[i]);
                }
			  }
                    
                }
            }
        }
    

