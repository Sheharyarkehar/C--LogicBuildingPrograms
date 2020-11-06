using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromaFirebaseCsharpApp.Controls
{
    public partial class TitleBar : UserControl
    {
        bool isMove = false;
        int x, y;
        public TitleBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        /// <summary>
        /// dsjflsjf
        /// </summary>
        [Description("Get or set the logo")]
        
        public Image Icon{ 
            get
            {
                return aromaLogo.Image;
            }
            set
            {
                aromaLogo.Image = value;
            }
        }
        public string Title
        {
            get
            {
                return captionSoft.Text;
            }
            set {
                captionSoft.Text = value;
            }
        }
        public string Version { 
         get 
        {
            return versionWriter.Version;
        } 
            set {
                versionWriter.Version = value;
            } 
        }
        public bool Maximize { 
            get
            {
                return maxBut.Visible;
                   }
            set
            {
                maxBut.Visible = value;
            }
        }
        public Font FontStyle
        {
            get
            {
                return captionSoft.Font;
            }

            set
            {
                captionSoft.Font = value;
            }
        }
        private void CloseBut_Hover(object sender, EventArgs e)
        {
            //closeBut.Image = Properties.Resources.closeHover;
            PictureBox pBox = (PictureBox)sender;
            if (pBox.Name=="closeBut")
            {
                pBox.Image = Properties.Resources.closeHover;
            }
            else if (pBox.Name == "maxBut")
            {
                pBox.Image = Properties.Resources.maxHov;
            }
            else if(pBox.Name=="minBut")
            {
                pBox.Image=Properties.Resources.minHover;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBut_MouseHover(object sender, EventArgs e)
        {
            //closeBut.Image = Properties.Resources.closeHover;
            PictureBox pBox = (PictureBox)sender;
            if (pBox.Name == "closeBut")
            {
                pBox.Image = Properties.Resources.closeHover;
            }
            else if (pBox.Name == "maxBut")
            {
                pBox.Image = Properties.Resources.maxHov;
            }
            else if (pBox.Name == "minBut")
            {
                pBox.Image = Properties.Resources.minHover;
            }

        }

        private void maxBut_Click(object sender, EventArgs e)
        {
            MainForm.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            if (MainForm.WindowState == FormWindowState.Maximized)
            {
                MainForm.WindowState = FormWindowState.Normal;
            }
            else if (MainForm.WindowState == FormWindowState.Normal)
            {
                MainForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form MainForm { get; set; }
        
        private void but_MouseHover(object sender, EventArgs e)
        {

        }

        private void minBut_Click(object sender, EventArgs e)
        {
            if (MainForm.WindowState == FormWindowState.Minimized)
            {
                MainForm.WindowState = FormWindowState.Normal;
            }
            else if (MainForm.WindowState == FormWindowState.Normal)
            {
                MainForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void aromaLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)

                MainForm.Location = new Point(MainForm.Location.X + e.X-x,MainForm.Location.Y + e.Y-y);
        }

        private void aromaLogo_Click(object sender, EventArgs e)
        {

        }

        private void aromaLogo_MouseDown(object sender, MouseEventArgs e)
        {
             x = e.X;
             y = e.Y;
            isMove = true;
            MainForm.Cursor = Cursors.Hand;
        }

        private void aromaLogo_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
    }
}
