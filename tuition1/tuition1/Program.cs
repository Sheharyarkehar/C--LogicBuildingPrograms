using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuition1
{
    class Program
    {
        static void Main(string[] args)
        {
            double score;
            double a=0;
            string b=" " , name;
            score= Convert.ToDouble(Console.ReadLine());
            while (score >= 0)
            {
                
                name = Console.ReadLine();
                score = Convert.ToDouble(Console.ReadLine());
                if (score > a)
                {
                    a = score;
                    b = name;
                }
            }
            Console.WriteLine("{0} got highest marks {1}", b,a);
        }
    }
}
