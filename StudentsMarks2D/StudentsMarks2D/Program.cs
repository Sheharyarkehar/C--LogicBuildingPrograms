using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMarks2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Students = new int[8, 10];
            int count=0;
            int[] marks = { 20, 65, 22, 56, 33, 45, 87, 94,32,11};
            for (int i = 0; i < Students.GetLength(0); i++)
            {
                Console.WriteLine("Student {0}",i);
                for (int j = 0; j < Students.GetLength(1); j++)
                {
                    Console.WriteLine("Enter Ans {0}", j);
                    Students[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();

            }
            for (int i = 0; i <Students.GetLength(0); i++)
            {
                count = 0;
                for (int j = 0; j <Students.GetLength(1); j++)
                {
                    if (Students[i, j] == marks[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("Total Correct Ans of Student{0} are {1}",i,count);
            }
        }
    }
}
