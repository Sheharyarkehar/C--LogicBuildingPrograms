using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace region1
{
    class Program
    {
        static void Main(string[] args)
        {
          #region shery
            int a=3;
            int b=4;
           int c = b++ + ++a;
          #endregion
            #region b
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

          #endregion
        }
    }
    #region a
    class abc
    {
        static void a()
        {

        }

    }
#endregion

}
