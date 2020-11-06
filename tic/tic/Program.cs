using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic
{
    class Program
    {
        static void Main(string[] args)
        {
            char a=' ';
     while(a!='X'||a!='O')
     {
          a = char.Parse(Console.ReadLine());

         for (int i = 0; i < 5; i++)
         {

             for (int j = 0; j < 5; j++)
             {
                 if (a == 'X')
                 {
                     Console.Write(a);
                     a = char.Parse(Console.ReadLine());

                 }
                 else if (a == 'O')
                 {
                     Console.Write(a);
                     a = char.Parse(Console.ReadLine());

                 }
                 Console.WriteLine();

             }
         }
            }
        }
    }
}
