using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CsharpBokgraphics1
{
    public partial class Form1 : Form
    {
            Form1 f = new Form1();
            f.Paint += new PaintEventHandler(MyPaintEvent);
        public Form1()
        {
            InitializeComponent();
        
        }
        public void MyPaintEvent(object sender,PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            grfx.Clear(Color.Azure);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
