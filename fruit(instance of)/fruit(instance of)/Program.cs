using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_instance_of_
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new appleSidra();
            Orange orange = new Orange();
            Console.WriteLine(fruit is Fruit);//true
            Console.WriteLine(fruit is appleSidra);//true
            Console.WriteLine(fruit is Orange);//false
            Console.WriteLine(fruit is Apple);//true
            Console.WriteLine(fruit is appleSidra);//true
            Console.WriteLine(fruit is redApple);//false
            Console.WriteLine(orange is Orange);//true
            Console.WriteLine(orange is Fruit);//true
            Console.WriteLine(orange is Apple);//false
        }
    }
}
