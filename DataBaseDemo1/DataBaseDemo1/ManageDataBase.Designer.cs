﻿namespace DataBaseDemo1
{
    partial class ManageDataBase
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
            this.AddnewStudentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddnewStudentbutton
            // 
            this.AddnewStudentbutton.Location = new System.Drawing.Point(148, 107);
            this.AddnewStudentbutton.Name = "AddnewStudentbutton";
            this.AddnewStudentbutton.Size = new System.Drawing.Size(99, 23);
            this.AddnewStudentbutton.TabIndex = 0;
            this.AddnewStudentbutton.Text = "AddNewStudent";
            this.AddnewStudentbutton.UseVisualStyleBackColor = true;
            this.AddnewStudentbutton.Click += new System.EventHandler(this.AddnewStudentbutton_Click);
            // 
            // ManageDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 344);
            this.Controls.Add(this.AddnewStudentbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddnewStudentbutton;
    }
}

