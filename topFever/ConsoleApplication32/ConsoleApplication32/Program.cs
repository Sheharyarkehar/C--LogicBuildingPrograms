using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "adkjddaadtyy";
            int Count = 0;
            int i = 0;
            foreach (char c in abc)
            {
                if (c == 'd')
                {
                    Count++;
                }
                Console.WriteLine(abc[i] + "=" + Count);

                i++;
              
            }
        
        }
    }
}
