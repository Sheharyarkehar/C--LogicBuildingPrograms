using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = @"C:\Users\jalal\Desktop\sundas";
            DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
            FileInfo[] files = dir.GetFiles();
            long max = 0;
            for (int i = 0; i <files.Length; i++)
            {
                if (files[i].Length > max)
                {
                    max = files[i].Length;
                }
            }
            textBox1.Text = max.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@"C:\Users\jalal\Desktop\ali.html");
            //char[] b = sr.ReadToEnd().ToCharArray();
            //for (int i = 0; i <b.Length; i++)
            //{
            //    richTextBox1.Text += b[i];
            }

        }
    }
}
