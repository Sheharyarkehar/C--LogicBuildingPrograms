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
namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter="txt files (*.txt)|*.txt|All files (*.*)|*.*";

            //if (Properties.Settings.Default.id.Count == 0)
            //    Properties.Settings.Default.id = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.id.Add("T180103");
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Settings.Default.id[1]);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sr=new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
;
            }
        }
    }
}
