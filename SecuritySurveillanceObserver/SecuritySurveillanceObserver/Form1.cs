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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Visible = false;
            label1.Visible = false;
            button3.Visible = true;
            Form2 f = new Form2();
            f.ShowDialog();
         
         
     

    
   


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Subject sb = new Subject();



            Observer observer2 = new Observer("ob1");

            sb.DetachVideo(observer2);
            if (Subject.count >= 0)
            {
                MessageBox.Show("Video Detached");
                textBox1.Text = Subject.count.ToString();
                observer2.Update();
                textBox1.Visible = true;
                label1.Visible = true;
                button3.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Observer observer2 = new Observer("ob1");
            observer2.Update();
            MessageBox.Show("Updated");
            button3.Visible = false;
        }
    }

    ///code
    ///

   //Subject subject = new Subject();
   //// Observer1 takes a subscription to the store
   //Observer observer1 = new Observer("Observer 1");
   //subject.Subscribe(observer1);
   //// Observer2 also subscribes to the store
   //subject.Subscribe(new Observer("Observer 2"));
   //subject.Inventory++;
   //// Observer1 unsubscribes and Observer3 subscribes to notifications.
   //subject.Unsubscribe(observer1);
   //subject.Subscribe(new Observer("Observer 3"));
   //subject.Inventory++;
   //Console.ReadLine();
}




