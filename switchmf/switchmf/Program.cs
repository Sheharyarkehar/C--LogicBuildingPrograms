using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchmf
{
    class Program
    {
        static void Main(string[] args)
        {
            char option=Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case 'M':
                Console.WriteLine("Male");
                break;
                case 'F':
                Console.WriteLine("Female");
                break;
                default:
                {
                    Console.WriteLine("invalid");
                    break;
                }
                 

            }


        }
    }
}
