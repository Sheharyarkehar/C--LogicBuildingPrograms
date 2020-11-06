using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(10, 99);
            Console.WriteLine(a);
            int b,d,c,t;

            b=int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("THE AWARD IS 10,000 $");
            }
            c = b % 10;
            b = b / 10;

            d = a % 10;
                t=a;
            a = a / 10;

           

            if (c == a && b == d)
            {
                Console.WriteLine("THE AWARD IS 3000 $");
            }

            else if ((c == d || c == a) || (b == a || b == d))
            {
                Console.WriteLine("THE AWARD IS 1000 $");
            }
            else
            {
                Console.WriteLine("SORRY YOU LOST BETTER LUCK NEXT TIME:'( ");
            }
     
        }
    }
}
