using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace csharpgraphicsbook3
{


    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.Run(new Program());


        }
        public Program()
        {
           // BackColor = Color.Wheat;
            this.Text = "My Colors";
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            StringFormat stfrmt = new StringFormat();
            stfrmt.Alignment = StringAlignment.Far;
            stfrmt.LineAlignment = StringAlignment.Far;
            grfx.DrawString("RightNche", Font, new SolidBrush(Color.DodgerBlue), ClientSize.Width, ClientSize.Height, stfrmt);

            stfrmt.Alignment = StringAlignment.Near;
            stfrmt.LineAlignment = StringAlignment.Far;
            grfx.DrawString("LefttNche", Font, new SolidBrush(Color.Red),0, ClientSize.Height, stfrmt);



            //stfrmt.Alignment = StringAlignment.Near;
            //stfrmt.LineAlignment = StringAlignment.Far;
            grfx.DrawString("Lefttuuper", Font, new SolidBrush(Color.RosyBrown), 0, 0);




            stfrmt.Alignment = StringAlignment.Far;
            stfrmt.LineAlignment = StringAlignment.Near;
            grfx.DrawString("Rightuuper", Font, new SolidBrush(Color.Purple), ClientSize.Width, 0, stfrmt);




            stfrmt.Alignment = StringAlignment.Center;
            stfrmt.LineAlignment = StringAlignment.Center;
            grfx.DrawString("Rightuuper", Font, new SolidBrush(Color.Salmon), ClientSize.Width/2,ClientSize.Height/2,stfrmt);



        }

//        protected override void OnPaint(PaintEventArgs e)
//{
//    Graphics grfx=e.Graphics;
//            grfx.DrawString("Hi My Class",Font,Brushes.Brown,0,0);
//}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Graphics grfx = e.Graphics;
        //    Random r = new Random();
        //   grfx.Clear(Color.FromArgb(r.Next(256),r.Next(256),r.Next(256)));
        //    //grfx.DrawImage(Image.FromFile(@"C:\Users\jalal\Desktop\Images\psl points table.PNG"), 0, 0, 800, 600);
           
        //}
        //public static void MyEventHandler(object sender, PaintEventArgs pea)
        //{
        //    Form f = (Form)sender;
        //    Graphics grfx = pea.Graphics;
        //    string str = "";
        //    if (f == f1)
        //    {
        //        str = "Form1 me hun me";
        //        grfx.DrawString(str, f.Font, Brushes.Blue, 0, 0);
        //    }
        //    else if (f == f2)
        //    {
        //        str = "Form2me hun me";
        //        grfx.DrawString(str, f.Font, Brushes.Blue, 0, 0);
        //    }
        }
    }
