using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automata10try
{
    class Program
    {
        static void Main(string[] args)
        {

            bool checkst1 = false;
            bool checkst2 = false;
            bool checkst3 = false;
            bool checkst4 = false;
            int[,] x = new int[4, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
            int sum = 0;
            int row = 0, col = 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + "\t");
                }
                Console.WriteLine();
            }
            string l = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < x.GetLength(0); i++)
            {

                for (int j = 0; j < x.GetLength(1); j++, c++)
                {
                    if (c > l.Length - 1)
                    {
                        break;
                    }
                    //st1
                    if (l[c] == '0' && i == 0 || l[c] == '1' && i == 0)
                    {
                        row = 0;
                        col = j;
                        checkst1 = true;

                    }
                    else if (l[c] == '2' && i == 0)
                    {

                        row = 1;
                        col = j;
                        checkst1 = false;

                    }
                    else if (l[c] == '3' && i == 0)
                    {
                        row = 0;
                        col = j;
                        checkst1 = false;
                    }
                    //st2
                    else if (l[c] == '0' && i == 1)
                    {
                        row = 0;
                        col = j;
                        checkst2 = true;

                    }
                    else if (l[c] == '1' && i == 1)
                    {
                        row = 1;
                        col = j;
                    }
                    else if (l[c] == '2' && i == 1)
                    {
                        row = 2;
                        col = j;
                        checkst2 = false;

                    }
                    else if (l[c] == '3' && i == 1)
                    {
                        row = 1;
                        col = j;
                        checkst2 = false;

                    }
                    //st3
                    else if (l[c] == '0' && i == 2)
                    {
                        row = 1;
                        col = j;
                        checkst3 = true;

                    }
                    else if (l[c] == '1' && i == 2)
                    {
                        row = 2;
                        col = j;
                    }
                    else if (l[c] == '2' && i == 2)
                    {
                        row = 3;
                        col = j;


                        checkst3 = false;

                    }
                    else if (l[c] == '3' && i == 2)
                    {
                        row = 2;
                        col = j;
                        checkst3 = false;

                    }
                    //st4
                    else if (l[c] == '0' && i == 3)
                    {
                        row = 2;
                        col = j;
                        checkst4 = true;

                    }
                    else if (l[c] == '1' && i == 3)
                    {
                        row = 3;
                        col = j;
                    }
                    else if (l[c] == '2' && i == 3)
                    {
                        row = 3;
                        col = j;
                        checkst4 = false;

                    }
                    else if (l[c] == '3' && i == 3)
                    {
                        row = 3;
                        col = j;
                        checkst4 = false;

                    }

                }

                Console.WriteLine();
            }
            sum = x[row, col];
            Console.WriteLine(sum);




        }
    }
}
