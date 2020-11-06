using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace checking
{
    public partial class ExcelTrying : Form
    {
        SqlConnection con = null;
        public ExcelTrying()
        {
            InitializeComponent();
            con = Connection.connection();
        }

        private void ExcelTrying_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ssqltable = "awee";
            // make sure your sheet name is correct, here sheet name is sheet1, so you can change your sheet name if have
            //   different
            string myexceldataquery = "select Name,Grn_no,FatherName from [sheet1$]";
            try
            {
                //create our connection strings
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source= C:\Users\jalal\Desktop\hamza.xlsx " +
                ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                //  string ssqlconnectionstring = @"server=mydatabaseservername;user
                //  id = dbuserid; password = dbuserpassword; database = databasename; connection reset = false";
                //execute a query to erase any previous data from our destination table
                //string sclearsql = "delete from awee" ;
                //   SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
                // SqlCommand sqlcmd = new SqlCommand(sclearsql, con);
                con.Open();
                // sqlcmd.ExecuteNonQuery();
              
                //series of commands to bulk copy data from the excel file into our sql table
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(con);
                bulkcopy.DestinationTableName = ssqltable;
                while (dr.Read())
                {
                    bulkcopy.WriteToServer(dr);
                }

                oledbconn.Close();
                con.Close();
                MessageBox.Show("hogaya");
            }
            catch (Exception ex)
            {
                //handle exception

                MessageBox.Show(ex.Message);
            }
        }
    }
}
