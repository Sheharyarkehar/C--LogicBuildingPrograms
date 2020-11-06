namespace Sequal2
{
    partial class Display
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vSDBDataSet = new Sequal2.VSDBDataSet();
            this.demoDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDbTableAdapter = new Sequal2.VSDBDataSetTableAdapters.DemoDbTableAdapter();
            this.tutorialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutorialIDDataGridViewTextBoxColumn,
            this.tutorialNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demoDbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // vSDBDataSet
            // 
            this.vSDBDataSet.DataSetName = "VSDBDataSet";
            this.vSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demoDbBindingSource
            // 
            this.demoDbBindingSource.DataMember = "DemoDb";
            this.demoDbBindingSource.DataSource = this.vSDBDataSet;
            // 
            // demoDbTableAdapter
            // 
            this.demoDbTableAdapter.ClearBeforeFill = true;
            // 
            // tutorialIDDataGridViewTextBoxColumn
            // 
            this.tutorialIDDataGridViewTextBoxColumn.DataPropertyName = "TutorialID";
            this.tutorialIDDataGridViewTextBoxColumn.HeaderText = "TutorialID";
            this.tutorialIDDataGridViewTextBoxColumn.Name = "tutorialIDDataGridViewTextBoxColumn";
            // 
            // tutorialNameDataGridViewTextBoxColumn
            // 
            this.tutorialNameDataGridViewTextBoxColumn.DataPropertyName = "TutorialName";
            this.tutorialNameDataGridViewTextBoxColumn.HeaderText = "TutorialName";
            this.tutorialNameDataGridViewTextBoxColumn.Name = "tutorialNameDataGridViewTextBoxColumn";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 512);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VSDBDataSet vSDBDataSet;
        private System.Windows.Forms.BindingSource demoDbBindingSource;
        private VSDBDataSetTableAdapters.DemoDbTableAdapter demoDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorialNameDataGridViewTextBoxColumn;
    }
}