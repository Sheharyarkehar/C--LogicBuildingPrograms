using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_list_print
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 255; i++)
            {
                char inp = Convert.ToChar(i);
                Console.WriteLine("Ascii code"+"="+i+"and  "+"Character"+"="+inp);
            }
        }
    }
}
