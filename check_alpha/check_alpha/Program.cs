using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            char inp = Convert.ToChar(Console.ReadLine());
            if (((inp >= 'a') && (inp <= 'z'))||((inp >= 'A') && (inp <= 'Z')))
            {
                Console.WriteLine("It is Alphabet");
            }
            else if ((inp >= '0') && (inp <= '9'))
            {
                Console.WriteLine("It is a Number");
            }
            else
            {
                Console.WriteLine("It is a special Character");
            }

        }
    }
}
