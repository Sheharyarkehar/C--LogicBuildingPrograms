using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = "hello";
            string a = "";
            for (int i = 0; i <inp.Length; i++)
            { 
                if (inp[i] == 'a' || inp[i] == 'e' || inp[i] == 'i' || inp[i] == 'o' || inp[i] == 'u')
                {
                    a += inp[i].ToString().ToUpper();
                  
                }
                else
                {
                    a += inp[i];
                }
            }

            Console.Write(a);
        }
    }
}
