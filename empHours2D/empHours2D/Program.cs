using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empHours2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] emp = new int[8, 7] { { 2, 4, 3, 4, 5, 8, 8 }, { 7, 3, 4, 3, 3, 4, 4 }, { 3, 3, 4, 3, 3, 2, 2 }, { 9, 3, 4, 7, 3, 4, 1 }, { 3, 5, 4, 3, 6, 3, 8 }, { 3, 4, 4, 6, 3, 4, 4 }, { 3, 7, 4, 8, 3, 8, 4 }, { 6, 3, 5, 9, 2, 7, 9 } };
            int[] hours = new int[8];
            int sum;
            int[] indxx = new int[8];
            for (int i = 0; i < emp.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < emp.GetLength(1); j++)
                {
                    sum += emp[i, j];

                }
                for (int k = i; k <= i; k++)
                {
                    hours[k] = sum;
                    indxx[k] = i;

                }
            }
           
            int temp = 0;
            int temp1;
          
                   
            for (int i = 0; i < hours.Length; i++)
            {

                for (int j = i + 1; j < hours.Length; j++)
                {
                   

                    if (hours[j] > hours[i])
                    {
                                
                        temp1 = indxx[j];
                        indxx[j] = indxx[i];
                        indxx[i] = temp1;
                        temp = hours[j];
                        hours[j] = hours[i];
                        hours[i] = temp;
                        
                        

                    }

                    }


                }
            for (int i = 0; i < hours.Length; i++)
            {
                Console.WriteLine("Emp"+indxx[i]+" "+hours[i]);
            }

        }
    }
}