using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            int j = 0;
            int c = 0;
            int sum1 = 0;
          //  int sum2 = 0;
           // Random r = new Random();
            int[,] x = new int[4, 4]{{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
            //for (int i = 0; i < x.GetLength(0); i++)
            //{

            //    for (j = 0; j < x.GetLength(1); j++)
            //    {
            //        int l = r.Next(1, 17);
            //        x[i, j] = l;

            //    }
            //}
            int sum = 0;

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Move  up    by    0");
            Console.WriteLine("Move  left  by    1");
            Console.WriteLine("Move  down  by    2");
            Console.WriteLine("Move  right by    3");
            string inp = "";
            Console.WriteLine();
            Console.WriteLine("Player 1 turn");
            Console.WriteLine();
            for (int l = 1; l <=3; l++)
            {
                Console.Write("Enter string:");
                inp = Console.ReadLine();
                for (int i = 0; i < x.GetLength(0); i++)
                {

                    for (j = 0; j < x.GetLength(1); j++, c++)
                    {
                        if (c > inp.Length - 1)
                        {
                            break;

                        }
                        else if (i == 0 && j == 0 && inp[c] == '0' || i == 0 && j == 0 && inp[c] == '1')
                        {
                            sum += x[i, j];
                            check = true;
                        }
                        else if (i == 0 && j == 0 && inp[c] == '2')
                        {
                            sum += x[i+1, j];
                           
                        }
                        else if (i == 0 && j == 0 && inp[c] == '3')
                        {
                            sum += x[i, j+1];

                        }
                       
                        else if (i == 0 && j == 1 && inp[c] == '0' && check || i == 0 && j == 1 && inp[c] == '1' && check)
                        {
                            sum += x[i, j - 1];
                            check = true;
                        }
                        else if (i == 0 && j == 2 && inp[c] == '0' && check || i == 0 && j == 2 && inp[c] == '1' && check)
                        {
                            sum += x[i, j - 2];
                            check = true;
                        }
                        else if (i == 0 && j == 3 && inp[c] == '0' && check || i == 0 && j == 3 && inp[c] == '1' && check)
                        {
                            sum += x[i, j - 3];
                            check = true;
                        }
                        else if (i == 1 && j == 0 && inp[c] == '0' && check || i == 1 && j == 2 && inp[c] == '1' && check || i == 1 && j == 3 && inp[c] == '1' && check)
                        {
                            sum += x[i - 1, j];
                            check = true;
                        }
                        else if (i == 0 && j == 1 && inp[c] == '0' || i == 0 && j == 2 && inp[c] == '0' || i == 0 && j == 3 && inp[c] == '0')
                        {
                            sum += x[i, j];
                        }
                        else if (i == 0 && j == 1 && inp[c] == '1' || i == 0 && j == 2 && inp[c] == '1' || i == 0 && j == 3 && inp[c] == '1')
                        {
                            sum += x[i, j - 1];
                        }
                        else if (i == 0 && j == 1 && inp[c] == '2' || i == 0 && j == 2 && inp[c] == '2' || i == 0 && j == 3 && inp[c] == '2' && check)
                        {
                            sum += x[i + 1, j - 3];
                        }

                        else if (i == 0 && j == 1 && inp[c] == '2' || i == 0 && j == 2 && inp[c] == '2' || i == 0 && j == 3 && inp[c] == '2')
                        {
                            sum += x[i + 1, j];
                        }
                        else if (i == 0 && j == 1 && inp[c] == '3' || i == 0 && j == 2 && inp[c] == '3' || i == 0 && j == 3 && inp[c] == '3')
                        {
                            sum += x[i, j + 1];
                        }
                        //else if (i == 1 && j == 0 && inp[c] == '0' || i == 1 && j == 1 && inp[c] == '0' || i == 1 && j == 2 && inp[c] == '0' && check)
                        //{
                        //    sum += x[i - 1, j - 1];
                        //}
                        else if (i == 1 && j == 0 && inp[c] == '0' || i == 1 && j == 1 && inp[c] == '0' || i == 1 && j == 2 && inp[c] == '0')
                        {
                            sum += x[i - 1, j];
                        }
                        else if (i == 1 && j == 0 && inp[c] == '1')
                        {
                            sum += x[i, j];
                        }
                        else if (i == 1 && j == 0 && inp[c] == '2' && check)
                        {
                            sum += x[i, j];
                        }
                        else if (i == 1 && j == 0 && inp[c] == '2')
                        {
                            sum += x[i + 1, j];
                        }
                        else if (i == 1 && j == 1 && inp[c] == '3' && check)
                        {
                            sum += x[i, j];
                        }
                        else if (i == 1 && j == 0 && inp[c] == '3')
                        {
                            sum += x[i, j + 1];
                        }
                        else if (i == 1 && j == 1 && inp[c] == '1' || i == 1 && j == 2 &&
                            inp[c] == '1' || i == 1 && j == 2 && inp[c] == '1' || i == 1 && j == 3 && inp[c] == '1')
                        {
                            sum += x[i, j - 1];
                        }
                        else if (i == 1 && j == 1 && inp[c] == '2' || i == 1 && j == 2 & inp[c] == '2' || i == 1 && j == 3 & inp[c] == '2')
                        {
                            sum += x[i + 1, j];
                        }
                        else if (i == 1 && j == 0 && inp[c] == '3' || i == 1 && j == 1 && inp[c] == '3' || j == 2 && inp[c] == '3')
                        {
                            sum += x[i, j + 1];
                        }
                        else if (i == 1 && j == 3 && inp[c] == '3')
                        {
                            sum += x[i, j];
                        }
                        else if (i == 2 && j == 0 && inp[c] == '0' || i == 2 && j == 1 && inp[c] == '0' || i == 2 && j == 2 && inp[c] == '0')
                        {
                            sum += x[i - 1, j];
                        }
                        else if (i == 2 && j == 0 && inp[c] == '1')
                        {
                            sum += x[i, j];
                        }
                        else if (i == 2 && j == 1 && inp[c] == '1' || i == 2 && j == 2 && inp[c] == '1' || i == 2 && j == 3 && inp[c] == '1')
                        {
                            sum += x[i, j - 1];
                        }
                        else if (i == 2 && j == 0 && inp[c] == '2' || i == 2 && j == 1 &&
                            inp[c] == '2' || i == 2 && j == 2 && inp[c] == '2' || i == 2 && j == 3 && inp[c] == '2')
                        {
                            sum += x[i + 1, j];
                        }
                        else if (i == 2 && j == 0 && inp[c] == '3' || i == 2 && j == 1 && inp[c] == '3' || i == 2 && j == 2 && inp[c] == '3')
                        {
                            sum += x[i, j + 1];
                        }
                        else if (i == 3 && j == 0 && inp[c] == '1')
                        {
                            sum += x[i, j];
                        }
                        else if (i == 3 && j == 1 && inp[c] == '1' || i == 3 && j == 2 && inp[c] == '1' || i == 3 && j == 3 && inp[c] == '1')
                        {
                            sum += x[i, j - 1];
                        }
                        else if (i == 3 && j == 0 && inp[c] == '2' || i == 3 && j == 1 && inp[c] == '2'
                            || i == 3 && j == 2 && inp[c] == '2' || i == 3 && j == 3 && inp[c] == '2')
                        {
                            sum += x[i, j];
                        }
                        else if (i == 3 && j == 0 && inp[c] == '3' || i == 3 && j == 1 && inp[c] == '3' || i == 3 && j == 2 && inp[c] == '3')
                        {
                            sum += x[i, j + 1];
                        }
                        else if (check)
                        {
                            sum += x[0, 0];
                        }


                    }


                    Console.WriteLine();
                }
                c = 0;
                Console.WriteLine("Score="+sum);
                sum1 += sum;
               
            }
            //Console.WriteLine();
            //Console.WriteLine("Player 2 turn");
            //sum = 0;
            //c = 0;
            //for (int k = 1; k <= 3; k++)
            //{
            //    Console.WriteLine("Enter string");

            //    inp = Console.ReadLine();
            //    for (int i = 0; i < x.GetLength(0); i++)
            //    {

            //        for (j = 0; j < x.GetLength(1); j++, c++)
            //        {
            //            if (c > inp.Length - 1)
            //            {
            //                break;

            //            }
            //            else if (i == 0 && j == 0 && inp[c] == '0' || i == 0 && j == 0 && inp[c] == '1')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 0 && j == 1 && inp[c] == '0' || i == 0 && j == 2 && inp[c] == '0' || i == 0 && j == 3 && inp[c] == '0')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 0 && j == 1 && inp[c] == '1' || i == 0 && j == 2 && inp[c] == '1' || i == 0 && j == 3 && inp[c] == '1')
            //            {
            //                sum += x[i, j - 1];
            //            }
            //            else if (i == 0 && j == 1 && inp[c] == '2' || i == 0 && j == 2 && inp[c] == '2' || i == 0 && j == 3 && inp[c] == '2')
            //            {
            //                sum += x[i + 1, j];
            //            }
            //            else if (i == 0 && j == 1 && inp[c] == '3' || i == 0 && j == 2 && inp[c] == '3' || i == 0 && j == 3 && inp[c] == '3')
            //            {
            //                sum += x[i, j + 1];
            //            }
            //            else if (i == 1 && j == 0 && inp[c] == '0' || i == 1 && j == 1 && inp[c] == '0' || i == 1 && j == 2 && inp[c] == '0')
            //            {
            //                sum += x[i - 1, j];
            //            }
            //            else if (i == 1 && j == 0 && inp[c] == '1')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 1 && j == 0 && inp[c] == '2')
            //            {
            //                sum += x[i + 1, j];
            //            }
            //            else if (i == 1 && j == 0 && inp[c] == '3')
            //            {
            //                sum += x[i, j + 1];
            //            }
            //            else if (i == 1 && j == 1 && inp[c] == '1' || i == 1 && j == 2 &&
            //                inp[c] == '1' || i == 1 && j == 2 && inp[c] == '1' || i == 1 && j == 3 && inp[c] == '1')
            //            {
            //                sum += x[i, j - 1];
            //            }
            //            else if (i == 1 && j == 1 && inp[c] == '2' || i == 1 && j == 2 & inp[c] == '2' || i == 1 && j == 3 & inp[c] == '2')
            //            {
            //                sum += x[i + 1, j];
            //            }
            //            else if (i == 1 && j == 0 && inp[c] == '3' || i == 1 && j == 1 && inp[c] == '3' || j == 2 && inp[c] == '3')
            //            {
            //                sum += x[i, j + 1];
            //            }
            //            else if (i == 1 && j == 3 && inp[c] == '3')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 2 && j == 0 && inp[c] == '0' || i == 2 && j == 1 && inp[c] == '0' || i == 2 && j == 2 && inp[c] == '0')
            //            {
            //                sum += x[i - 1, j];
            //            }
            //            else if (i == 2 && j == 0 && inp[c] == '1')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 2 && j == 1 && inp[c] == '1' || i == 2 && j == 2 && inp[c] == '1' || i == 2 && j == 3 && inp[c] == '1')
            //            {
            //                sum += x[i, j - 1];
            //            }
            //            else if (i == 2 && j == 0 && inp[c] == '2' || i == 2 && j == 1 &&
            //                inp[c] == '2' || i == 2 && j == 2 && inp[c] == '2' || i == 2 && j == 3 && inp[c] == '2')
            //            {
            //                sum += x[i + 1, j];
            //            }
            //            else if (i == 2 && j == 0 && inp[c] == '3' || i == 2 && j == 1 && inp[c] == '3' || i == 2 && j == 2 && inp[c] == '3')
            //            {
            //                sum += x[i, j + 1];
            //            }
            //            else if (i == 3 && j == 0 && inp[c] == '1')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 3 && j == 1 && inp[c] == '1' || i == 3 && j == 2 && inp[c] == '1' || i == 3 && j == 3 && inp[c] == '1')
            //            {
            //                sum += x[i, j - 1];
            //            }
            //            else if (i == 3 && j == 0 && inp[c] == '2' || i == 3 && j == 1 && inp[c] == '2'
            //                || i == 3 && j == 2 && inp[c] == '2' || i == 3 && j == 3 && inp[c] == '2')
            //            {
            //                sum += x[i, j];
            //            }
            //            else if (i == 3 && j == 0 && inp[c] == '3' || i == 3 && j == 1 && inp[c] == '3' || i == 3 && j == 2 && inp[c] == '3')
            //            {
            //                sum += x[i, j + 1];
            //            }


            //        }


            //        Console.WriteLine();
            //    }
            //    c = 0;
            //    Console.WriteLine("Score=" + sum);
            //    sum2 += sum;
            //}
            //Console.WriteLine("Player 1 score= " + sum1 + " Player 2 score=" + sum2);
            //if (sum1 > sum2)
            //{
            //    Console.WriteLine("Player 1 won");
            //}
            //else
            //{
            //    Console.WriteLine("Player 2 won");
            //}
        }
       
    }
}
