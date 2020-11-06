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

namespace Sequal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            SqlConnection Cnn;
            ConnectionString=@"Data Source=SHERY\SQLEXPRESS;Initial Catalog=VSDB;Integrated Security=True";
            Cnn=new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd;
       
            SqlDataAdapter dataAdapter=new SqlDataAdapter();
            string sql="";
            sql = "Delete DemoDb where TutorialID=5";
            cmd = new SqlCommand(sql, Cnn);

            dataAdapter.InsertCommand = new SqlCommand(sql, Cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();
  
            cmd.Dispose();
            Cnn.Close();

        }
    }
}
