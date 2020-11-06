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
using System.Globalization;
namespace crudeOperationApp
    
{
    public partial class Form1 : Form
    {
       string conStr = @"Data Source = SHERY\SQLEXPRESS;Initial Catalog=VSDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
             
                SqlConnection sCon = new SqlConnection(conStr);
                sCon.Open();

                //Select
                string query = "Select * from Biodata";
                SqlCommand cmd = new SqlCommand(query, sCon);
                SqlDataReader sdr = cmd.ExecuteReader();
                // DataGridView dataGridView1 = new DataGridView();
               // BindingSource bindingSource1 = new BindingSource();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conStr);
                DataTable table = new DataTable();
                // dataAdapter.Fill(table);
                // bindingSource1.DataSource = table;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                sdr.Close();
                cmd.Dispose();
                sCon.Close();

            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetData();

        }
        public void SetData()
        {
            int x = int.Parse(textBox1.Text);
            string x1 = textBox2.Text;
            string query = "Insert into DemoDb(TutorialID,TutorialName)Values('" + x + "','" + x1 + "')";

            SqlConnection sCon = new SqlConnection(conStr);
            sCon.Open();
            //  SqlCommand cmd = new SqlCommand(query, sCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = new SqlCommand(query, sCon);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            dataAdapter.Dispose();
            sCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetData();

            

        }
        public void UpdateData()
        {
             string query = "Update  DemoDb set TutorialName='"+textBox1.Text.Trim()+"' where TutorialName='"+textBox2.Text.Trim()+"'";

            SqlConnection sCon = new SqlConnection(conStr);
            sCon.Open();
            //  SqlCommand cmd = new SqlCommand(query, sCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.UpdateCommand = new SqlCommand(query, sCon);
            dataAdapter.UpdateCommand.ExecuteNonQuery();

            dataAdapter.Dispose();
            sCon.Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void DeleteData()
        {
            string query = "Delete  DemoDb where TutorialName='" + textBox1.Text.Trim() + "'";

            SqlConnection sCon = new SqlConnection(conStr);
            sCon.Open();
            //  SqlCommand cmd = new SqlCommand(query, sCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = new SqlCommand(query, sCon);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            dataAdapter.Dispose();
            sCon.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             try
            {
             
                SqlConnection sCon = new SqlConnection(conStr);
                sCon.Open();

                //Select
               // string query = "Select * from DemoDb";
                SqlCommand cmd = new SqlCommand("usp_GetNames",sCon);
                // cmd.CommandType=CommandType.StoredProcedure;
                //SqlDataReader sdr = cmd.ExecuteNonQuery();
                // DataGridView dataGridView1 = new DataGridView();
               // BindingSource bindingSource1 = new BindingSource();
           
                DataTable table = new DataTable();
                // dataAdapter.Fill(table);
                // bindingSource1.DataSource = table;
                cmd.CommandType = CommandType.StoredProcedure;
                table.Load(cmd.ExecuteReader());
               
                dataGridView1.DataSource = table;
              
               //// sdr.Close();
               // cmd.Dispose();
               // sCon.Close();

            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sCon = new SqlConnection(conStr);
                sCon.Open();

                //Select
                // string query = "Select * from DemoDb";
                SqlCommand cmd = new SqlCommand("usp_Data", sCon);
                // cmd.CommandType=CommandType.StoredProcedure;
                //SqlDataReader sdr = cmd.ExecuteNonQuery();
                // DataGridView dataGridView1 = new DataGridView();
                // BindingSource bindingSource1 = new BindingSource();

                DataTable table = new DataTable();
                // dataAdapter.Fill(table);
                // bindingSource1.DataSource = table;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name",int.Parse(textBox1.Text));
               // cmd.Parameters.AddWithValue("@City", city);
         
                int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
                //table.Load(cmd.ExecuteReader());

               // dataGridView1.DataSource = table;

                //// sdr.Close();
                cmd.Dispose();
                sCon.Close();

            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }

        }
           
    }
}
