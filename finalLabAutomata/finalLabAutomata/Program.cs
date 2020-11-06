using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalLabAutomata
{
    class Program
    {
        static void Main(string[] args)
        {
              int[,] x = new int[4, 4];
            Random r=new Random();
            
            int rand = 0;
            //Auto Generated Table
            for (int i = 0; i < x.GetLength(0); i++)
            {   
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    rand = r.Next(1, 17);
                    x[i, j] = rand;
                }
            }
            //Printing Table
            for (int i = 0; i <x.GetLength(0); i++)
            {
                for (int j = 0; j <x.GetLength(1); j++)
                {
                    Console.Write(x[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Move  up    by 0");
            Console.WriteLine("Move  left  by 1");
            Console.WriteLine("Move  down  by 2");
            Console.WriteLine("Move  right by 3");
            Console.WriteLine();
            //Player 1 play
            Console.WriteLine("Player 1 Turn");
            int p1 = PlayerScore(x);
            Console.WriteLine("Player1 Total Score {0}",p1);
            Console.WriteLine();
            //Player 2 play
            Console.WriteLine("Player 2 Turn");
            int p2 = PlayerScore(x);
            Console.WriteLine();
            Console.WriteLine("Player2 Total Score {0}",p2);
            Console.WriteLine();
            Console.WriteLine("Player1 score={0} Player2 score={1}",p1,p2);
            Console.WriteLine();
            Console.WriteLine();
            //Winner
            CompareScores(p1, p2);
          
             
            
         
        }
        public static void CompareScores(int p1, int p2)
        {
              if (p1 > p2)
            {
                Console.WriteLine("Player 1 won");
            }
              else if (p2 > p1)
              {
                  Console.WriteLine("Player 2 won");
              }
              else
              {
                  Console.WriteLine("Draw");
              }

        }
 public static int PlayerScore(int [,]x)
        {
            string l;
            int sum = 0;
            bool check = true;
            int c = 0;
            int i = 0, j = 0;
     Console.WriteLine();
            for (int k = 1; k <= 3; k++)
            {
                
                Console.Write("Enter String:");
                l = Console.ReadLine();
                while (c < l.Length)
                {

                    if (l[c] == '0')
                    {
                        if (i == 0)
                        {
                            c++;
                            continue;
                        }
                        i--;
                    }
                    else if (l[c] == '1')
                    {
                        if (j == 0)
                        {
                            c++;
                            continue;
                        }
                        j--;
                    }

                    else if (l[c] == '2')
                    {
                        if (i == x.GetLength(0) - 1)
                        {
                            c++;
                            continue;
                        }
                       i++;
                    }
                    else if (l[c] == '3')
                    {
                        if (j == x.GetLength(0) - 1)
                        {
                            c++;
                            continue;
                        }
                        j++;
                    }
                 
                    else if(l=="^")
                    {
                        //Console.WriteLine("Wrong string input Type 0,1,2,3");
                       
                           
                
                        break;

                    }
                    else 
                    {
                       
                        Console.WriteLine("Wrong string input Type 0,1,2,3");
                        check = false;
                        break;
                  


               

                    }
                    c++;
                }
                c = 0;
                if (check)
                {
                    sum += x[i, j];
                    Console.WriteLine("Score is {0}", x[i, j]);
                }
                i = 0; j = 0;
            }
            return sum;
 }
        }
    }

