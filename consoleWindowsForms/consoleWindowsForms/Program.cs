using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
namespace consoleWindowsForms
{
    class Program
    {
        static void Main(string[] args)
        {   Form myForm = new Form();
        myForm.BackColor = Color.Aqua;
        myForm.Text = "Properties";
        myForm.Width *= 2;
        myForm.Height /= 2;
        myForm.FormBorderStyle = FormBorderStyle.None;
        myForm.Cursor = Cursors.PanWest;
        myForm.StartPosition = FormStartPosition.CenterScreen;
        myForm.ShowDialog();
        Application.Run(myForm);

            




        
           // Form myForm1 = new Form();
           //// myForm.Show();
           //// myForm.Close();
           // myForm1.Show();
           // Application.Run(myForm);
           // //Form myForm = new Form();


            //myForm.Show();


            //Button b1 = new Button();
            //b1.Visible = true;
            //b1.Text = "Hi";
            //b1.Show();
            //myForm.Text = "HAHAHAHAHAH";
            //Application.Run(myForm);



     
        }
    }
}
