using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using CSCore.Codecs.MP3;
namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            CSCore.Codecs.MP3.Mp3Format x=new CSCore.Codecs.MP3.Mp3Format
            //SoundPlayer s = new SoundPlayer(@"D:\jalal shadi songs sindhi\AUD-20190112-WA0083.mp3");
            //s.Play();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\jalal\Desktop\Songs(sundas)");
            FileInfo[] fi = di.GetFiles();
            string path = "";
            string fpath = @"C:\Users\jalal\Desktop\Songs(sundas)\";
            SoundPlayer sp = new SoundPlayer(); ;         
                      Console.WriteLine(" Start Audio Songs");
                      string game = "";
                    
           do
           {
               Console.WriteLine(@"Type ""start"" for opening the songs");
               Console.WriteLine(@"Type ""list"" for songs list");
               Console.WriteLine(@"Type ""stop"" for stopping the song");
               Console.WriteLine(@"Type ""exit"" for stopping the song");
               Console.WriteLine();
               Console.WriteLine("Enter Your option");
               game = Console.ReadLine();
               switch (game.ToLower())
               {

                   case "start":
                       Console.Clear();
                       for (int i = 0; i < fi.Length; i++)
                       {

                           Console.WriteLine(i + " ." + fi[i]);


                       }
                       Console.WriteLine();
                       Console.WriteLine("Enter your choice in list");
                       int inp = int.Parse(Console.ReadLine());
                   path = fpath + fi[inp].ToString();
                           sp = new SoundPlayer(path);
                           sp.Play();
                       break;


                   case "list":
                       Console.Clear();
                       Console.WriteLine();
                       Console.WriteLine("List of Songs to play");
                       for (int i = 0; i < fi.Length; i++)
                       {

                           Console.WriteLine(i + ". " + fi[i]);


                       }
                       break;
                   case "stop":
                       //sp = new SoundPlayer(path);
                       sp.Stop();
                       break;
                 

               }
           }
           while (game != "exit");
        }
    }
}