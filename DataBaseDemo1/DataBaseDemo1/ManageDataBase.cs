using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseDemo1
{
    public partial class ManageDataBase : Form
    {
        public ManageDataBase()
        {
            InitializeComponent();
        }

        private void AddnewStudentbutton_Click(object sender, EventArgs e)
        {
            StudentInforForm s = new StudentInforForm();
            s.ShowDialog();
            this.Close();
        }
    }
}
