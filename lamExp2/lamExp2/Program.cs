using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamExp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> func1 = x => x + 1;
            //
            // Use lambda expression with statement body.
            //
            Func<int, int> func2 = x => { return x + 1; };
            //
            // Use formal parameters with expression body.
            //
            Func<int, int> func3 = (int x) => x + 1;
            //
            // Use parameters with a statement body.
            //
            Func<int, int> func4 = (int x) => { return x + 1; };
            //
            // Use multiple parameters.
            //
            Func<int, int, int> func5 = (x, y) => x * y;
            //
            // Use no parameters in a lambda expression.
            //
            Action func6 = () => Console.WriteLine();
            //
            // Use delegate method expression.
            //
            Func<int, int> func7 = delegate(int x) { return x + 1; };
            //
            // Use delegate expression with no parameter list.
            //
            Func<int> func8 = delegate { return 1 + 1; };
            //
            Func<int, int, int, int> func9 = (x, y, z) => x + y * z;
            Console.WriteLine(func9.Invoke(2, 5, 7));

            //Predicate
            Predicate<int> predicate = value => value == 5;
            Console.WriteLine(predicate.Invoke(4));
         
            Func<int, bool> func11 = x => x == 0;
            Console.WriteLine(func11.Invoke(0));
            int[] a = { 1,2};
            Console.WriteLine(a.Count(element => element ==2));
         
        }
    }
}
