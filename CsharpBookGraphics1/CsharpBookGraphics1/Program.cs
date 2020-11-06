using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CsharpBookGraphics1
{
    class Program
    {
        static void Main(string[] args)
        {
              Form f = new Form();
             f.Paint += new PaintEventHandler(MyColorEvent);
            f.Paint += new PaintEventHandler(MyTextEvent);
         
            f.Show();
            Application.Run(f);

        }
        
        public static void MyColorEvent(object sender,PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            grfx.Clear(Color.Chocolate);
        }
        public static void MyTextEvent(object sender, PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;

            Form form = (Form)sender;
            //float x=0.0f;
            //float y=0.0f;
            grfx.DrawString("Shery",form.Font, Brushes.Black, 50, 50);


        }
    }
}
