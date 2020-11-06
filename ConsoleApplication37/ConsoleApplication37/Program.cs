using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x1 = "At(x)=";
          //  Function at = new Function(x1);
           Function at = new Function("At(x)=x^2 + x + 5");
          // string x = "x=";
            Argument b = new Argument("x=3");
            //  Argument ag1 = new Argument("h=10");

            Expression e2 = new Expression("At(x)", at, b);
            double ans = e2.calculate();
            Console.WriteLine(ans);
            //textBox2.Text = ans.ToString();
           // Console.ReadKey();
        }
    }
}
