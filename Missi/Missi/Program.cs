using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missi
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Mississipi";
          //  List<char> tempChar = new List<char>();
            char[] b = new char[10];

            int arrCount = 0;
            for (int i = 0; i <a.Length; i++)
            {
                if(a.IndexOf(a[i])!=a.LastIndexOf(a[i]) && !b.Contains(a[i]))
                {
                    b[arrCount++] = a[i];
                    Console.WriteLine(a[i]);
                }
            }

        }
    }
}
