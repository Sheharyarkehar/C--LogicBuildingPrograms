using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\jalal\Desktop\q\q1.txt");
            StreamWriter wr = new StreamWriter(@"C:\Users\jalal\Desktop\q\q2.txt");
            List<string>q1=new List<string>();
            List<string> a1 = new List<string>();
            q1.Add(sr.ReadLine());
            q1.Add(sr.ReadLine());
            q1.Add(sr.ReadLine());
            q1.Add("Q1:How are you");
            q1.Add("Q1:How are you");
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in q1)
            {
                a1.Add(Console.ReadLine());
            }
            foreach (var item in a1)
            {
                wr.WriteLine(item);
            }
            wr.Close();

        }
    }
}
