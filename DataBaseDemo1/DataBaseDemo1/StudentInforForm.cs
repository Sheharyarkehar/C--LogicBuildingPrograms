using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace DataBaseDemo1
{
    public partial class StudentInforForm : Form
    {
        public StudentInforForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string c = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            SqlConnection o = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("usp_StudentDetails",o);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name",textBox1.Text);
            cmd.Parameters.AddWithValue("Email", textBox2.Text);


            //Connection open
            o.Open();

            //cmd.ExecuteReader();//Select Statmenet
            //cmd.ExecuteScalar();//Select Statement
            cmd.ExecuteNonQuery();//Insert Update Delete
        


        }
    }
}
