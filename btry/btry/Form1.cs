using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace btry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        //  button1.Enabled=false;
            richTextBox1.Visible = false;
            chart1.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            string a = "Equation must be written in the form of x and should be lowerCased\nSelect a and b such that f(a) and f(b) have opposite signs.";
           // MessageBox.Show(a);
            
DialogResult result2 = MessageBox.Show(a,"Important Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = false;
             double fx1,fx2,fx3;
             double fx4;
        double x1, x2;
 //IEnumerable<int> squares = Enumerable.Range(-10, 21).Select(x => x);
       // Console.Write("Enter Value for X1 :");
        x1 = Convert.ToDouble(textBox2.Text);
        fx1 = fx(textBox1.Text, x1.ToString());
        //int p = 0;
          
        //Console.Write("Enter Value for X2 :");
        x2 = Convert.ToDouble(textBox3.Text);
        fx2 =fx(textBox1.Text, x2.ToString());
        double m = (Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text)) / 2;
        //Console.Write("Number Of Itrations =");
        int itre = Convert.ToInt32(textBox4.Text);
       // int j=0;
        string[] arr=new string[100];
        fx3= fx(textBox1.Text, m.ToString());
        double error = (x1 - x2) / 2;
        int counter = 0;    
        int[] E = new int[21];
       // System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\jalal\Desktop\Bisec.txt");
           
        richTextBox1.Text = "X1" + "\t" + "X2" + "\t" + "m" + "\t" + "Fx1" + "\t" + "Fx2" + "\t" + "FX3"+"\t"+ "E" +"\n";
       // richTextBox1.Text += x1+"\t"+x2+"\t"+ m+"\t"+fx1+"\t"+fx2+"\t"+fx3+"\n";
        while (Math.Abs(x1 - x2) > 0.000001 || m != 0)
        {
            int RL = -1;
            int KL = 1;

            if (counter == itre)
            {
                break;
            }
          
                    arr[counter] = x1.ToString("f2") + "\t" + x2.ToString("f2") + "\t" + m.ToString("f2") + "\t" + fx1.ToString("f2") + "\t" + fx2.ToString("f2") + "\t" + fx3.ToString("f2")+ "\t"+ error.ToString("f2")+"\n";
                  
                        richTextBox1.Text += arr[counter];


                        for (int R = 0; R < 9; R++, --RL)
                        {
                            E[R] = RL;
                        }

                        for (int Q= 10; Q <20; Q++,KL++)
                        {
                            E[Q] = KL;
                           
                        }




  counter=counter + 1;

            if(m==0)
            {
                break;
            }
            else if (fx1 * fx3 < 0)
            {
                 x2= m;
            }
            else{
            
                x1 = m;
            }
            m = (x1 + x2) / 2;
            error = (x1 - x2) / 2;
            fx1 = fx(textBox1.Text, x1.ToString());
            fx2 = fx(textBox1.Text, x2.ToString());
            fx3 = fx(textBox1.Text, m.ToString());

            fx4 = fx(textBox1.Text, E[counter].ToString());
            this.chart1.Series["Series1"].Points.AddXY(E[counter], fx4);
            status=true;
            if (status == true)
            {
                button1.Enabled = false;
                textBox5.Text = x2.ToString("f4");
            }
        }          
          //  sw.Write(richTextBox1.Text+"\n");
            //sw.Write("\n");
           label6.Visible = true;
        textBox5.Visible = true;  
        richTextBox1.Visible = true;
        chart1.Visible = true;
 
        }
        //sw.Close();
      
       // Console.WriteLine(m);
       
        //Console.ReadLine();
 
    
 
    private static double fx(string a,string c)
    {
        Function at = new Function("At(x)="+a);
        // string x = "x=";
        Argument b = new Argument("x=" + c);
        //  Argument ag1 = new Argument("h=10");

        Expression e2 = new Expression("At(x)", at, b);
        double ans = e2.calculate();
        ////textBox4.Text = ans.ToString();

        //Argument c = new Argument("x=" + textBox3.Text);
        ////  Argument ag1 = new Argument("h=10");

        //Expression e3 = new Expression("At(x)", at, c);
        //double ans1 = e3.calculate();
      

        //Argument d = new Argument("x=" + m.ToString());
        ////  Argument ag1 = new Argument("h=10");

        //Expression e4 = new Expression("At(x)", at, d);
        //double ans2 = e4.calculate();
        return ans;


    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_MouseHover(object sender, EventArgs e)
    {
        button1.BackColor = Color.ForestGreen;
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
        button1.BackColor = Color.Honeydew;

    }

    //private void button2_Click_1(object sender, EventArgs e)
   // {
  //      System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\jalal\Desktop\Bisec.txt");
    //    sw.Write(richTextBox1.Text);
      //  sw.Close();
   // }
       
     
    }

    }