using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromaFirebaseCsharpApp.Controls
{
    public partial class VersionWriter : UserControl
    {
        public VersionWriter()
        {
            InitializeComponent();
        }
        public string Version
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
