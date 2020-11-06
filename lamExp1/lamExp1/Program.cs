using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamExp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 30, 52, 323, 0 };
            int exp = a.FindIndex(x => x % 2 != 0);
            Console.WriteLine(exp);
        }
    }
}
