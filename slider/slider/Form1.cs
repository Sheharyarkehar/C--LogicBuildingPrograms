using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slider
{
    public partial class Form1 : Form
    {
        int pw;
        bool hided;
        public Form1()
        {
            InitializeComponent();
            pw = panel2.Width;
            hided = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                panel2.Width = panel2.Width + 20;
                if (panel2.Width >= pw)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                    panel2.BackColor = Color.Red;
                   
                   
                }
               
            }
                else
                {
                    panel2.Width = panel2.Width - 20;
                    if (panel2.Width <= 0)
                    {
                        timer1.Stop();
                        hided = true;
                        this.Refresh();
                        panel2.BackColor = Color.Red;
                   
                    }
            }
        }
    }
}
