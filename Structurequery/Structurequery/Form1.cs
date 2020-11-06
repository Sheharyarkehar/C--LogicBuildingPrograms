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
namespace Structurequery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
          

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              SqlConnection connect = new SqlConnection();
            connect.ConnectionString = @"data source=SHERY\SQLEXPRESS;database=Second;integrated security=SSPI";
            SqlCommand q=new SqlCommand("Select SeatNo from Marksheet",connect);
            connect.Open();
            SqlDataReader dr=q.ExecuteReader();
            BindingSource bs=new BindingSource();
           bs.DataSource=dr;
            dataGridView1.DataSource=bs;
            connect.Close();
            
        
        }
    }
}