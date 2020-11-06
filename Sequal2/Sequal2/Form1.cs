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

namespace Sequal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            SqlConnection Cnn;
            ConnectionString = @"Data Source=SHERY\SQLEXPRESS;Initial Catalog=VSDB;Integrated Security=True";
            Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd;
            string a ;
            a = textBox1.Text;
            string b = textBox2.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string sql = "";
            sql = "INSERT into DemoDb (TutorialID,TutorialName) values('" + a + "','" + b + "')";
            cmd = new SqlCommand(sql, Cnn);

            dataAdapter.InsertCommand = new SqlCommand(sql, Cnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            Cnn.Close();
            Display d = new Display();
            d.ShowDialog();
            this.Close();

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
