using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int a=0;
        
        string opt;
        int b = 0;
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            opt = button3.Text;
            switch (opt)
            { 
                case "+":
                    a = int.Parse(textBox1.Text);
                    sum = a;
              
                
               
                break;
                case "-":
   a = int.Parse(textBox1.Text);

   sum = a;
              
                break;
                case "*":
                 a = int.Parse(textBox1.Text);

                 sum = a;
                  
                break;
                case "/":
               a = int.Parse(textBox1.Text);

               sum = a;
             
                break;

                 



            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
            if (opt == "+")
            {
                sum += b;
            }
            if (opt == "-")
            {
                sum -= b;
            }
            textBox1.Text = sum.ToString();
        }
    }
}
