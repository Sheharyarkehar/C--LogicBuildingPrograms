using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automata7
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            Console.WriteLine("Enter divisor");
            int n = int.Parse(Console.ReadLine());
            string[,] c = new string[n+1,n];

            for (int i = 0; i < n; i++)
            {
                ans = i % n;
                Console.WriteLine(ans);
                c[i, c.GetLength(1) - 1] = ans.ToString();


            }
            for (int i = 0; i < c.GetLength(0)-1; i++)
            {
                for (int j = 0; j < c.GetLength(1)-1; j++)
                {
                    c[i, j] = Console.ReadLine();
                }
                Console.WriteLine();

            }

            Console.WriteLine("Present state\t|0\t\t|1\t\toutput");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j <c.GetLength(1); j++)
                {
                    Console.Write(c[i,j]+"\t\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Enter binry");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {  
                    if (j == 1)
                    {
                        i = 1;
                        Console.WriteLine(c[i, j]);
                        break;
                    }
                    if (j == 2)
                    {
                        i = 2;
                        Console.WriteLine(c[i, j]);
                    }
                    if (j == 3)
                    {
                        i = 3;
                        Console.WriteLine(c[i, j]);
                    }
                    if (j == 4)
                    {
                        i = 4;
                        Console.WriteLine(c[i, j]);
                    }

                }
                Console.WriteLine();

            }
            
        }
    }
}
