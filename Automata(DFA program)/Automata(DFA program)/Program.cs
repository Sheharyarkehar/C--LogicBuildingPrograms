using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_DFA_program_
{
    class Program
    {
        static void Main(string[] args)
        {  
            int noOfStates=2,noOfTransitions=4;
            string inp = "aab";
            int x=0;
            int[] f = { 0, 0, 0, 1 };
            int []t=new int[inp.Length];
                for (int i = 0; i <inp.Length; i++)
			{
			    t[x++]=i;
			}
            x--;
            int[,] arr = new int[noOfTransitions,noOfStates];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {   
                for (int j = 0; j < arr.GetLength(1); j++)
                {   if (i>=0&&i<=x)
                    {
                        int l = arr[i, j];
                        Console.Write(arr[l, i]);
                    }
                    //Console.Write(arr[i,j]);
                    //int l = arr[i, j];
                    //Console.Write(arr[l,j]+"  "+inp[l]);


                    //if (arr[i, j] == t[i] && f[j] == 0)
                    //{



                    //}

                    //else if (arr[i, j] == t[j] && f[j] == 1)
                    //{
                    //    break;
                    //}

                }
                Console.WriteLine();
            }
            
        }
    }
}
