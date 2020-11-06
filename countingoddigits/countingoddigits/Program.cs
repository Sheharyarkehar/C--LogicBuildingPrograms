using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countingoddigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1234,count=0;
            while(num!=0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
