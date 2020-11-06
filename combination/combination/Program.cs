using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combination
{
    class Program
    {
        static void Main(string[] args)
        {
            string n ="Shery";
            for (int i = 0;i<n.Length;i++)
            {
                for (int j = 0; j< n.Length; j++)
                {
                    for (int k = 0; k< n.Length; k++)
                    {
                        if (n[i] == n[j] || n[j] == n[k] || n[i] == n[k])
                        {

                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2}", n[i], n[j], n[k]);
                        }
                        Console.WriteLine();
                    }


                 
                }
                
            }
        }
    }
}
