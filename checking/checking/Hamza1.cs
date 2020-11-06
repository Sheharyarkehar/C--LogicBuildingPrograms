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
namespace checking
{
    public partial class Hamza1 : Form
    {
        SqlConnection con;
        private List<Node> data;
        private BrightIdeasSoftware.TreeListView treeListView;
    
        public Hamza1()
        {
            InitializeComponent();
            con=Connection.connection();
        
            AddTree();
            FillTree();
            InitializeData();
         treeListView.ColumnClick+=treeListView_ColumnClick;
         treeListView.Click += treeListView_Click;
           
           
           
        }

        void treeListView_Click(object sender, EventArgs e)
        {
           
            Form2 f = new Form2();
            String ch = treeListView.SelectedItem.Text.ToString();
            String query = "select l.* from ledger as l inner join  chartEffect as c on l.Table_id=c.tableId inner join typesChart as t on t.name=c.typename where t.name='"+ch+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;



            

        
        }

void treeListView_ColumnClick(object sender, ColumnClickEventArgs e)
{
    Form2 f = new Form2();
    f.ShowDialog();
}
       
        private void AddTree()
        {
            treeListView = new BrightIdeasSoftware.TreeListView();
            treeListView.Dock = DockStyle.Left;

            this.Controls.Add(treeListView);
        }
        private void InitializeData()
        {
            data = new List<Node>();
          String query = "select * from ChartOfAccount";

            //SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sr = new SqlDataAdapter(query, con);
            con.Open();

            String query1 = "select t.id,t.name ,t.category,t.parent,t.ConcatinatedID from typesChart as t inner join ChartOfAccount as c on t.category=c.c_id ";
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
         DataTable   dtshow = new DataTable();
         dtshow.Columns.Add("Id");
         dtshow.Columns.Add("Name");

            //dtshow.Rows.Add(


            try
            {
                //SqlDataReader rd = cmd.ExecuteReader();
                //SqlDataReader rd1 = cmd1.ExecuteReader();
                DataColumn dc = new DataColumn();
               // dc.

                foreach (DataRow rd in dt.Rows)
                {
                    int i = 0;
                   // DataRow row = dtshow.NewRow();
                    //row[0] = rd["c_id"].ToString();
                  //  row[1] = rd["c_name"].ToString();
                  var parent1 = new Node(rd["c_name"].ToString(),rd["c_id"].ToString());                   
                 // rd["c_id"].ToString() +"          "+ 
                    String s = rd["c_id"].ToString();


                    foreach (DataRow rd1 in dt1.Rows)
                    {
                        var child1 = new Node(rd1["name"].ToString(), rd1["ConcatinatedID"].ToString());
                        // rd1["ConcatinatedId"] + "          " +
                        String c = rd1["category"].ToString();
                        String id = rd1["id"].ToString();
                        if (s.Equals(c))
                        {
                            parent1.Children.Add(child1);


                            String querych = "select Count(id) from typesChart where parent=" + id + "";
                            SqlCommand cmd = new SqlCommand(querych, con);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                hierarchy(id, dt2, child1);
                            }
                        }




                    }


                  
             
                    //   treeView1.Nodes.Add(tr);
                   // treeView1.Nodes.Add(
               //  treeView1.Nodes.Add(tr);
                    //data= new List<Node> { parent1 };
                   
                    data.Add(parent1);
                    
                  
                    

     
                }

                this.treeListView.Roots = data;
                // rd1.Dispose();
                //rd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void hierarchy(String id, DataTable dt, Node tr)
        {
            // String query 
            foreach (DataRow rd2 in dt.Rows)
            {

                //rd2["ConcatinatedId"] + "          " + 
                var child3 = new Node(rd2["name"].ToString()
, rd2["ConcatinatedID"].ToString());
                String parent = rd2["parent"].ToString();
                
                String id1 = rd2["id"].ToString();
                if (id.Equals(parent))
                {
                    tr.Children.Add(child3);
                    String querych = "select Count(id) from typesChart where parent=" + id + "";
                    SqlCommand cmd = new SqlCommand(querych, con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        hierarchy(id1, dt, child3);
                    }
                    else
                    {
                        return;
                    }


                }
            }
        }
        private void FillTree()
        {
            // set the delegate that the tree uses to know if a node is expandable
            this.treeListView.CanExpandGetter = x => (x as Node).Children.Count > 0;
            // set the delegate that the tree uses to know the children of a node
            this.treeListView.ChildrenGetter = x => (x as Node).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var nameCol = new BrightIdeasSoftware.OLVColumn("Name", "Name");
            nameCol.AspectGetter = x => (x as Node).Name;

            var IdCol = new BrightIdeasSoftware.OLVColumn("Id", "Id");
            IdCol.AspectGetter = x => (x as Node).Id;

            //var col2 = new BrightIdeasSoftware.OLVColumn("Column2", "Column2");
            //col2.AspectGetter = x => (x as Node).Column2;

            //var col3 = new BrightIdeasSoftware.OLVColumn("Column3", "Column3");
            //col3.AspectGetter = x => (x as Node).Column3;

            // add the columns to the tree
            this.treeListView.Columns.Add(nameCol);
            this.treeListView.Columns.Add(IdCol);
            //this.treeListView.Columns.Add(col2);
            //this.treeListView.Columns.Add(col3);

            // set the tree roots
        }
    
        private void Hamza1_Load(object sender, EventArgs e)
        {

        }
    }
}
