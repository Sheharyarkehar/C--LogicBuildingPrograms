using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_oop_
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(1);
            Circle c2 = new Circle(2);
            Swap1(c1, c2);
            Console.WriteLine(c1.radius + " " + c2.radius);
            Swap2(c1, c2);
            Console.WriteLine(c1.radius + " " + c2.radius);

        }
        public static void Swap1(Circle x, Circle y)
        {
            Circle temp = x;
            x = y;
            y = temp;
        }
        public static void Swap2(Circle x, Circle y)
        {
            double temp = x.radius;
            x.radius = y.radius;
            y.radius = temp;
        }
    }
}