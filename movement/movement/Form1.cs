using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //timer1.Enabled = true;
            //timer1.Start();
            if (e.KeyChar == 'd')
            {
                pictureBox1.Left += 5;
            }
            else if (e.KeyChar == 'a')
            {
                pictureBox1.Left -= 5;
                //pictureBox1.Width -= 10;
            }
            else if (e.KeyChar == 'w')
            {
                pictureBox1.Top -= 5;
            }
            else if (e.KeyChar == 's')
            {
                pictureBox1.Top += 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
