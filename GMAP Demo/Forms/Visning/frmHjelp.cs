﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frmHjelp : Form
    {
        public frmHjelp()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearData(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}