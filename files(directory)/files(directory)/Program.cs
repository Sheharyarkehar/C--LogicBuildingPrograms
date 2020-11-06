using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace files_directory_
{
    class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText(@"C:\Users\jalal\Desktop\Binaryfile1.txt", "Hello fraand");
           
            //string fileName = @"C:\Users\jalal\Desktop\Binaryfile.txt";  
            //using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))  
            //{  
            //    writer.Write(2.5);  
            //    writer.Write("this is string data");  
            //    writer.Write(true);  
            //}  
            //Console.WriteLine("Data written successfully...");

            //using (BinaryReader reader = new BinaryReader(File.Open(@"C:\Users\jalal\Desktop\Binaryfile.txt", FileMode.Open)))
            //{
            //    Console.WriteLine("Double Value : " + reader.ReadDouble());
            //    Console.WriteLine("String Value : " + reader.ReadString());
            //   // Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            //}  


            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\jalal\Desktop\Maha");
            //dir.Create();
            ////FileInfo[] files = dir.GetFiles();
            ////string FileName = "";
            ////long max = 0;
            ////for (int i = 0; i <files.Length; i++)
            ////{
            ////    if (max < files[i].Length)
            ////    {
            ////        max = files[i].Length;
            ////        FileName = files[i].ToString();
            ////    }
                
            ////}
            ////System.Console.WriteLine(Application.ExecutablePath);
            ////Console.WriteLine(FileName+": size="+max);


        }
    }
}
