using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "123";
            char [] ans = a.ToCharArray();
            for (int i = 0; i <ans.Length; i++)
            {
                for (int j = ans.Length-1; j>=0; j--)
                {
                    char ch = ans[i];
                    ans[i] = ans[j];
                    ans[j] = ch;
                   

                         
                }
                for (int k = 0; k < ans.Length; k++)
                {
                    Console.Write(ans[k]);
                }
                Console.WriteLine();
             
             
                
            }
            
        }
    }
}
