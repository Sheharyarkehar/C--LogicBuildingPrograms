using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecuritySurveillanceObserver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }
        String[] weapons = { "knife", "Gun", "Pistol", "Hammer" };
        private void Form2_Load(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            Random r = new Random();
      
            // Observer1 takes a subscription to the store

            Observer observer1 = new Observer("ob");
           
            subject.AttachVideo(observer1);
            textBox1.Text = Subject.count.ToString();
            observer1.Update();
          textBox2.Text= r.Next(1, 100).ToString();
          textBox3.Text = r.Next(1,10).ToString();
          textBox4.Text =weapons[r.Next(0,3)];


         
        }
    }
}
