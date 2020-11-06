using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bisectionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
        float fx1,fx2,fx3;
        float x1, x2;
 
        Console.Write("Enter Value for X1 :");
        x1 = int.Parse(Console.ReadLine());
        fx1=fx(x1);
 
        Console.Write("Enter Value for X2 :");
        x2 = int.Parse(Console.ReadLine());
        fx2 = fx(x2);
 
        Console.Write("Number Of Itrations =");
        int itre = int.Parse(Console.ReadLine());
 
        float m = (x1 + x2) / 2;
        fx3=fx(m);
        int counter = 0;
        while (Math.Abs(x1 - x2) > 0.000001 || m != 0)
        {
            if (counter == itre)
            {
                break;
            }
 
            Console.Write("x1 = " + x1);
            Console.Write(" :x2 = " + x2);
            Console.Write(" :m = " + m);
            Console.Write(" :Fx1 = " + fx1);
            Console.Write(" :Fx2 = " + fx2);
            Console.WriteLine(" :Fx3 = " + fx3);
            counter=counter + 1;
            if(m==0)
            {
                break;
            }
            else if (fx1 * fx3 < 0)
            {
                x2 = m;
            }
            else
            {
                x1 = m;
            }
            m = (x1 + x2) / 2;
            fx1 = fx(x1);
            fx2 = fx(x2);
            fx3 = fx(m);
        }
        Console.WriteLine(m);
        Console.WriteLine(counter);
        Console.ReadLine();
 
    }
 
    private static float fx(float x)
    {
        x = ((float)Math.Pow(x, 3)) + ((float)Math.Pow(x, 2)) - 3 * x - 3;
        return x;
    }
}
        }
    

