using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace absoluteFilePath
{
    class Program
    {
    
        static void Main(string[] args)
        {

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            //DirectoryInfo di = new DirectoryInfo(@"C:\");
            //di.Create();
            FileStream fs = new FileStream(appPath, FileMode.OpenOrCreate);
            fs.WriteByte(65);
       
            
            
          
        }
       
    }
}
