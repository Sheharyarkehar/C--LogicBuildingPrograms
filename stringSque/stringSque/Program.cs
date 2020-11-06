using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSque
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = "Thousand Splendid Sons";
   string []b=new string[3];
            for (int i = 0; i < inp.Length; i++)
            {
                if (inp.IndexOf(inp[i]) == 'S')
                {
                    string[] a = inp.Split(' ');
                    b[i] = a[i];

                }
            }
            for (int i = 0; i <3 ; i++)
            {
                Console.WriteLine(b[i]);
            }
           
        }
    }
}
