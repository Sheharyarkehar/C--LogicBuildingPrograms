using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sundaspattern1
{
    class Program
    {
        static void Main(string[] args)  
        {
            int r, c, s;
          int i;
            int l;

            for (r = 4; r >= 1; r--)
            {
                
                for (i = 1, c = r; c >= 1; c--, i++)
                {

                    Console.Write("*");

                }
                for (s = 1; s <= 5 - r; s++)
                {
                    Console.Write("  ");
                }
                for (l = r; l >= 1; l--)
                {
                    // if (Convert.ToChar(64 + l) == 'E')
                    ///{
                    //     continue;
                    //}

                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for (r = 1; r < 5; r++)
            {

                for (i = 1, c = r; c >= 1; c--, i++)
                {

                    Console.Write("*");

                }
                for (s = 1; s <= 5 - r; s++)
                {
                    Console.Write("  ");
                }
                for (l = r; l >= 1; l--)
                {
                    // if (Convert.ToChar(64 + l) == 'E')
                    ///{
                    //     continue;
                    //}

                    Console.Write("*");

                }
                Console.WriteLine();
            }
         
         
             
            }

        }
    }

