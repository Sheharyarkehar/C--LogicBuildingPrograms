using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT WEIGHT");
            int Wei = int.Parse(Console.ReadLine());

            Console.WriteLine("INPUT HEIGHT");
            int Hei = int.Parse(Console.ReadLine());

            int BMI;
            BMI = Wei / Hei;

            if (BMI <= 18.5)
            {
                Console.WriteLine("UNDERWEIGHT");
            }

            else if (BMI >= 18.5 & BMI <= 24.9)
            {
                Console.WriteLine("NOrmal weight");
            }

            else if (BMI >= 25.0 && BMI <= 29.9) 
            {
                Console.WriteLine("OVERwight");
            }
            else
                Console.WriteLine("OTHER");
        }
    }
}
