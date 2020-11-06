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
    public partial class chartOfAccount : Form
    {

        SqlConnection con = null;
        public chartOfAccount()
        {
            InitializeComponent();

            con = Connection.connection();
            showTree();
        
        }

        private void chartOfAccount_Load(object sender, EventArgs e)
        {

        }

        public void showTree()
        {

            String query = "select * from ChartOfAccount";
           
            //SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sr = new SqlDataAdapter(query, con);
              con.Open();
        
            String query1 = "select t.name ,t.category from typesChart as t inner join ChartOfAccount as c on t.category=c.c_id ";
        DataTable dt=new DataTable();
            sr.Fill(dt);

            SqlDataAdapter sr1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sr1.Fill(dt1);

            //SqlCommand cmd1 = new SqlCommand(query1, con);
          
          
          
            try
            {
                //SqlDataReader rd = cmd.ExecuteReader();
                //SqlDataReader rd1 = cmd1.ExecuteReader();
              

                foreach(DataRow rd in dt.Rows)
                {
                    TreeNode tr = new TreeNode(rd["c_name"].ToString());
                    String s = rd["c_id"].ToString();

                    foreach(DataRow rd1 in dt1.Rows) {
                          String c = rd1["category"].ToString();
                        if (s.Equals(c))
                        {
                            tr.Nodes.Add(new TreeNode(rd1["name"].ToString()));
                        }
                    }
                    
                    
                    
                    treeView1.Nodes.Add(tr);
                   
                }
               // rd1.Dispose();
                //rd.Dispose();

            }catch(Exception ex){

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        
        
    }
}
