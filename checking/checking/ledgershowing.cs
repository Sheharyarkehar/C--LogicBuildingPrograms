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

namespace checking
{
    public partial class ledgershowing : Form
    {
        SqlConnection con = null;
        public ledgershowing()
        {
            InitializeComponent();
            con = Connection.connection();
            showData();
        }


        private void ledgershowing_Load(object sender, EventArgs e)
        {
           
        }
        public void showData() {
            String query = "select * from ledger ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            dataGridView1.DataSource = tb;

           
        
        
        
        }
    }
}
