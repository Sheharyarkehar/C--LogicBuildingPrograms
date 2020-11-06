using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            for (int i = 0; i<=n+1; i++)
            {
                for(int j=1;j<=10;j++)
    {
        Console.WriteLine("{0}*{1}={2}",n,j,n*j);
        if (j == 10)
        {
            n--;
        }
    }
                Console.WriteLine();
            }

        }
    }
}
