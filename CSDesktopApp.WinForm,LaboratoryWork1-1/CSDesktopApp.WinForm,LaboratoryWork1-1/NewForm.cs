﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDesktopApp.WinForm_LaboratoryWork1_1
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxClose.Checked) return;
            e.Cancel = true;
            Hide();
        }


    }
}
