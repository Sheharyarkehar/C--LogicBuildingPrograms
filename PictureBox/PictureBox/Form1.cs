using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                timer1.Enabled=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            double d = c.GetSaturation();
           textBox1.Text = d.ToString();
            
            for (int count = 2; count<=100;count+=2)
            {


                if (count == 2)
                {
                    pictureBox1.Image = PictureBox.Properties.Resources._333333;
                   

                }
                if (count == 10)
                {

                    pictureBox1.Image = PictureBox.Properties.Resources._445;
             

                }
                if (count == 20)
                {

                    pictureBox1.Image = PictureBox.Properties.Resources._4454545;
                }
                    if (count == 30)
                    {

                        pictureBox1.Image = PictureBox.Properties.Resources.computer;

                    }
                    if (count == 40)
                    {
                        pictureBox1.Image = PictureBox.Properties.Resources.ham;

                    }
                    if (count == 50)
                    {

                        pictureBox1.Image = PictureBox.Properties.Resources.mur;

                    }
                    if (count == 60)
                    {

                        pictureBox1.Image = PictureBox.Properties.Resources.raj;

                    }
                    if (count == 70)
                    {
                        pictureBox1.Image = PictureBox.Properties.Resources.shery;

                    }
                }

            }
           
    

        private void timer1_Tick(object sender, EventArgs e)
        { 
           
            
            }
        
        
    }
}
