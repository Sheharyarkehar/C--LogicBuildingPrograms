using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNDAS_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write( "enter your health is excellent ");
            //string health = Console.ReadLine();
            //string live = Console.ReadLine();
            //string gender = Console.ReadLine();
            //Console.Write("enter your age");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if ((a <= 25) && (a >= 35))
            //{
            //    Console.WriteLine();
            //}
            //if( (health=="yes")||(health=="no"))   
            //{
            //    Console.WriteLine();
            //int n = 4737;
            //Console.WriteLine(n);
            //int r = n % 10;
            //int d = n / 10;
            //int r1 = d % 10;
            //int d1 = d / 10;
            //int r2 = d1 % 10;
            //int d2 = d1 / 10;
            //int r3 = d2 % 10;
            //int sum = (r + r1 + r2 + r3);
            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine(n + "0");
            //}
            //else if (sum % 2 != 0)
            //{
            //    Console.WriteLine(n+"1");
            //}
            int sum = 0;
            int count=0;
            int average = 0;
            int n = Convert.ToInt32(Console.ReadLine());
      

while (n >= 0)
{
    sum = sum + n;
    n = Convert.ToInt32(Console.ReadLine());
    count++;
}
            average=sum/count;
Console.WriteLine("average {0}",average);
                
        }
    }
}
