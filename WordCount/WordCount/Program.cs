using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            string name = "The Tech Valley";
            for (int i = 0; i <name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Total words:"+count);
        }
    }
}
