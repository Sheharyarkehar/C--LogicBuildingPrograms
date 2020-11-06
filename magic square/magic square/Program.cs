using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.Write("Enter the order of Magic Square(Enter an Odd Number): ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c % 2 != 0)
            {
                if (c != 1)
                {
                    int[,] ms = new int[c, c];
                    ms[0, (c - 1) / 2] = a;
                    for (int i = 0; i > -1; )
                    {
                        for (int j = (c - 1) / 2; j <= c; )
                        {
                            i--;
                            j++;
                            if (i < 0) i = c - 1;
                            if (j > c - 1) j = 0;
                            if (ms[i, j] > 0)
                            {
                                i = i + 2;
                                j--;
                            }
                            if (i > c) i = 1;
                            if (j < 0) j = c - 1;
                            a = a + 1;
                            ms[i, j] = a;
                            if (a >= Math.Pow(c, 2)) break;
                        }
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("..........*YOUR MAGIC SQUARE*..........");
                    Console.WriteLine();
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write("");
                        for (int j = 0; j < c; j++)
                        {
                            Console.Write(ms[i, j]+"\t");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Sorry, Magic Square Cant be Form....!");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sorry, Magic Square Cant be Form.... Input Integer is Not an Odd Number");
            }
        }
    }
}
