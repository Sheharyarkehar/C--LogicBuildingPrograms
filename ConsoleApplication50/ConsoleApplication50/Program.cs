using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Divisor:");
             int m = int.Parse(Console.ReadLine());

             while (m <= 0)
             {

                 Console.WriteLine("Wrong divisor Please  Input again");
                 m = int.Parse(Console.ReadLine());

             }
             Console.Write("Enter the divident :");
             int div = Convert.ToInt32((Console.ReadLine()));
                int countTransitions = 0;
                int[,] inputTable= new int[m, 2];
                int[] output = new int[m];

                Console.WriteLine("States     Transition 0     Transition 1    Output");                
                for (int i = 0; i <inputTable.GetLength(0); i++)
                {
                    for (int j = 0; j < inputTable.GetLength(1); j++)
                    {
                        if (countTransitions > m  - 1)
                        {
                            countTransitions = 0;
                        }


                        inputTable[i, j] = countTransitions;


                        countTransitions++;
                    }
                }
                for (int i = 0; i <inputTable.GetLength(0); i++)

                {
                    Console.Write("q" + i + " ");
                    for (int j = 0; j < inputTable.GetLength(1); j++)
                    {
                        Console.Write("         q" + inputTable[i, j] + "           ");
                    }
                    Console.Write(i + "    ");
                    Console.WriteLine();
                }
                int ans = div % m;

                Console.WriteLine();
                Console.WriteLine("Remainder={0}",ans);
           
            }
        
        }
    
}
