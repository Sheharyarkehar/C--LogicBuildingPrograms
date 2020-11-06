using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            progressBar1.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
 if (progressBar1.Value == 100)
 progressBar1.Value = 0;
 else
 progressBar1.Value += 1;

 
        }
    }
}
