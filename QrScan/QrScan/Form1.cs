﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0, "Please select any value");
            comboBox1.Enabled = false;
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
            }
          else if (checkBox1.Checked == false)
          {
              comboBox1.Enabled = false;
          }
        }
    }
}
