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
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
            con = Connection.connection();
            JoinTwoTables();
            FillCombo();
            FillorderCombo();
            comboBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

          // FillDepricicationTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void FillCombo()
        {
            SqlDataReader rd;
            try
            {
                SqlCommand sq = new SqlCommand("Select Item_name from Items Order By Item_no desc", con);
                con.Open();
                rd = sq.ExecuteReader();
                while (rd.Read())
                {
                    String Grn_no = rd[0].ToString();
                    comboBox1.Items.Add(Grn_no);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void FillorderCombo()
        {
            SqlDataReader rd;
            try
            {
                SqlCommand sq = new SqlCommand("Select order_No from PurchaseOrder order By order_No desc", con);
                con.Open();
                rd = sq.ExecuteReader();
                while (rd.Read())
                {
                    String Grn_no = rd[0].ToString();
                    comboBox2.Items.Add(Grn_no);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        public void JoinTwoTables()
        {

            try
            {
                SqlDataAdapter dataadapter = new SqlDataAdapter("GRNJOIN", con);

                DataTable ds = new DataTable();
                con.Open();
                dataadapter.Fill(ds);





                dataGridView1.DataSource = ds;

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public void FillDepricicationTable()
        {

            try
            {
                SqlDataAdapter dataadapter = new SqlDataAdapter("select Row_Number() Over(partition by d.Item_id  order by d.Item_id) as Row_Number,i.Item_name,d.* from Depriciation as d inner join Items as i on d.Item_id=i.Item_no", con);
                //d.useful_life,d.depriciation_method,d.depriciation_amount
                DataTable ds = new DataTable();
                con.Open();
                dataadapter.Fill(ds);





                dataGridView2.DataSource = ds;

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





        }
        public void InsertDepriciationTable()
        {
            SqlDataReader rd;
            try
            {
                SqlCommand sq = new SqlCommand("select i.item_name from GRN as g inner join PurchaseOrder as o on g.Order_no=o.order_No  inner join Items as i on  i.Item_no=o.item_no ", con);
                con.Open();
                rd = sq.ExecuteReader();
                while (rd.Read())
                {
                    String Grn_no = rd[0].ToString();
                    comboBox1.Items.Add(Grn_no);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
             //SqlDataReader rd;
            try
            {
                String query = "select g.quantity from GRN as g inner join PurchaseOrder as o on g.Order_no=o.order_No  inner join Items as i on  i.Item_no=o.item_no where g.Grn_no="+textBox4.Text+"";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
               // String sum = cmd.ExecuteScalar();\
                String queryOrder = "select o.perunitPrice from GRN as g inner join PurchaseOrder as o on g.Order_no=o.order_No where g.Grn_no=" + textBox4.Text + "";
                String queryDate = "SELECT DATEDIFF(day,GETDATE() ,'2020/04/18')";
                   
                int convertSum = Convert.ToInt32(cmd.ExecuteScalar());
                SqlCommand cmd10 = new SqlCommand(queryOrder, con);
                SqlCommand cmd9 = new SqlCommand(queryDate, con);
                double countOrd = Convert.ToInt32(cmd10.ExecuteScalar());
                double CountScale = Convert.ToInt32(cmd9.ExecuteScalar());
                for (int i = 1; i <=convertSum; i++)
                {
                    String query1 = "insert into Depriciation(useful_life,depriciation_method,depriciation_amount,Item_id,Tag_no,Grn_no,Year) values(" + textBox1.Text + ",'" + textBox2.Text + "',(" + countOrd + "/" + Convert.ToDouble(textBox1.Text) + ") * (" + queryDate + " / 360.0),(select Item_no from Items where Item_name='" + comboBox1.Text + "')," + i + "," + textBox4.Text + ",YEAR(getdATE())) ";
                    cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String query1 = "insert into GRN(Grn_no,date,quantity,Total,Order_no) values(" + textBox4.Text + ",'" + textBox9.Text + "','" + textBox8.Text + "'," + textBox7.Text + ",'" + comboBox2.Text + "') ";
                SqlCommand cmd = new SqlCommand(query1, con);
                con.Open();
                cmd.ExecuteNonQuery();
                string query2 = "select Count(Item_id) from Depriciation where Item_id="+textBox5.Text+" ";
                SqlCommand cmd1 = new SqlCommand(query2, con);
                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count == 0)
                {
                    comboBox1.Enabled = true;
                    button1.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                }
                else {
                    String query = "select g.quantity from GRN as g inner join PurchaseOrder as o on g.Order_no=o.order_No  inner join Items as i on  i.Item_no=o.item_no where g.Grn_no=" + textBox4.Text + "";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    String query5 = "select top 1 Tag_no from Depriciation  where Item_id=1 order by Tag_no desc";
                    SqlCommand cmd4 = new SqlCommand(query5, con);
                   
                    
                    // String sum = cmd.ExecuteScalar();\

                    int convertSum = Convert.ToInt32(cmd2.ExecuteScalar());
                    int convertSum1 = Convert.ToInt32(cmd4.ExecuteScalar());
                    String queryOrder = "select o.perunitPrice from GRN as g inner join PurchaseOrder as o on g.Order_no=o.order_No where g.Grn_no="+textBox4.Text+"";
                    String queryDate = "SELECT DATEDIFF(day,GETDATE() ,'2020/04/18')";
                    SqlCommand cmd10 = new SqlCommand(queryOrder, con);
                    SqlCommand cmd9 = new SqlCommand(queryDate, con);
                    double  countOrd = Convert.ToInt32(cmd10.ExecuteScalar());
                    double  CountScale = Convert.ToInt32(cmd9.ExecuteScalar());

                    for (int i = convertSum1+1; i <= (convertSum + convertSum1); i++)
                    {

                        String query3 = "insert into Depriciation(useful_life,depriciation_method,depriciation_amount,Item_id,Tag_no,Grn_no,Year) values((select  top 1  useful_life from Depriciation  where Item_id=" + textBox5.Text + " order by Tag_no desc),'sln',(" + countOrd + "/5.0) * (" + queryDate + " / 360.0)," + textBox5.Text + "," + i + "," + textBox4.Text + ",YEAR(getdATE())) ";
                     SqlCommand   cmd8 = new SqlCommand(query3, con);
                        cmd8.ExecuteNonQuery();
                      
                    }
                    cmd2.Dispose();
                    cmd4.Dispose();
                    
                    
                }

                cmd.Dispose();
                cmd1.Dispose();
              
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
      

        }
    }
}