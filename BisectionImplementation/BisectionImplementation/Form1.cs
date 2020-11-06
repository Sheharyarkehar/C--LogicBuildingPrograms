using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisectionImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Time"].Points.AddXY(Math.Sin(65), Math.Cos(65));
            this.chart1.Series["Time"].Points.AddXY(Math.Sin(180), Math.Cos(180));
            this.chart1.Series["Time"].Points.AddXY(Math.Sin(90), Math.Cos(90));
            this.chart1.Series["Time"].Points.AddXY(Math.Sin(70), Math.Cos(70));
            string b = textBox8.Text;
          char []a=b.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                textBox9.Text += a[i];
              
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '^')
                {
                    int x = Math.Pow(Convert.ToDouble(a[i],);
                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "+")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double ans = a + b;
               // textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox2.Text == "*")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int ans = a * b;
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox2.Text == "-")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int ans = a - b;
              //  textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox2.Text == "/")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int ans = a / b;
               // textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox2.Text == "^")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double ans = Math.Pow(a, b);
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "+")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int ans = a + b;
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox1.Text == "*")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int ans = a*b;
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox1.Text == "-")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int ans = a - b;
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox1.Text == "/")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int ans = a / b;
               // textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox1.Text == "^")
            {
                double a = Convert.ToDouble(textBox7.Text);
                double b = Convert.ToDouble(textBox3.Text);
                double ans = Math.Pow(a, b);
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "+")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox5.Text);
                int ans = a + b;
                textBox7.Text = ans.ToString();
            }
            if (comboBox3.Text == "*")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox5.Text);
                int ans = a * b;
                textBox7.Text = ans.ToString();
            }
            if (comboBox3.Text == "-")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox5.Text);
                int ans = a - b;
                textBox7.Text = ans.ToString();
            }
            if (comboBox3.Text == "/")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox5.Text);
                int ans = a / b;
                textBox7.Text = ans.ToString();
            }
            if (comboBox3.Text == "^")
            {
                double a = Convert.ToDouble(textBox7.Text);
                double b = Convert.ToDouble(textBox5.Text);
                double ans = Math.Pow(a, b);
                textBox7.Text = ans.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "+")
            {
                int a = Convert.ToInt32(textBox4.Text);
                int b = Convert.ToInt32(textBox7.Text);
                int ans = a + b;
                textBox7.Text = ans.ToString();
            }
            if (comboBox4.Text == "*")
            {
                int a = Convert.ToInt32(textBox4.Text);
                int b = Convert.ToInt32(textBox7.Text);
                int ans = a * b;
                textBox7.Text = ans.ToString();
            }
            if (comboBox4.Text == "-")
            {
                int a = Convert.ToInt32(textBox4.Text);
                int b = Convert.ToInt32(textBox7.Text);
                int ans = a - b;
                //textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox4.Text == "/")
            {
                int a = Convert.ToInt32(textBox7.Text);
                int b = Convert.ToInt32(textBox6.Text);
                int ans = a / b;
              //  textBox4.Text = ans.ToString();
                textBox7.Text = ans.ToString();
            }
            if (comboBox4.Text == "^")
            {
                double a = Convert.ToDouble(textBox7.Text);
                double b = Convert.ToDouble(textBox6.Text);
                double ans = Math.Pow(a, b);
              //  textBox4.Text = ans.ToString();
            }
        }
    }
}
