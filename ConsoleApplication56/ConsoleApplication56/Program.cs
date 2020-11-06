using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Umaer", " Basha", " Institute", " Of", " Information", " Technology" };
            for (int i = 0; i <input.Length; i++)
            {

                for (int j= 0; j <=i; j++)
                {
                    Console.Write(input[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
