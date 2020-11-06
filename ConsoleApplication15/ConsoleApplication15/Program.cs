using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func());

        }
        public static int Func()
        { char opt=Convert.ToChar(Console.ReadLine());
        int ans=0;
        if (opt == 'p')
        {
            int no = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            ans = no + no2;
           
        }
        if (opt == 's')
        {
            int no = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            ans = no - no2;

        }
        if (opt == 'm')
        {
            int no = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            ans = no * no2;

        }
        return ans;

        }
    }
}
