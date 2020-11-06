using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace filing_File_Stream_Class_
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream f = new FileStream(@"C:\Users\jalal\Desktop\file1.txt",FileMode.OpenOrCreate);
         
            //string a="Shery";
            //byte[]d={83,72,69,82,89};
            //for (int i = 0; i <d.Length; i++)
            //{
            //    f.WriteByte(d[i]);
            //} 

            //int i = 0;
            //while ((i=f.ReadByte()) != -1)
            //{
            //    Console.WriteLine((char)i);
            //}

            //StreamWriter sw = new StreamWriter(f);
            //sw.WriteLine("Shery here kia hal hain");
            //sw.Close();

           // StreamReader sr = new StreamReader(f);
            //string ans = sr.ReadLine();
            //Console.WriteLine(ans);
           
            //string line = "";
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //} 
            //string fileName = @"C:\Users\jalal\Desktop\file1.txt";
            //using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            //{
            //    writer.Write(10);
            //    writer.Write("this is string data");
            //    writer.Write(true);
            //}
            //Console.WriteLine("Data written successfully...");
            //sr.Close();
            //    f.Close();
            //string loc = @"C:\Users\jalal\Desktop\file2.txt";
            //// Creating FileInfo instance  
            //FileInfo file = new FileInfo(loc);
            //// Creating an empty file  
            //file.Create();
            //Console.WriteLine("File is created Successfuly");  DirectoryInfo directory = new DirectoryInfo(@"F:\javatpoint");  
              DirectoryInfo directory = new DirectoryInfo(@"C:\Users\jalal\Desktop\Shery");
            try
            {
                // Check, directory exist or not.  
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist");
                    return;
                }
                // Creating a new directory.  
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }  
        }
    }
}
