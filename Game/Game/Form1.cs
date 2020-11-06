using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed=10;
        int gravity=5;
        int Inscore=0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Game Over";
            label2.Text = "Your Final Score is" + Inscore;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Start();
            pictureBox2.Left -=pipeSpeed;
            pictureBox4.Left -=pipeSpeed;
            pictureBox1.Top += gravity;
            if (pictureBox2.Left < -80)
            {
                pictureBox2.Left = 1000;
                Inscore += 1;
                label3.Text = Inscore.ToString();
            }
            else if (pictureBox4.Left < -95)
            {
                pictureBox4.Left = 1100;
                Inscore += 1;
                label3.Text = Inscore.ToString();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                EndGame();
            }
            else if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                EndGame();
            }
            else if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                EndGame();
            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity -= 5;
            }
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }
        public void EndGame()
        {
            timer1.Stop();
            MessageBox.Show("Game Over");
        }
    }
}
