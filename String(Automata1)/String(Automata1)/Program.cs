using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Automata1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "BBababd";
            bool a = false;
            for (int i = 0; i <c.Length; i++)
            {
                for (int j = i+1;  j <c.Length;  j++)
                {
                    if (c[i] == c[j])
                    {
                        Console.WriteLine("InValid");
                        a = true;
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("Valid");
                        a = true;
                        break;
                        
                    }
                }
                if(a)
                {
                    break;
                }
            }
        }
    }
}
