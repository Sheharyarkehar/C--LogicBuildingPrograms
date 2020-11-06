using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slider_try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            maskedTextBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;
            button1.Enabled = false;
            
          
        }
       // bool x = false;
        bool a = false;
  
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if(r(a))
            {
                timer1.Stop();
                
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        { 
            panel2.BackColor = Color.Red;
            panel1.BackColor = Color.Black;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            maskedTextBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            pictureBox1.Visible = true;
            panel2.Width +=20;
            textBox1.Text = textBox8.Text;
            textBox2.Text = textBox7.Text;
            maskedTextBox1.Text = textBox5.Text;
            textBox3.Text = textBox6.Text;
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Red;
            maskedTextBox1.BackColor = Color.Red;
            pictureBox2.Visible=false;
            button1.Visible = false;
            button2.Visible = false;
           
           
            if (panel2.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Stop();
                a=true;
               r(a);
                
            }
        }
            public bool r(bool a)
            {
                return a;
            }
        
            private void Form1_Load(object sender, EventArgs e)
            {
              
            }

            private void button2_Click(object sender, EventArgs e)
            {
                OpenFileDialog o = new OpenFileDialog();
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.ImageLocation = o.FileName;
                }
                //if (textBox8.Text != "")
                //{
                //    x = true;
                //    button1.Enabled = true;
                //}
                //if (x == true && textBox8.Text == "")
                //{
                //    button1.Enabled = false;
                //}
               
            }

            private void button3_Click(object sender, EventArgs e)
            {
                //panel2.Width -= 20;
                //if (panel2.Bounds.IntersectsWith(label1.Bounds))
                //{
                //    timer1.Stop();
                //    a = true;
                //    r(a);

                //}
            }
            public void check()
            {
                if (textBox8.Text!="" && textBox5.Text != "" && textBox7.Text!=""&&textBox6.Text!="")
                {
                    button1.Enabled = true;

                }
            }

            private void button1_MouseHover(object sender, EventArgs e)
            {
             

            }

            private void textBox6_MouseHover(object sender, EventArgs e)
            {
                check();
            }

            private void textBox6_MouseLeave(object sender, EventArgs e)
            {
               // button1.Enabled = false;
            }

        }
    }

