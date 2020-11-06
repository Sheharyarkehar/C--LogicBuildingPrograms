using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace dll_link
{
    public partial class Form1 : Form
    {    ClassLibrary1.Class1 o = new ClassLibrary1.Class1();
            
        
        public Form1()
        {
          
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = o.Add().ToString();
        }
    }
}
