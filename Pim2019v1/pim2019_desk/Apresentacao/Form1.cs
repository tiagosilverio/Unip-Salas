﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim2019_desk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCampus_Click(object sender, EventArgs e)
        {
            Apresentacao.frmCampus frmCampus = new Apresentacao.frmCampus();
            frmCampus.ShowDialog();
        }
    }
}
