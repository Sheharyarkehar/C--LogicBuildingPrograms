using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_Circle_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Graphics lr = this.CreateGraphics();
            Pen pr = new Pen(Color.Aqua, 20);
          
            Pen lp = new Pen(Color.Red,20);
            gr.DrawLine(pr, 10, 200, 200, 10);
            lr.DrawLine(lp, 200, 100, -100, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Pen pr = new Pen(Color.Red, 5);
            
            Rectangle r = new Rectangle(60,130,Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
                      gr.DrawRectangle(pr, r);
                      Brush myBrush = new SolidBrush(Color.RoyalBlue);
                      gr.FillRectangle(myBrush , r);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Pen pr = new Pen(Color.Red, 5);
            Rectangle r = new Rectangle(100, 50, 250, 250);
            gr.DrawEllipse(pr,r);
            Brush myBrush = new SolidBrush(Color.Red);
             //gr.FillEllipse(myBrush, r);
            // gr.DrawArc(pr, r,90.2f, 180.0f);
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
           // Pen pr=new Pen(Color.DeepPink,3);
            Font myFont = new Font("Copperplate Gothic Bold", 20, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.DodgerBlue);
            //Image b=Image.FromFile(@"C:\Users\jalal\Desktop\prev_website\images\shery.jpg");
            //myBrush = new TextureBrush(b);
            gr.DrawString(textBox3.Text, myFont, myBrush, 160, 150);
            //gr.FillRectangle(myBrush, 20,10, 1000, 500);

          
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // PictureBox p = new PictureBox();

            pictureBox1.Image = Image.FromFile(@"C:\Users\jalal\Desktop\prev_website\images\4454545.png");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
             Pen pr=new Pen(Color.DeepPink,3);
            Random r=new Random();
            for (int i = 0; i <30; i++)
            {
                gr.DrawEllipse(pr,200, 100, 100, 200);
                gr.RotateTransform(i * 180 /360);
             

                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Pen pr = new Pen(Color.DeepPink, 3);
           // gr.DrawPie(pr, 90, 80, 140, 40,120, 100);
            gr.DrawPolygon(pr, new Point[]{
new Point(30,140),
new Point(270,250),
new Point(110,240),
new Point(200,170),
new Point(70,350),
new Point(50,200),
            new Point(50,200),
        new Point(21,20),
        new Point(50,100),
        new Point(211,220)});
        }
    }
}