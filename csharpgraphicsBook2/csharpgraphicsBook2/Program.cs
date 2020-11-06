using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace csharpgraphicsBook2
{
    class Program
    {
        static Form f1, f2;
        static void Main(string[] args)
        {
             f1=new Form();
            f1.Paint += new PaintEventHandler(MyEventHandler);
            f1.Text = "Form1";
            f2 = new Form();
            f2.Text = "Form2";
            f2.Paint += new PaintEventHandler(MyEventHandler);
            f2.Show();
            Application.Run(f1);


        }
        public static void MyEventHandler(object sender,PaintEventArgs pea)
        {
            Form f=(Form)sender;
            Graphics grfx = pea.Graphics;
            string str = "";
            if (f == f1)
            {
                str = "Form1 me hun me";
                grfx.DrawString(str, f.Font, Brushes.Blue, 0, 0);
            }
            else if (f == f2)
            {
                str = "Form2me hun me";
                grfx.DrawString(str, f.Font, Brushes.Blue, 0, 0);
            }
           
        }
    }
}
