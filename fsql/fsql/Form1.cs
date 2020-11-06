using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sogat\Documents\Visual Studio 2012\Projects\Structurequery\dblogin.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from dblogin where username='" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim()+"'";
            SqlDataAdapter sda= new SqlDataAdapter(query, connection);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            if (dtb.Rows.Count == 1)
            {
                Form2 obj = new Form2();
                this.Hide();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("user name password is incorrect");



            }
            
            }
    }
}
