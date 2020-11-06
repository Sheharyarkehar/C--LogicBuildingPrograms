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
    public partial class Form2 : Form
    {

        SqlConnection con = null;
        public Form2()
        {
            InitializeComponent();
            con = Connection.connection();
            showTree();
            FillCombo();
        }
        public void FillCombo() {

            string cmdstr = "select * from sys.tables";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, con);
            try
            {
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        
        }


        public void hierarchy(String id, DataTable dt, TreeNode tr)
        {
            // String query 
            foreach (DataRow rd2 in dt.Rows)
            {
                TreeNode tr3 = new TreeNode(rd2["name"].ToString());
                String parent = rd2["parent"].ToString();

                String id1 = rd2["id"].ToString();
                if (id.Equals(parent))
                {
                    tr.Nodes.Add(tr3);
                    String querych = "select Count(id) from typesChart where parent=" + id + "";
                    SqlCommand cmd = new SqlCommand(querych, con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        hierarchy(id1, dt, tr3);
                    }
                    else
                    {
                        return;
                    }


                }
            }
        }

        public void showTree()
        {
            //treeView1.Refresh();
            treeView1.Nodes.Clear();

            String query = "select * from ChartOfAccount";

            //SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sr = new SqlDataAdapter(query, con);
            con.Open();

            String query1 = "select t.id,t.name ,t.category,t.parent from typesChart as t inner join ChartOfAccount as c on t.category=c.c_id ";
            DataTable dt = new DataTable();
            sr.Fill(dt);

            SqlDataAdapter sr1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sr1.Fill(dt1);
            String query2 = "select * from typesChart ";
            SqlDataAdapter sr2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            sr2.Fill(dt2);

            //SqlCommand cmd1 = new SqlCommand(query1, con);



            try
            {
                //SqlDataReader rd = cmd.ExecuteReader();
                //SqlDataReader rd1 = cmd1.ExecuteReader();


                foreach (DataRow rd in dt.Rows)
                {
                    TreeNode tr = new TreeNode(rd["c_name"].ToString());
                    String s = rd["c_id"].ToString();


                    foreach (DataRow rd1 in dt1.Rows)
                    {
                        TreeNode tr2 = new TreeNode(rd1["name"].ToString());
                        String c = rd1["category"].ToString();
                        String id = rd1["id"].ToString();
                        if (s.Equals(c))
                        {
                            tr.Nodes.Add(tr2);
                            String querych = "select Count(id) from typesChart where parent=" + id + "";
                            SqlCommand cmd = new SqlCommand(querych, con);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                hierarchy(id, dt2, tr2);
                            }
                            //foreach (DataRow rd2 in dt2.Rows)
                            //{
                            //    TreeNode tr3 = new TreeNode(rd2["name"].ToString());
                            //    String parent = rd2["parent"].ToString();
                            //    int cs = dt2.Rows.Count;
                            //    String id1 = rd2["id"].ToString();
                            //    if (id.Equals(parent))
                            //    {

                            //        tr2.Nodes.Add(tr3);
                            //        foreach (DataRow rd3 in dt2.Rows)
                            //        {
                            //            TreeNode tr4 = new TreeNode(rd3["name"].ToString());
                            //            String parent1 = rd3["parent"].ToString();

                            //            if (id1.Equals(parent1))
                            //            {
                            //                tr3.Nodes.Add(tr4);

                            //            }
                            //        }




                            //    }
                            //}
                        }




                    }



                    treeView1.Nodes.Add(tr);

                }
                // rd1.Dispose();
                //rd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "insert into typesChart(name,parent) values('" + textBox1.Text + "',(select id from typesChart where name='" + textBox2.Text + "'))";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            String query1="select id from typesChart where name='"+textBox1.Text+"'";
            String query2 = "select ConcatinatedID from typesChart where name='"+textBox2.Text+"'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            String c1 = cmd1.ExecuteScalar().ToString();
            String c2 = cmd2.ExecuteScalar().ToString();
            String concat =  c2 + c1;
            String query3 = "Update typesChart set ConcatinatedID='" + concat + "' where name='"+textBox1.Text+"' ";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("ja dimagh na kharab kar ");
            con.Close();
            showTree();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Text = treeView1.SelectedNode.Text;
            textBox3.Text = treeView1.SelectedNode.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "insert into chartEffect(tableId ,typeChart) values((select object_id from sys.tables where name='"+comboBox1.Text+"'),(select id from typesChart where name='" + textBox3.Text + "'))";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            
        }
    }
}
