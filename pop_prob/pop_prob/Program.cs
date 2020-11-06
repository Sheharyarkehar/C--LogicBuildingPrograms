using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pop_prob
{
    class Program
    {
        static void Main(string[] args)
        {  
            #region Population

            int  MenIlliterate, WomenIlliterate;
            const int Pop = 80000;
            MenIlliterate = Pop * 17 / 100;
            WomenIlliterate = Pop * 35 / 100;
            Console.WriteLine("Total Popullation is {0}",Pop);
            Console.WriteLine("Total literacy Rate is 48%");
            Console.WriteLine("Total Illiterate Men are {0}",MenIlliterate );
            Console.WriteLine("Total Illiterate Women are {0}", WomenIlliterate);

           #endregion
            
        }
    }
}
