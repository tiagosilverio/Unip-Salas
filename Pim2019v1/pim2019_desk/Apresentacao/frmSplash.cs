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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
            else
            {
                timer1.Enabled = false;
                Apresentacao.frmPrincipal frmPrincipal = new Apresentacao.frmPrincipal();
                this.Visible = false;
                frmPrincipal.ShowDialog();                   
            }
        }
    }
}
