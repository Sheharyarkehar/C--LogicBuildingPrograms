namespace AromaFirebaseCsharpApp.Controls
{
    partial class TitleBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBar));
            this.minBut = new System.Windows.Forms.PictureBox();
            this.maxBut = new System.Windows.Forms.PictureBox();
            this.closeBut = new System.Windows.Forms.PictureBox();
            this.aromaLogo = new System.Windows.Forms.PictureBox();
            this.captionSoft = new System.Windows.Forms.Label();
            this.versionWriter = new AromaFirebaseCsharpApp.Controls.VersionWriter();
            ((System.ComponentModel.ISupportInitialize)(this.minBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aromaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // minBut
            // 
            this.minBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBut.Image = global::AromaFirebaseCsharpApp.Properties.Resources.min1;
            this.minBut.Location = new System.Drawing.Point(749, 0);
            this.minBut.Name = "minBut";
            this.minBut.Size = new System.Drawing.Size(83, 65);
            this.minBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBut.TabIndex = 4;
            this.minBut.TabStop = false;
            this.minBut.Click += new System.EventHandler(this.minBut_Click);
            this.minBut.MouseHover += new System.EventHandler(this.closeBut_MouseHover);
            // 
            // maxBut
            // 
            this.maxBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxBut.Image = global::AromaFirebaseCsharpApp.Properties.Resources.max;
            this.maxBut.Location = new System.Drawing.Point(832, 0);
            this.maxBut.Name = "maxBut";
            this.maxBut.Size = new System.Drawing.Size(83, 65);
            this.maxBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBut.TabIndex = 3;
            this.maxBut.TabStop = false;
            this.maxBut.Click += new System.EventHandler(this.maxBut_Click);
            this.maxBut.MouseHover += new System.EventHandler(this.closeBut_MouseHover);
            // 
            // closeBut
            // 
            this.closeBut.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBut.Image = global::AromaFirebaseCsharpApp.Properties.Resources.close1;
            this.closeBut.Location = new System.Drawing.Point(915, 0);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(83, 65);
            this.closeBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBut.TabIndex = 2;
            this.closeBut.TabStop = false;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            this.closeBut.MouseLeave += new System.EventHandler(this.but_MouseHover);
            this.closeBut.MouseHover += new System.EventHandler(this.closeBut_MouseHover);
            // 
            // aromaLogo
            // 
            this.aromaLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.aromaLogo.Image = global::AromaFirebaseCsharpApp.Properties.Resources.aroma;
            this.aromaLogo.Location = new System.Drawing.Point(0, 0);
            this.aromaLogo.Name = "aromaLogo";
            this.aromaLogo.Size = new System.Drawing.Size(89, 65);
            this.aromaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aromaLogo.TabIndex = 0;
            this.aromaLogo.TabStop = false;
            this.aromaLogo.Click += new System.EventHandler(this.aromaLogo_Click);
            this.aromaLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aromaLogo_MouseDown);
            this.aromaLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aromaLogo_MouseMove);
            this.aromaLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aromaLogo_MouseUp);
            // 
            // captionSoft
            // 
            this.captionSoft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionSoft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.captionSoft.Location = new System.Drawing.Point(89, 0);
            this.captionSoft.Name = "captionSoft";
            this.captionSoft.Size = new System.Drawing.Size(400, 65);
            this.captionSoft.TabIndex = 6;
            this.captionSoft.Text = "Aroma Odering Software";
            this.captionSoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.captionSoft.Click += new System.EventHandler(this.label1_Click);
            this.captionSoft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aromaLogo_MouseDown);
            this.captionSoft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aromaLogo_MouseMove);
            this.captionSoft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aromaLogo_MouseUp);
            // 
            // versionWriter
            // 
            this.versionWriter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("versionWriter.BackgroundImage")));
            this.versionWriter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.versionWriter.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionWriter.Location = new System.Drawing.Point(489, 0);
            this.versionWriter.Name = "versionWriter";
            this.versionWriter.Size = new System.Drawing.Size(260, 65);
            this.versionWriter.TabIndex = 5;
            this.versionWriter.Version = "1.0.0.0";
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.captionSoft);
            this.Controls.Add(this.versionWriter);
            this.Controls.Add(this.minBut);
            this.Controls.Add(this.maxBut);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.aromaLogo);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(998, 65);
            ((System.ComponentModel.ISupportInitialize)(this.minBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aromaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox aromaLogo;
        private System.Windows.Forms.PictureBox closeBut;
        private System.Windows.Forms.PictureBox maxBut;
        private System.Windows.Forms.PictureBox minBut;
        private VersionWriter versionWriter;
        private System.Windows.Forms.Label captionSoft;
    }
}
