using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ans = new Rectangle(); Rectangle r1 = new Rectangle(2.2,4.5); Rectangle r2 = new Rectangle(4.1,2.5);
            ans = r1 + r2;
            ans.Display();
        }
    }
}
