using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "abc";
            //char[] a1 = a.ToCharArray();
            //// string b = "";
            //int c = a1[a1.Length - 1] ^ 57;
            //a1[a1.Length - 1] = Convert.ToChar(c);
            //StreamWriter s = new System.IO.StreamWriter(@"C:\Users\jalal\Desktop\sundas.txt");
            //for (int i = 0; i < a.Length; i++)
            //{

            //    s.Write(a1[i]);
            //}
            //s.Close();


            StreamReader s = new System.IO.StreamReader(@"C:\Users\jalal\Desktop\sundas.txt");
            char[] a1 = s.ReadToEnd().ToCharArray();
            int c = a1[a1.Length - 1] ^ 57;
            a1[a1.Length - 1] = (char)c;
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i]);
            }
        }
    }
}
