namespace AromaFirebaseCsharpApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleBar1 = new AromaFirebaseCsharpApp.Controls.TitleBar();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.FontStyle = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.Icon = ((System.Drawing.Image)(resources.GetObject("titleBar1.Icon")));
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.MainForm = this;
            this.titleBar1.Maximize = true;
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(985, 65);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.Title = "Aroma Odering Software";
            this.titleBar1.Version = "1.0.0.0";
            this.titleBar1.Load += new System.EventHandler(this.titleBar1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 505);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TitleBar titleBar1;

    }
}

