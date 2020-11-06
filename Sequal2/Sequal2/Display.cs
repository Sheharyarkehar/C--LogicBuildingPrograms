using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequal2
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vSDBDataSet.DemoDb' table. You can move, or remove it, as needed.
            this.demoDbTableAdapter.Fill(this.vSDBDataSet.DemoDb);

        }
    }
}
