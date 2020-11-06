using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadingMultipleFiles
{
    class Program
    {
        static void Main(string[] args)
        { int x=0;
            string s="";
            StreamReader sr;
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\jalal\Desktop\Sundas Project");
            FileInfo[] f = d.GetFiles();
            for (int i = 0; i <f.Length; i++)
            {
                string d1 = f[i].FullName;
                sr=new StreamReader(d1);
                //Console.WriteLine(sr.ReadToEnd());
                for (int k = 0; k < 3; k++)
                {
                    s += sr.ReadLine()+"7";
                      
                    
                }
            s+="-";
           
                                
            }
            string []xl=s.Split('-');
            for (int i = 0; i <xl.Length; i++)
            
            {

                Console.WriteLine(xl[i]);

            }
            //for (int i = 0; i <x; i++)
            //{ 
            //    if (s[i] =="\n")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(s[i]);
            //}
        }
    }
}
